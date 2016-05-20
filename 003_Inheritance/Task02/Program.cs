using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Program
  {
    static void Main(string[] args)
    {
      ClassRoom c1 = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new ExcelentPupil(), new BadPupil());
      c1.ShowInfo();

      Console.ReadKey();
    }
  }
}
