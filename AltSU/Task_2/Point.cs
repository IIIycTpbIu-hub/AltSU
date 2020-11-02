using System;
using System.Collections.Generic;
using System.Text;

namespace AltSU.Task_2
{
    public class Point
    {
        public double X { get; } = 0;
        public double Y { get; } = 0;
        public double Z { get; } = 0;

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point()
        {

        }

        public double DistanceTo(Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - X), 2) + Math.Pow((b.Y - Y), 2) + Math.Pow((b.Z - Z), 2));
        }

        public override string ToString()
        {
            return "{x: " + X + ", y: " + Y + ", z:" + Z + "}";
        }
    }
}
