using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task02
{
    class Program
    {
        static int maxRows = 30;
        static int maxCols = 100;
        static Random r = null;
        static object locker1 = new object();
        static object locker2 = new object();
        static object locker3 = new object();
        static object locker4 = new object();
        static int tName = 0;
        static Dictionary<int, int> colnum = new Dictionary<int, int>();
        static int colNumber = 0;
        static char[] char_arr = new char[] { '!', '@', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

        static void DrawColumn()
        {
            int length = 0;
            int k = 0; // количество шагов до следующего круга
            int lastCurPos = 0;

            lock (locker2)
            {
                tName = int.Parse(Thread.CurrentThread.Name);
                colnum.Add(tName, colNumber);

                colNumber += 2;
                if (colNumber > maxCols) colNumber = 0;

                length = r.Next(3, 5);

                k = maxRows - length;
            }

            while (k > 0)
            {
                Thread.Sleep(r.Next(20, 2000));

                lock (locker2)
                {
                    int threadName = int.Parse(Thread.CurrentThread.Name);

                    int colNumByThreadName; // = threadName <= maxCols - 1 ? threadName : threadName - maxCols - 1;

                    colNumByThreadName = colnum[threadName];

                    if (lastCurPos == 0)
                    {
                        Console.SetCursorPosition(colNumByThreadName, 0);
                    }
                    else
                    {
                        Console.SetCursorPosition(colNumByThreadName, lastCurPos - length - 1);

                        for (int i = 0; i < length; i++)
                        {
                            Console.Write(" ");
                            Console.SetCursorPosition(colNumByThreadName, Console.CursorTop + 1);
                        }
                        Console.SetCursorPosition(colNumByThreadName, Console.CursorTop - length + 1);
                    }


                    for (int i = length; i >= 0; i--)
                    {
                        ConsoleColor color = ConsoleColor.DarkGreen;
                        if (i == 1) color = ConsoleColor.Green;
                        if (i == 0) color = ConsoleColor.White;
                        Console.ForegroundColor = color;
                        Console.Write(char_arr[r.Next(0, char_arr.Length)]);

                        Console.SetCursorPosition(colNumByThreadName, Console.CursorTop + 1);
                    }
                    lastCurPos = Console.CursorTop;
                    k--;

                    if (k == 0)
                    {
                        for (int i = maxRows - length - 1; i < maxRows; i++)
                        {
                            Console.SetCursorPosition(colNumByThreadName, i);
                            Console.Write(" ");
                        }
                        k = maxRows - length;
                        lastCurPos = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            r = new Random();

            Console.WindowHeight = maxRows + 10;
            Console.WindowWidth = maxCols + 10;

            Console.CursorVisible = false;

            for (int i = 0; i < maxCols; i++)
            {
                new Thread(DrawColumn)
                { Name = Convert.ToString(i) }.Start();
            }

            Console.ReadKey();
        }
    }
}
