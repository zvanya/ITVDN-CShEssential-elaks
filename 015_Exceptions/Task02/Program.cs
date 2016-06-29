using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 5, 1, 4, 2, 3, 3, 0, 4, 1 };

            List<int> l = new List<int> { 0, 1, 0, 0, 2, 3, 4, 5 };

            IEnumerable<int> s = new List<int>();
            s = l.Distinct();

            

            foreach (int item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
