using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class MyClass<T> where T : new()
  {
    static public T FactoryMethod()
    {
      return new T();
    }
  }

  class A
  {
    public void Print()
    {
      Console.WriteLine("ClassA");
    }
  }
  class B
  {
    public void Print()
    {
      Console.WriteLine("ClassB");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      A a = MyClass<A>.FactoryMethod();
      a.Print();

      B b = MyClass<B>.FactoryMethod();
      b.Print();

      Console.ReadKey();    
    }
  }
}
