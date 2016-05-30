using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    static class Calculator
    {
      public static float Plus(float x1, float x2)
      {
        return x1 + x2;
      }
      public static float Dev(float x1, float x2)
      {
        return x1 / x2;
      }

    }
    static void Main(string[] args)
    {

      Console.WriteLine(Calculator.Plus(15, 5));
      Console.ReadKey();
    }
  }
}
