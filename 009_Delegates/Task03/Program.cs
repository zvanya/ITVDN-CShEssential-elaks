using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  class Program
  {
    public delegate double myMath(myDelegate[] d);
    public delegate int myDelegate();

    static Random r = new Random();

    static void Main(string[] args)
    {
      myDelegate[] d = new myDelegate[] { () => r.Next(0, 100), () => r.Next(0, 100), () => r.Next(0, 100) };

      myMath mMAvg = delegate (myDelegate[] l)
                  {
                    double sum = 0;
                    for (int i = 0; i < l.Length; i++)
                    {
                      int a = l[i].Invoke();
                      sum += a;
                      Console.WriteLine("d[{0}] = {1}", i, a);
                    }
                    Console.WriteLine(new string('-', 50));
                    return Convert.ToDouble(sum) / l.Length;
                  };

      Console.WriteLine("mMAvg(myDelegate[] d) = {0}", mMAvg.Invoke(d));

      int[] x = new int[] { 5, 5, 7 };
      x.Average();



      Console.ReadKey();
    }
  }
}
