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
        static int k = 0;

        static void myMethod(object arg)
        {
            t = new Thread(myMethod);
            Console.WriteLine("myMethod - {0}", k);

            k++;

            if (k == (int)arg) Thread.CurrentThread.Abort();

            t.Start(15);
        }

        static void Main(string[] args)
        {
            t = new Thread(myMethod);
            t.Start(15);

            Console.ReadKey();
        }
    }
}
