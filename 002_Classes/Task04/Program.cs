using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Program
  {
    static void Main(string[] args)
    {
      Invoice inv = new Invoice(1, "Клиент1", "Поставщик1");

      inv.Article = "Товар1";
      inv.ArticleCost = 100;
      inv.Tax = 0.2;
      inv.Quantity = 5;

      Console.WriteLine("Счет №{0}\nКлиент: {1}\nПоставщик: {2}\nТовар: {3}\nЦена: {4}\nНДС: {5}%\nКоличество: {6}", inv.Account, inv.Customer, inv.Provider, inv.Article, inv.ArticleCost, inv.Tax * 100, inv.Quantity);
      Console.WriteLine(new string('-',50));
      Console.WriteLine("Цена без НДС: {0}", inv.CostCalculate());
      Console.WriteLine("Цена с НДС: {0}", inv.CostWithTaxCalculate());

      Console.ReadKey();
    }
  }
}
