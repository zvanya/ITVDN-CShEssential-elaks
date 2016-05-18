using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    static void Main(string[] args)
    {

      Employee emp1 = new Employee("name1", "surname1");
      emp1.Position = Employee.PositionList.pos3;
      emp1.Experience = 2;

      Console.WriteLine("Ставка pos1 = 1000");
      Console.WriteLine("Ставка pos2 = 500");
      Console.WriteLine("Ставка pos3 = 100");
      Console.WriteLine(new string('-', 50));
      Console.WriteLine("ЗП = Ставка * 1.2 * Стаж");
      Console.WriteLine("Налог = ЗП * 0.1");
      Console.WriteLine(new string('-',50));

      Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность :{2}\nСтаж: {3}\nЗарплата: {4}\nНалоговый сбор: {5}", emp1.Name, emp1.Surname, emp1.Position, emp1.Experience, emp1.Pay, emp1.Tax);

      Console.ReadKey();
    }
  }
}
