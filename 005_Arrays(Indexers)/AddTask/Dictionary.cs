using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
  class Dictionary
  {

    private string[] ru = new string[5];
    private string[] eng = new string[5];
    private string[] ua = new string[5];

    public Dictionary()
    {
      ru[0] = "книга"; eng[0] = "book"; ua[0] = "книжка";
      ru[1] = "ручка"; eng[1] = "pen"; ua[1] = "ручка";
      ru[2] = "солнце"; eng[2] = "sun"; ua[2] = "синце";
      ru[3] = "яблоко"; eng[3] = "apple"; ua[3] = "яблуко";
      ru[4] = "стол"; eng[4] = "table"; ua[4] = "стил";
    }

    public string this[string index]
    {
      get
      {
        for (int i = 0; i < ru.Length; i++)
        {
          if (ru[i] == index)
            return ru[i] + " - " + eng[i] + " - " + ua[i];

          if (ua[i] == index)
            return ua[i] + " - " + eng[i] + " - " + ru[i];

          if (eng[i] == index)
            return eng[i] + " - " + ua[i] + " - " + ru[i];
        }

        return string.Format("{0} - нет перевода для этого слова.", index);
      }
    }
  }
}
