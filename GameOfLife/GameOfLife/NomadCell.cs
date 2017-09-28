using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class NomadCell : Cell
    {

        public NomadCell(bool b, Point p) : base(b, p) {
            this.aliveColor = Color.DarkOrange;
            this.deadColor = Color.Brown;
            this.type = "Nomad";
        }

        public override Cell state()
        {
            List<Cell> pots = habitable();
            if (pots.Count == 0) return newCell("Normal", true, coord);
            if (cancerFlag) return newCell("Cancer", true, coord);
            
            
                pots.ElementAt(r.Next(pots.Count)).nomadFlag = true;
                return newCell("Normal", false, coord);
            
        }

        public List<Cell> habitable()
        {
            List<Cell> pots = new List<Cell>();
            foreach(Cell c in group)
            {
                if (c != null)
                {
                    if (c.type.Equals("Normal") && !c.alive) pots.Add(c);
                }
            }
            return pots;
        }

    }
}
