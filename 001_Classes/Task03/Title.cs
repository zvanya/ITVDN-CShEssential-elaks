using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Title
  {
    string name = null;

    public Title(string name)
    {
      this.name = name;
    }

    public string Name
    {
      get
      {
        return name;
      }
      set
      {
        name = value;
      }
    }

    void Show()
    {
      Console.WriteLine("Название: {0}", name);
    }
  }
}
