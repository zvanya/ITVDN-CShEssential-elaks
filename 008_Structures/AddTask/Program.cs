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
      DateTime nextBirthday;

      int daysToNextBirthday = 0;

      Console.WriteLine("Сегодня: {0}", now);

      Console.WriteLine("Дата рождения: {0}", birthday.ToString());

      int days = birthday.AddYears(now.Year - birthday.Year).DayOfYear - now.DayOfYear;

      //int days = new DateTime(now.Year, birthday.Month, birthday.Day).DayOfYear - now.DayOfYear;

      if (days > 0)
      {
        nextBirthday = new DateTime(now.Year, birthday.Month, birthday.Day);
        daysToNextBirthday = days;
      }
      else
      {
        nextBirthday = new DateTime(nextBirthdayYear.Year, birthday.Month, birthday.Day);
        daysToNextBirthday = Math.Abs(days) + ((TimeSpan)(nextBirthday - now)).Days;
      }

      Console.WriteLine("Следующий день рождения: {0}", nextBirthday);
      Console.WriteLine("До следующего дня рождения дней: {0}", daysToNextBirthday);

      Console.WriteLine("Вы прожили дней: {0}", ((TimeSpan)(now - birthday)).Days);

      Console.ReadKey();
    }
  }
}
