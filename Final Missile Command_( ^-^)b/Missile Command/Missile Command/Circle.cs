using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Circle : GObj
    {

        public Color c;
        public Point2 center;
        public float radius;

        public Circle(Color a, Point2 b, float r)
        {
            c = a;
            center = b;
            radius = r;
        }

        public override void display(Graphics g)
        {
            g.FillEllipse(new SolidBrush(c), center.x-radius, center.y-radius, radius*2, radius*2);
        }
    }
}
