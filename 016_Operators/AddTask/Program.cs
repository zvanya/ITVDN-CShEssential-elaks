using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
        }

        public override string ToString()
        {
            return string.Format($"new Point({X}, {Y}, {Z})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, 3);
            Point p2 = new Point(3, 2, 1);

            Console.WriteLine(p1 + p2);

            Console.ReadKey();
        }
    }
}
