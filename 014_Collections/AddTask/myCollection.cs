using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    class myCollection : IEnumerable
    {
        int?[] arr = null;
        int position = -1;

        public int? this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }

        public myCollection(int?[] a)
        {
            int k = 0; //количество четных элементов
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0) k++;

            arr = new int?[k];

            k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    k++;
                    arr[k - 1] = a[i];
                }
            }

        }

        void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < arr.Length - 1)
                {
                    position++;
                    yield return arr[position];
                }
                else
                {
                    Reset();
                    yield break;  // Выход из цикла.       
                }
            }

        }
    }
}
