using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class CancerCell : Cell
    {

        public CancerCell(bool b, Point p) : base(b, p) {
            this.aliveColor = Color.HotPink;
            this.deadColor = Color.LightPink;
            this.type = "Cancer";
        }

        public override Cell state()
        {
            if (priestFlag) return newCell("Priest", true, coord);
            int pow = lives();
            bool pup = alive;
            if (alive && ((pow - 1) < 1 || (pow - 1) > 5)) pup = false;
            else if (!alive && (pow < 5 && pow > 1)) pup = true;
            if(alive && r.Next(100)%33 == 0)
            {
                List<Cell> halp = living();
                foreach(Cell c in halp)
                {
                    if (c != null)c.cancerFlag = true;
                }
            }
                
            return newCell(type, pup, coord);
        }

        public List<Cell> living()
        {
            List<Cell> bap = new List<Cell>();
            foreach (Cell c in group)
            {
                if (c != null) {
                    if (c.alive) bap.Add(c);
                }
            }
            return bap;
        }
    }
}
