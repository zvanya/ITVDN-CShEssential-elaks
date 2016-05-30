using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    static void Main(string[] args)
    {
      Player p = new Player();

      p.Play();
      p.Stop();
      p.Record();
      p.Pause();
      p.Stop();

      Console.ReadKey();
    }
  }
}
