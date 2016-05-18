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
      double val = 0;

      Converter c = new Converter(26, 27, 2.5);
      
      val = 1;
      Console.WriteLine("{0} usd - {1} uah", val, c.ToUah(val, Converter.Currency.usd));

      val = 26;
      Console.WriteLine("{0} uah - {1} usd", val, c.UahTo(val, Converter.Currency.usd));

      Console.ReadKey();
    }
  }
}
