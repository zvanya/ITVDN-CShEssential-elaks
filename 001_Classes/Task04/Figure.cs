using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
  class Figure
  {
    Point[] fig;

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
      fig = new Point[5];
      fig[0] = p1;
      fig[1] = p2;
      fig[2] = p3;
      fig[3] = p4;
      fig[4] = p5;
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
      fig = new Point[4];
      fig[0] = p1;
      fig[1] = p2;
      fig[2] = p3;
      fig[3] = p4;
    }
    public Figure(Point p1, Point p2, Point p3)
    {
      fig = new Point[4];
      fig[0] = p1;
      fig[1] = p2;
      fig[2] = p3;
    }

    double LengthSide(Point A, Point B)
    {
      return Math.Sqrt(Math.Pow((B.X - A.X),2) + Math.Pow((B.Y - B.Y), 2));
    }

    public void PerimeterCalculator()
    {

    }
  }
}
