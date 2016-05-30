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
      AbstractHandler XMLDoc = new XMLHandler();
      XMLDoc.Open();
      XMLDoc.Change();
      XMLDoc.Save();

      AbstractHandler TXTDoc = new TXTHandler();
      TXTDoc.Open();
      TXTDoc.Change();
      TXTDoc.Save();

      Console.ReadKey();
    }
  }
}
