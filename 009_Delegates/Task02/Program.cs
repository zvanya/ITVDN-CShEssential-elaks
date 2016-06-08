using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Program
  {
    public delegate double myMath(double x1, double x2);

    static void Main(string[] args)
    {
      myMath Add = (x1, x2) => { return x1 + x2; };
      myMath Sub = (x1, x2) => { return x1 - x2; };
      myMath Mul = (x1, x2) => { return x1 * x2; };
      myMath Div = (x1, x2) => 
                               {
                                 if (x2 == 0)
                                 {
                                   Console.WriteLine("Деление на ноль!");
                                   return 0;
                                 }
                                 else return x1 / x2;
                               };

      Console.WriteLine("Add(5, 7) = {0}", Add(5, 7));
      Console.WriteLine("Sub(5, 7) = {0}", Sub(5, 7));
      Console.WriteLine("Mul(5, 7) = {0}", Mul(5, 7));
      Console.WriteLine("Div(5, 7) = {0}", Div(5, 7));
      Console.WriteLine(new string('-', 50));
      Console.WriteLine("Div(5, 0) = {0}", Div(5, 0));

      Console.ReadKey();
    }
  }
}
