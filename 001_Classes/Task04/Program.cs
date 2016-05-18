using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Program
  {
    static void Main(string[] args)
    {
      Point A = new Point("A", -31, 4);
      Point B = new Point("B", 8, 3);

      Figure f3 = new Figure(A, B, new Point("C", 1, 7));

      Console.WriteLine("Фигура: {0}\nПериметр: {1}", f3.Name, f3.PerimeterCalculator());

      Console.ReadKey();
    }
  }
}
