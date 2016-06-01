using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  struct Notebook
  {
    string model;
    string manufactor;
    float price;

    public Notebook(string model, string manufactor, float price)
    {
      this.model = model;
      this.manufactor = manufactor;
      this.price = price;
    }

    public void ShowInfo()
    {
      Console.WriteLine("Ноутбук: {0}", manufactor);
      Console.WriteLine("Модель: {0}", model);
      Console.WriteLine("Цена: {0}", price);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Notebook n = new Notebook("A33J5", "Asus", 20000);
      n.ShowInfo();

      Console.ReadKey();
    }
  }
}
