using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Enemy : GObj
    {
        Random r;
        int delay;
        float speed, xCoord;
        public Enemy(float speed)
        {
            this.speed = speed;
            this.r = new Random();
            delay = r.Next(Form1.enemyCandidate.enemyMissileDelay() + 1);
            this.xCoord = Form1.rightEdge/2;
        }

        public override List<GObj> move()
        {
            xCoord += speed;

            if (xCoord > Form1.rightEdge || xCoord < 0) speed = -speed;

            if (delay <= 0)
            {
                List<GObj> bups = new List<GObj>();
                delay = r.Next(1, Form1.enemyCandidate.enemyMissileDelay() + 1);
                Point2 target = new Point2(((r.Next(1, 8) * 100) - xCoord) / (100 - Form1.enemyCandidate.enemyMissileSpeed()), (Form1.bottom + 20) / (100 - Form1.enemyCandidate.enemyMissileSpeed()));
                bups.Add(new Shell(Color.Black, new Point2(xCoord, -20), Form1.enemyCandidate.enemyMissileSize(), target, Color.White));
                bups.Add(this);

                return bups;
            }
            else
            {
                delay--;
                return base.move();
            }
        }

        public override void display(Graphics g)
        {
            //potatoes are pretty alright.
        }
    }
}
