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
      int key = 0;
      const int keyPro = 111;
      const int keyExpert = 222;

      DocumentWorker dw = null;

      Console.Write("Введите ключ продукта: ");

      int.TryParse(Console.ReadLine(), out key);
      
      //try
      //{
      //  key = int.Parse(Console.ReadLine());
      //}
      //catch (Exception)
      //{
      //  key = 0;
      //}

      switch (key)
      {
        case keyPro:
          dw = new ProDocumentWorker();
          break;
        case keyExpert:
          dw = new ExpertDocumentWorker();
          break;
        default:
          dw = new DocumentWorker();
          break;
      }

      dw.Open();
      dw.Edit();
      dw.Save();

      Console.ReadKey();
    }
  }
}
