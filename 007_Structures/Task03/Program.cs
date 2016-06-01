using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  struct MyStruct
  {
    public string change;
  }
  class MyClass
  {
    public string change = null;
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
    }
  }
}
