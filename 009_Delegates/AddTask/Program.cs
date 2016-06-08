using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    public delegate double MathAvg(int x1, int x2, int x3);

    static void Main(string[] args)
    {
      MathAvg avg = delegate (int x1, int x2, int x3) { return (Convert.ToDouble(x1 + x2 + x3) / 3); };

      Console.WriteLine("avg(5, 5, 7) = {0:N3}", avg(5, 5, 7));

      Console.ReadKey();
    }
  }
}
