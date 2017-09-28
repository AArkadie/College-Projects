using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Point2
    {
        public float x, y;

        public Point2(float a, float b)
        {
            x = a;
            y = b;
        }

        public Point2(Point a)
        {
            x = a.X;
            y = a.Y;
        }

        public Point2 add(Point2 p)
        {
            return new Point2(x + p.x, y + p.y);
        }

        public Point2 subtract(Point2 p)
        {
            return new Point2(x - p.x, y - p.x);
        }

        public float dist(Point2 p)
        {
            return (float)Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
        }

        public override String ToString()
        {
            return "(" + x + ", " + y + ")";
        }

    }
}
