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

    public string Article { get; set; } = null; // товар
    int quantity = 0; // количество товара

    double tax = 0.1;
    double articleCost = 0;

    public Invoice(int account, string customer, string provider)
    {
      this.account = account;
      this.customer = customer;
      this.provider = provider;
    }

    public int Account { get { return account; } }
    public string Customer { get { return customer; } }
    public string Provider { get { return provider; } }

    public int Quantity
    {
      get { return quantity; }
      set { quantity = Math.Abs(value); }
    }
    public double ArticleCost
    {
      get { return articleCost; }
      set { articleCost = Math.Abs(value); }
    }
    public double Tax
    {
      get { return tax; }
      set { tax = value == 0 ? 1 : Math.Abs(value); }
    }

    public double CostWithTaxCalculate()
    {
      return CostCalculate() + Tax * CostCalculate();
    }
    public double CostCalculate()
    {
      return Quantity * ArticleCost;
    }
  }
}
