using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Player : IPlayable, IRecordable
  {
    public void Pause()
    {
      Console.WriteLine("Pause");
    }

    public void Play()
    {
      Console.WriteLine("Play");
    }

    public void Record()
    {
      Console.WriteLine("Record");
    }

    public void Stop()
    {
      Console.WriteLine("Stop");
    }
  }
}
