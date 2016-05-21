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
      Car c = new Car(20000, 250, 2010);
      c.X = 100;
      c.Y = 100;
      c.ShowInfo();

      Plane p = new Plane(3000000, 1000, 2005, 15, 500);
      p.X = 22;
      p.Y = 33;
      p.ShowInfo();

      Ship s = new Ship(1000000, 60, 1980, "Odessa", 1200);
      s.ShowInfo();

      Console.ReadKey();
    }
  }
}
