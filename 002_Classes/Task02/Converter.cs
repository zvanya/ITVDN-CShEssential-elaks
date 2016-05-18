using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Converter
  {
    public enum Currency { usd, eur, rub };

    double usd = 0;
    double eur = 0;
    double rub = 0;

    public Converter(double usd, double eur, double rub)
    {
      this.usd = usd;
      this.eur = eur;
      this.rub = rub;
    }

    public double UahTo(double uah, Currency cur)
    {
      switch (cur)
      {
        case Currency.usd:
          return uah / usd;
        case Currency.eur:
          return uah / eur;
        case Currency.rub:
          return uah / rub;
      }
      return -1;
    }

    public double ToUah(double curVal, Currency cur)
    {
      switch (cur)
      {
        case Currency.usd:
          return curVal * usd;
        case Currency.eur:
          return curVal * eur;
        case Currency.rub:
          return curVal * rub;
      }
      return -1;
    }

  }
}
