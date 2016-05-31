using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    static void Main(string[] args)
    {
      MyMatrix m = new MyMatrix(10, 10);

      Console.WriteLine("Массив MyMatrix.m: ");
      m.Show();

      m.Resize(5, 5);
      Console.WriteLine();
      Console.WriteLine("Новый массив MyMatrix.m: ");
      m.Show();

      float[,] mm = new float[5, 5];
      Random r = new Random();
      for (int i = 0; i < mm.GetLength(0); i++)
        for (int j = 0; j < mm.GetLength(1); j++)
          mm[i, j] = r.Next(0, 101);

      Console.WriteLine();
      Console.WriteLine("Массив mm: ");
      for (int i = 0; i < mm.GetLength(0); i++)
      {
        for (int j = 0; j < mm.GetLength(1); j++)
          Console.Write("{0} ", mm[i, j]);
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine("Новый массив mm, полученный статическим методом класса MyMatrix: ");
      MyMatrix.Resize(3, 2, ref mm);
      for (int i = 0; i < mm.GetLength(0); i++)
      {
        for (int j = 0; j < mm.GetLength(1); j++)
          Console.Write("{0} ", mm[i, j]);
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
