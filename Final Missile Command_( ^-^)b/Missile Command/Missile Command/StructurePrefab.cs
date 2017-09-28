using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class StructurePrefab
    {
        public Point[] structure;
        public string cellType, name;
        public int sizeX, sizeY, offsetX, offsetY;

        public StructurePrefab(int sx, int sy)
        {
            sizeX = sx;
            sizeY = sy;
            cellType = "Normal";
        }

        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        public void addPrefab(int x, int y)
        {
            offsetX = (x/(400/ Form1.playerCandidate.lifeSize())) -  (sizeX / 2);
            offsetY = (y/(400/ Form1.playerCandidate.lifeSize())) -  (sizeY / 2);

            for (int i = 0; i < structure.Length; i++)
            {
                Point p = structure[i];
                p = new Point(mod(p.X + offsetX, Form1.playerCandidate.lifeSize() * 2), mod(p.Y + offsetY, Form1.playerCandidate.lifeSize()));
                Form1.grid[p.X, p.Y].alive = true;
            }


        }

        public void reverseState(bool b, int x, int y)
        {
            offsetX = x - sizeX / 2;
            offsetY = y - sizeY / 2;

            for (int i = 0; i < structure.Length; i++)
            {
                Point p = structure[i];
                p = new Point(mod(p.X + offsetX, Form1.playerCandidate.lifeSize()), mod(p.Y + offsetY, Form1.playerCandidate.lifeSize()));
                Cell c = Form1.grid[p.X, p.Y];
                if (c.alive != b) Form1.grid[p.X, p.Y] = Cell.newCell(cellType, b, p);
                else Form1.grid[p.X, p.Y] = Cell.newCell(cellType, !b, p);
            }


        }

    }
}


