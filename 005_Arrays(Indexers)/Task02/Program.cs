using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] m = new int[new Random().Next(5,21)];

      Random r = new Random();

      for (int i = 0; i < m.Length; i++)
        m[i] = r.Next(0, 101);

      for (int i = 0; i < m.Length; i++)
        Console.Write("{0} ", m[i]);

      Console.WriteLine();

      Console.WriteLine("Summ = {0}", m.Sum());
      Console.WriteLine("Max = {0}", m.Max());

      Console.ReadKey();
    }
  }
}
