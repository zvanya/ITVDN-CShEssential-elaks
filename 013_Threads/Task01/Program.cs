using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task01
{
    class Arg
    {
        public int Length { get; set; }
        public int Delay { get; set; }
        public int ColNumber { get; set; }
    }

    class Program
    {
        static int maxRows = 40;
        static int maxCols = 5;
        static Thread t = null;
        static Random r = null;

        static void ShowSymbol(int offset, string symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string(' ', offset) + symbol);
        }

        // n - массив. [0] - количество символов в столбце; [1] - задержка старта потока; [2] - номер колонки потока
        static void DrawColumn(object o)
        {
            Arg arg = o as Arg;

            Thread.Sleep(arg.Delay);

            int k = maxRows - arg.Length;
            while (k > 0)
            {
                Console.Clear();

                for (int i = 0; i < maxRows - k - arg.Length; i++)
                    Console.WriteLine();

                for (int i = arg.Length; i >= 0; i--)
                {
                    ConsoleColor color = ConsoleColor.DarkGreen;
                    if (i == 0) color = ConsoleColor.White;
                    if (i == 1) color = ConsoleColor.Green;
                    ShowSymbol(arg.ColNumber, "@", color);
                }
                k--;
            }
        }

        static void Main(string[] args)
        {
            r = new Random();
            Arg arg = new Arg();

            for (int i = 0; i < maxCols; i++)
            {
                arg.Length = r.Next(10);
                arg.Delay = r.Next(1000, 5000);
                arg.ColNumber = i + 1;

                t = new Thread(DrawColumn);
                t.Start(arg);
            }

            Console.ReadKey();
        }
    }
}
