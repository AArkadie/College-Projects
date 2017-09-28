using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Rectangle : GObj
    {

        public Color c;
        public Point2 edge;
        public float width, height;

        public Rectangle(Color a, Point2 e, float w, float h)
        {
            c = a;
            edge = e;
            width = w;
            height = h;
        }

        public override void display(Graphics g)
        {
            g.FillRectangle(new SolidBrush(c), edge.x - width/2, edge.y - height/2, width, height);
        }
    }
}
