using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
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
        }

        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        public void addPrefab(int x, int y)
        {
            offsetX = x - sizeX / 2;
            offsetY = y - sizeY / 2;

            for(int i = 0; i < structure.Length; i++)
            {
                Point p = structure[i];
                p = new Point(mod(p.X + offsetX, Form1.unisize), mod(p.Y + offsetY, Form1.unisize));
                Form1.grid[p.X, p.Y] = Cell.newCell(cellType, true, p);
            }


        }

        public void reverseState(bool b, int x, int y)
        {
            offsetX = x - sizeX / 2;
            offsetY = y - sizeY / 2;

            for (int i = 0; i < structure.Length; i++)
            {
                Point p = structure[i];
                p = new Point(mod(p.X + offsetX, Form1.unisize), mod(p.Y + offsetY, Form1.unisize));
                Cell c = Form1.grid[p.X, p.Y];
                if (c.alive != b) Form1.grid[p.X, p.Y] = Cell.newCell(cellType, b, p);
                else Form1.grid[p.X, p.Y] = Cell.newCell(cellType, !b, p);
            }


        }

    }
}
