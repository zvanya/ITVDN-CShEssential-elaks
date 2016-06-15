using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class MyClass
  {
    public Action PressKeyA = null;
    public Action PressKeyB = null;

    void PressKeyAEvent()
    {
      if (PressKeyA != null)
      {
        PressKeyA.Invoke();
      }
    }
    void PressKeyBEvent()
    {
      if (PressKeyB != null)
      {
        PressKeyB.Invoke();
      }
    }

    public void Start()
    {
      bool ok = true;
      while (ok)
      {
        string s = Console.ReadLine();
        switch (s)
        {
          case "A":
          case "a":
            PressKeyAEvent();
            break;
          case "B":
          case "b":
            PressKeyBEvent();
            break;
          case "exit":
            ok = false;
            break;
          default:
            break;
        }
      }
      Console.WriteLine("Exit!");
    }
  }


  class Program
  {
    static void PressKeyAHandler()
    {
      Console.WriteLine("Нажата клавиша A");
    }
    static void PressKeyBHandler()
    {
      Console.WriteLine("Нажата клавиша B");
    }

    static void Main(string[] args)
    {
      MyClass mC = new MyClass();

      mC.PressKeyA += PressKeyAHandler;
      mC.PressKeyB += PressKeyBHandler;

      mC.Start();

      Console.ReadKey();
    }
  }
}
  