using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите дату своего рождения: ");

      DateTime birthday = DateTime.Parse(Console.ReadLine());
      DateTime now = DateTime.Now;

      DateTime nextBirthdayYear = now.AddYears(1);
      string nextBirthday = string.Format ("{0}.{1}.{2}", birthday.Day, birthday.Month, nextBirthdayYear.Year);

      Console.WriteLine("Сегодня: {0}", now);

      Console.WriteLine("Дата рождения: {0}", birthday.ToString());
      Console.WriteLine("Следующий день рождения: {0}", DateTime.Parse(nextBirthday));

      Console.WriteLine("До следующего дня рождения: \n дней: {0}", ((TimeSpan)(DateTime.Parse(nextBirthday) - now)).Days);

      Console.ReadKey();
    }
  }
}
