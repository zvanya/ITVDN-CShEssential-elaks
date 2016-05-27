using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary dictionary = new Dictionary();

      Console.WriteLine(dictionary["книга"]);
      Console.WriteLine(dictionary["дом"]);
      Console.WriteLine(new string('-', 20));
      Console.WriteLine(dictionary["book"]);
      Console.WriteLine(dictionary["table"]);
      Console.WriteLine(new string('-', 20));
      Console.WriteLine(dictionary["карандаш"]);
      Console.WriteLine(dictionary["яблуко"]);
      Console.WriteLine(dictionary["синце"]);

      Console.WriteLine(new string('-', 20));

      // Delay.
      Console.ReadKey();
    }
  }
}
