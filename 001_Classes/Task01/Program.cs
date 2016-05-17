using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
  class Program
  {
    static void Main(string[] args)
    {
      double side1 = 0, side2 = 0;

      Console.Write("Введите длины сторон прямоугольника.\nСторона 1: ");
      try
      {
        side1 = double.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Некорректное значение. Сторона 1: {0}", side1);
        side1 = 0;
        Console.WriteLine("Сторона 1: {0}", side1);
      }

      Console.Write("Сторона 2: ");
      try
      {
        side2 = double.Parse(Console.ReadLine());
      }
      catch (Exception)
      {
        Console.WriteLine("Некорректное значение. Сторона 2: {0}", side2);
        side2 = 0;
        Console.WriteLine("Сторона 2: {0}", side2);
      }

      Console.WriteLine(new string('-',50));

      Rectangle rec1 = new Rectangle(side1, side2);

      Console.WriteLine("Perimeter = {0}", rec1.Perimeter);
      Console.WriteLine("Area = {0}", rec1.Area);

      Console.ReadKey();
    }
  }
}
