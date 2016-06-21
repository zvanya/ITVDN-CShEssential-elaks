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
        static int maxCols = 60;
        static Thread t = null;
        static Random r = null;
        static object locker1 = new object();
        static object locker2 = new object();
        static int tName = 0;
        static Dictionary<int, int> colnum = new Dictionary<int, int>();
        static int colNumber = 0;
        static char[] char_arr = new char[] { '!', '@', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };

        static void DrawColumn()
        {
            int length = 0;
            int k = 0;

            lock (locker2)
            {
                tName = int.Parse(Thread.CurrentThread.Name);
                colnum.Add(tName, colNumber);

                colNumber += 2;

                length = r.Next(3, 7);

                k = maxRows - length;
            }

            while (k > 0)
            {
                Thread.Sleep(r.Next(10, 4000));

                lock (locker2)
                {
                    int colNumByHashCode = colnum[int.Parse(Thread.CurrentThread.Name)];

                    Console.SetCursorPosition(colNumByHashCode, 0);

                    for (int i = 0; i < maxRows - k - length; i++)
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(colNumByHashCode, Console.CursorTop + 1);
                    }

                    for (int i = length; i >= 0; i--)
                    {
                        ConsoleColor color = ConsoleColor.DarkGreen;
                        if (i == 0) color = ConsoleColor.White;
                        if (i == 1) color = ConsoleColor.Green;
                        Console.ForegroundColor = color;
                        Console.Write(char_arr[r.Next(0, char_arr.Length)]);

                        Console.SetCursorPosition(colNumByHashCode, Console.CursorTop + 1);
                    }
                    k--;
                    if (k == 0)
                    {
                        for (int i = 0; i < maxRows; i++)
                        {
                            Console.SetCursorPosition(colNumByHashCode, i);
                            Console.Write(" ");
                        }
                        k = maxRows - length;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            r = new Random();

            Console.WindowWidth = maxCols * 2;
            Console.WindowHeight = 50;

            Console.CursorVisible = false;

            for (int i = 0; i < maxCols; i++)
            {
                t = new Thread(DrawColumn);
                t.Name = Convert.ToString(i);
                t.Start();
            }

            Console.ReadKey();
        }
    }
}
