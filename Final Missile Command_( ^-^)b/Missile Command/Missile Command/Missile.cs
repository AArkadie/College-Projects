using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Missile : MovingCircle
    {

        public float time;
        public Point2 targ;
        Random r = new Random();

        public Missile(Point2 initial, Point2 target): base(Color.Yellow,initial,2,new Point2(1F,1F))
        {

            time = initial.dist(target)/Form1.playerCandidate.playerMissileSpeed();
            Point2 vectBase = target.subtract(initial);
            base.vel = new Point2(vectBase.x/time, vectBase.y/ time);
            targ = target;
            
        }

        public override List<GObj> move()
        {
            time--;
            if (time > 0) return base.move();
            else {
                StructurePrefab[] pef = Form1.playerCandidate.lifeTypes();
                StructurePrefab p = pef[r.Next(pef.Length)];
                p.addPrefab((int)targ.x, (int)targ.y);
                return new List<GObj>();
            } 
            
        }
     
    }
}
