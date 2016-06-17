using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AddTask
{
    class Program
    {
        static Thread t = null;
        static int k = 15;

        static void myMethod()
        {
            t = new Thread(myMethod);
            Console.WriteLine("myMethod - {0}", k);

            k--;

            if (k == 0) Thread.CurrentThread.Abort();

            t.Start();
        }

        static void Main(string[] args)
        {
            t = new Thread(myMethod);
            t.Start();

            Console.ReadKey();
        }
    }
}
