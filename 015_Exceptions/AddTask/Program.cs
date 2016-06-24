using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    class Calculator
    {
        static public double? Add(double? x1, double? x2)
        {
            try
            {
                if (x1 < 0 || x2 < 0) throw new Exception("x1 или x2 < 0");
                return x1 + x2;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return null;
            }
        }

        static public int? Div(int? x1, int? x2)
        {
            try
            {
                return x1 / x2;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 / 0 = {0}", Calculator.Div(5, 0) != null ? (Calculator.Div(5, 0)).ToString() : "null");
            Console.WriteLine($"5 + 7 = {Calculator.Add(5, 7)}");
            Console.WriteLine($"-5 + 7 = {Calculator.Add(-5, 7)}");

            Console.ReadKey();
        }
    }
}
