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
      Address a = new Address();

      a.Index = "61000";
      a.City = "Kharkov";

      Console.WriteLine("a.Index = {0}", a.Index);

      Console.ReadKey();
    }
  }
}
