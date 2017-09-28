using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class PriestCell : Cell
    {

        public PriestCell(bool b, Point p) : base(b, p) {
            this.aliveColor = Color.Gold;
            this.deadColor = Color.WhiteSmoke;
            this.type = "Priest";
            this.priestFlag = true;
        }

        public override Cell state()
        {
            foreach(Cell c in group)
            {
                if (c != null)
                {
                    if (!c.Equals(this))
                    {
                        if (c.type.Equals("Cancer"))
                        {
                            if (alive)
                            {
                                c.priestFlag = true;
                                return newCell("Normal", true, coord);
                            }
                        }
                        if (c.type.Equals("Normal"))
                        {
                            if (c.alive)
                            {
                                if (alive && r.Next(100) % 10 == 0) c.priestFlag = true;
                                if (!alive && r.Next(100) % 33 == 0) c.priestFlag = true;
                            }
                            //else if (r.Next(1000) == 7) c.priestFlag = true;
                        }
                        if (c.type.Equals("Priest"))
                        {
                            if (alive)
                            {
                                if (!c.alive && r.Next(100) % 2 == 0) c.priestFlag = false;
                            }
                        }
                    }//end excluding self
                }//end null check
            }
            int pow = lives();
            bool pup = alive;
            if (alive && ((pow - 1) < 2 || (pow - 1) > 3)) pup = false;
            else if (!alive && pow == 3) pup = true;

            if (!priestFlag) return newCell("Normal", false, coord);
            return newCell(type, pup, coord);
        }

    }
}
