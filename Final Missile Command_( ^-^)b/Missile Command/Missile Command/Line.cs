using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Line : GObj
    {

        public Color c;
        public Point2 p1, p2;
        public float width;

        public Line(Color a, Point2 x, Point2 y, float w)
        {
            c = a;
            p1 = x;
            p2 = y;
            width = w;
        }

        public override void display(Graphics g)
        {
            g.DrawLine(new Pen(c, width), p1.x, p1.y, p2.x, p2.y);
        }
    }
}
