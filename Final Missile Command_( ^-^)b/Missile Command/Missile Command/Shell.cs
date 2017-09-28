using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Shell : MovingCircle
    {

        Color scolor;
        Point2 sinit, svel;
        float srad;
        Line tail;
        bool dest;
        int life;
        Random randy = new Random();

        public Shell(Color c, Point2 ip, float r, Point2 v, Color t) : base(c, ip, r, v)
        {
            scolor = c;
            sinit = ip;
            srad = r;
            svel = v;
            tail = new Line(t, ip, v, rad / 2);
            dest = false;
            life = Form1.enemyCandidate.enemyMissileLife();
        }

        public override List<GObj> move()
        {
            tail.p2 = init;
            if (init.y > 400 || dest) {
                dest = true;
                return new List<GObj>();
                    }
            else return base.move();
        }

        public override void display(Graphics g)
        {
            if (!dest) tail.display(g);
            base.display(g);
        }

        public override void envelop(Point2 p, float r, Cell c)
        {
            
            if (init.dist(p) < r)
            {
                if (!(randy.Next(1, 101) < Form1.enemyCandidate.enemyShellEvadeChance()))
                {
                    life--;
                    c.alive = false;
                }
                else
                {
                    c.alive = false;
                }
                if (life <= 0)
                {
                    dest = true;
                    c.alive = false;
                    Form1.score += ((double)Form1.playerCandidate.enemyMissileWorth() / Form1.enemyCandidate.enemyScoreDisrupt());
                }
            }
        }
        public override void interact(GObj o)
        {
            o.hit(init);
        }
    }
}
