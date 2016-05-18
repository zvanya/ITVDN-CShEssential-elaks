using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Figure
  {
    Point[] p;
    string name = null;

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
      p = new Point[5];
      p[0] = p1;
      p[1] = p2;
      p[2] = p3;
      p[3] = p4;
      p[4] = p5;

      name = "5-ти угольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
      p = new Point[4];
      p[0] = p1;
      p[1] = p2;
      p[2] = p3;
      p[3] = p4;

      name = "4-х угольник";
    }
    public Figure(Point p1, Point p2, Point p3)
    {
      p = new Point[3];
      p[0] = p1;
      p[1] = p2;
      p[2] = p3;

      name = "Треугольник";
    }

    public string Name
    {
      get { return name; }
    }

    double LengthSide(Point A, Point B)
    {
      return Math.Sqrt(Math.Pow((B.X - A.X),2) + Math.Pow((B.Y - A.Y), 2));
    }

    public double PerimeterCalculator()
    {
      double per = 0;

      for (int i = 0; i < p.Length - 1; i++)
      {
        per = per + LengthSide(p[i], p[i + 1]);
      }

      per = per + LengthSide(p[p.Length - 1], p[0]);

      return per;
    }
  }
}
