using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Author
  {
    string name = null;

    public Author(string name)
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
      Console.WriteLine("Автор: {0}", name);
    }
  }
}
