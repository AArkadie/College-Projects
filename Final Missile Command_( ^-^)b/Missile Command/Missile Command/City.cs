using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class City : Rectangle
    {

        public Color col;
        public float center;
        public bool dead;
        Random r = new Random();

        public City(Color c, float cp) : base(c, new Point2(cp, 400), 40, 20)
        {
            col = c;
            center = cp;
            dead = false;
        }

        public override bool hit(Point2 p)
        {
            if (p.dist(edge) < height)
            {
                bool bounce, miss;
                miss = r.Next(1, 101) < Form1.playerCandidate.cityEvadeChance();
                bounce = r.Next(1, 101) < Form1.playerCandidate.cityBounceChance();
                if (!miss && !bounce)
                {
                    dead = true;
                    Form1.numCities--;
                    return true;
                }
                else;//add some new missiles shot at random parts of the screen
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