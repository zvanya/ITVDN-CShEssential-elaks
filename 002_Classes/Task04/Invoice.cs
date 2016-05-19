using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Invoice // Счет-фактура
  {
    readonly int account = 0; // счет
    readonly string customer = null; // клиент
    readonly string provider = null; // поставщик

    string article = null; // товар
    int quantity = 0; // количество товара

    double tax = 0.1;
    double articleCost = 50;

    public Invoice(int account, string customer, string provider)
    {
      this.account = account;
      this.customer = customer;
      this.provider = provider;
    }

    public int Account { get { return account; } }
    public string Customer { get { return customer; } }
    public string Provider { get { return provider; } }


  }
}
