using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    class Explosion : Circle
    {
        int maxBoom, boomSpeed;
        Random r = new Random();

        public Explosion(Point2 spawn) : base(Color.Orange, spawn, 4)
        {
            maxBoom = 65;
            boomSpeed = 3;
        }

        public override List<GObj> move()
        {
            if (radius < maxBoom)
            {
                c = Color.FromArgb(r.Next(256),r.Next(256),r.Next(256));
                radius += boomSpeed;
                return base.move();
            }
            else return new List<GObj>();
        }

        public override void envelop(Point2 p, float r, Cell c)
        {
        }
        public override void interact(GObj o)
        {
            o.envelop(center, radius, null);
        }

    }
}
