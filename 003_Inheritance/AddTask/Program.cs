using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Printer
  {
    public virtual void Print(string value)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine(value);
    }
  }

  class HP : Printer
  {
    public override void Print(string value)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(value);
    }
  }
  class Canon : Printer
  {
    public override void Print(string value)
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(value);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {

      Printer c = new Canon();

      c.Print("canon");

      Printer p = c as Printer;

      p.Print("printer");

      Printer hp = new HP();

      hp.Print("HP");

      Console.ReadKey();
    }
  }
}
