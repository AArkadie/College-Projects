using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Launcher : Rectangle
    {

        Color col;
        float center;
        bool dead;

        public Launcher(Color c, float cp) : base(c, new Point2(cp - 10, 395), 20, 10)
        {
            col = c;
            center = cp;
        }
        public override bool hit(Point2 p)
        {
            if (p.dist(edge) < height)
            {
                dead = true;
                Form1.lunch = true;
                return true;
            }
            return false;
        }
        public override List<GObj> move()
        {
            if (dead) return new List<GObj>();
            return base.move();
        }
    }
}
