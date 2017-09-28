using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class MovingCircle : Circle
    {

       public Color color;
       public Point2 init, vel;
       public float rad;

        public MovingCircle(Color c, Point2 ip, float r, Point2 v) : base(c, ip, r)
        {
            color = c;
            init = ip;
            rad = r;
            vel = v;
        }

        public override List<GObj> move()
        {
            init = init.add(vel);
            base.center = init;
            return base.move();
        }
    }
}
