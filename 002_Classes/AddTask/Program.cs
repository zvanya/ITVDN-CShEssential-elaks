using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Program
  {
    class User
    {
      readonly string registrationDate = null;

      public User(string registrationDate)
      {
        this.registrationDate = registrationDate;
      }

      public string RegistrationDate { get; }
      public string Login { get; set; }
      public string Name { get; set; }
      public string Surname { get; set; }
      public string Age { get; set; }

      public void ShowInfo()
      {
        Console.WriteLine("User: {0}\nДата регистрации: {1}\nЛогин: {2}", Name, registrationDate, Login);
      }
    }

    static void Main(string[] args)
    {
      User myUser = new User("2005.05.18");

      myUser.Name = "name1";
      myUser.Login = "login1";
      myUser.ShowInfo();

      Console.ReadKey();
    }
  }
}
