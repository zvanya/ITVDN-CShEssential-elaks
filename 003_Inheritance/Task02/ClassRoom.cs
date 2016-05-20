using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class ClassRoom
  {
    Pupil[] p;
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
    {
      p = new Pupil[4];
      p[0] = p1;
      p[1] = p2;
      p[2] = p3;
      p[3] = p4;
    }
    public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
    {
      p = new Pupil[3];
      p[0] = p1;
      p[1] = p2;
      p[2] = p3;
    }
    public ClassRoom(Pupil p1, Pupil p2)
    {
      p = new Pupil[2];
      p[0] = p1;
      p[1] = p2;
    }

    public void ShowInfo()
    {
      for (int i = 0; i < p.Length; i++)
      {
        Console.WriteLine("Ученик {0}", i+1);
        p[i].Study();
        p[i].Read();
        p[i].Write();
        p[i].Relax();
        Console.WriteLine(new string('-',50));
      }
    }
  }
}
