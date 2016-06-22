using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    class Program
    {
        static myCollection GetCollection(int?[] a)
        {
            return new myCollection(a);
        }

        static void Main(string[] args)
        {
            int?[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            myCollection mC = new myCollection(arr);

            foreach (int? item in mC)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < mC.Count + 1; i++)
            {
                Console.WriteLine(mC[i] != null ? mC[i].ToString() : "null");
                
            }

            Console.ReadKey();
        }
    }
}
