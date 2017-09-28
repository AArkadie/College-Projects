using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public abstract class GObj
    {
        public virtual List<GObj> move()
        {
            List<GObj> r = new List<GObj>();
            r.Add(this);
            return r;
        }
        public abstract void display(Graphics g);
        public virtual void interact(GObj o)
        {
        }
        public virtual bool hit(Point2 p)
        {
            return false;
        }
        public virtual void envelop(Point2 p, float r, Cell c)
        {
        }
    }
}
