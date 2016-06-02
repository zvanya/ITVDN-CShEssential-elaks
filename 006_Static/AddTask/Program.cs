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
      public static float Add(float x1, float x2)
      {
        return x1 + x2;
      }
      public static float Dev(float x1, float x2)
      {
        return x2 != 0 ? x1 / x2 : 0;
      }

    }
    static void Main(string[] args)
    {

      Console.WriteLine(Calculator.Add(15, 5));
      Console.ReadKey();
    }
  }
}
