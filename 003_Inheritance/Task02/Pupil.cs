using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
  class Pupil
  {
    public virtual void Study()
    { }
    public virtual void Read()
    { }
    public virtual void Write()
    { }
    public virtual void Relax()
    { }
  }

  class ExcelentPupil : Pupil
  {
    public override void Study()
    {
      Console.WriteLine("Excelent Study");
    }
    public override void Read()
    {
      Console.WriteLine("Excelent Read");
    }
    public override void Write()
    {
      Console.WriteLine("Excelent Write");
    }
    public override void Relax()
    {
      Console.WriteLine("Excelent Relax");
    }
  }
  class GoodPupil : Pupil
  {
    public override void Study()
    {
      Console.WriteLine("Good Study");
    }
    public override void Read()
    {
      Console.WriteLine("Good Read");
    }
    public override void Write()
    {
      Console.WriteLine("Good Write");
    }
    public override void Relax()
    {
      Console.WriteLine("Good Relax");
    }
  }
  class BadPupil : Pupil
  {
    public override void Study()
    {
      Console.WriteLine("Bad Study");
    }
    public override void Read()
    {
      Console.WriteLine("Bad Read");
    }
    public override void Write()
    {
      Console.WriteLine("Bad Write");
    }
    public override void Relax()
    {
      Console.WriteLine("Bad Relax");
    }
  }
}
