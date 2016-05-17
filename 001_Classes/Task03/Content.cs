using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Content
  {
    string text = null;

    public Content(string text)
    {
      this.text = text;
    }

    public string Text
    {
      get
      {
        return text;
      }
      set
      {
        text = value;
      }
    }

    void Show()
    {
      Console.WriteLine("Контент: {0}", text);
    }
  }
}
