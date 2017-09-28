using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class ZombieCell : Cell
    {

        public ZombieCell(bool b, Point p) : base(b, p) {
            this.aliveColor = Color.Black;
            this.deadColor = Color.DimGray;
            this.type = "Zombie";
        }

        public override Cell state()
        {
            foreach (Cell c in group)
            {
                if (c != null)
                {
                    if (c.alive)
                    {
                        if (c.type.Equals("Priest")) return newCell("Normal", true, coord);
                        if (c.type.Equals("Normal")) if (r.Next(100) % 5 == 0) c.zombieFlag = true;
                    }
                }
            }
            return newCell("Zombie", false, coord);
        }

    }
}
