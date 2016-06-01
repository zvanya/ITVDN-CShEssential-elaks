using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class MyClass
  {
    public string change = null;
  }
  struct MyStruct
  {
    public string change;
  }

  class Program
  {
    static void ClassTaker(MyClass myClass)
    {
      myClass.change = "изменено";
    }

    static void StructTaker(MyStruct myStruct)
    {
      myStruct.change = "изменено";
    }

    static void Main(string[] args)
    {
      MyClass c = new MyClass();
      MyStruct s = new MyStruct();

      Console.WriteLine("c.change = {0}", c.change);
      Console.WriteLine("s.change = {0}", s.change);
      Console.WriteLine(new string('-', 50));

      c.change = "не изменено";
      s.change = "не изменено";

      Console.WriteLine("c.change = {0}", c.change);
      Console.WriteLine("s.change = {0}", s.change);
      Console.WriteLine(new string('-', 50));

      ClassTaker(c);
      StructTaker(s);

      Console.WriteLine("c.change = {0}", c.change);
      Console.WriteLine("s.change = {0}", s.change);
      Console.WriteLine(new string('-', 50));

      Console.ReadKey();
    }
  }
}
