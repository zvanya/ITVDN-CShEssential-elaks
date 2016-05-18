using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Point
  {
    double x = 0;
    double y = 0;
    string pointName = null;

    public Point(string name, double x, double y)
    {
      this.x = x;
      this.y = y;
      pointName = name;
    }

    public double X
    {
      get { return x; }
    }
    public double Y
    {
      get { return y; }
    }
    public string PointName
    {
      get { return pointName; }
    }
  }
}
