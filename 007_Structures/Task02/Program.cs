using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  struct Train
  {
    public string TrainNumber { set; get; }
    public string Destination { set; get; }
    public string DepartureTime { set; get; }

    public void ShowInfo()
    {
      Console.Write("Номер поезда:");
      Console.WriteLine(TrainNumber);
      Console.Write("Пункт назначения:");
      Console.WriteLine(Destination);
      Console.Write("Время отправления:");
      Console.WriteLine(DepartureTime);
      Console.WriteLine(new string('-', 50));
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      int trainCount = 3;
      string trainNumber = null;

      Train[] t = new Train[trainCount];

      for (int i = 0; i < trainCount; i++)
      {
        Console.WriteLine("Введите информацию о {0}-м поезде:", i+1);
        Console.Write("Номер поезда:");
        t[i].TrainNumber = Console.ReadLine();
        Console.Write("Пункт назначения:");
        t[i].Destination = Console.ReadLine();
        Console.Write("Время отправления:");
        t[i].DepartureTime = Console.ReadLine();

        Console.WriteLine(new string('-',50));
      }

      for (int i = 0; i < trainCount; i++)
        t[i].ShowInfo();

      Console.WriteLine(new string('-', 50));
      Console.WriteLine(new string('-', 50));
      Console.Write("Введите номер поезда:");
      trainNumber = Console.ReadLine();
      int result = 0;
      for (int i = 0; i < trainCount; i++)
      {
        if (t[i].TrainNumber == trainNumber)
        {
          result = 1;
          t[i].ShowInfo();
          break;
        }
      }
      if (result == 0)
      {
        Console.WriteLine("Поезд с таким номером не найден.");
      }
      Console.ReadKey();
    }
  }
}
