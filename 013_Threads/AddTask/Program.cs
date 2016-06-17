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
        static string exit = null;

        static void myMethod()
        {
            t = new Thread(myMethod);
            Console.WriteLine("myMethod");

            string exit = Console.ReadLine();

            if (exit == "exit") Thread.CurrentThread.Abort();

            t.Start();
        }

        static void Main(string[] args)
        {
            t = new Thread(myMethod);
            t.Start();
        }
    }
}
