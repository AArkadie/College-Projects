using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        public static string[] types = { "Normal", "Zombie", "Cancer", "Nomad", "Priest" };

        public bool alive { get; set; }
        public bool nomadFlag = false, cancerFlag = false, zombieFlag = false, priestFlag = false;
        public Cell[,] group = new Cell[3,3];
        public Point coord;
        public Color deadColor, aliveColor;
        public String type;
        public Random r = new Random();

        public Cell(bool b, Point p)
        {
            alive = b;
            coord = p;
            deadColor = Color.Red;
            aliveColor = Color.Green;
            type = "Normal";
        }

        public static Cell newCell(string s, bool b, Point p)
        {
            switch (s)
            {
                case "Zombie":
                    return new ZombieCell(b, p);
                case "Cancer":
                    return new CancerCell(b, p);
                case "Nomad" :
                    return new NomadCell(b, p);
                case "Priest" :
                    return new PriestCell(b, p);
                default:
                    return new Cell(b, p);
            }
        }

        public void groupit()
        {
            int icount = 0;
            for (int i = mod(coord.X - 1,Form1.unisize); icount < 3; i = mod(i+1, Form1.unisize))
            {
                int jcount = 0;
                for (int j = coord.Y - 1; jcount < 3; j = mod(j+1, Form1.unisize))
                {
                    group[icount, jcount] = Form1.grid[mod(i, Form1.unisize), mod(j, Form1.unisize)];
                    jcount++;
                }
                icount++;
            }
        }

        public void groupnot()
        {
            int icount = 0;
            for (int i = coord.X - 1; icount < 3; i++)
            {
                int jcount = 0;
                for (int j = coord.Y - 1; jcount < 3; j++)
                {
                    if (i < 0 || j < 0 || i >= Form1.unisize || j >= Form1.unisize) group[icount, jcount] = null;
                    else group[icount, jcount] = Form1.grid[i, j];
                    jcount++;
                }
                icount++;
            }
        }

/*        public bool isAlive()
        {
            return alive;
        }*/

        public virtual Cell state()
        {
            if (priestFlag) return newCell("Priest", true, coord);
            if (nomadFlag/* || (alive && r.Next(100) % 50 == 0)*/) return newCell("Nomad", true, coord);
            if (zombieFlag/* || (!alive && r.Next(1000) == 666)*/) return newCell("Zombie", false, coord);
            if (cancerFlag) return newCell("Cancer", true, coord);
            int pow = lives();
            bool pup = alive;
            if (alive && ((pow-1) < 2 || (pow-1) > 3)) pup = false;
            else if (!alive && pow == 3) pup = true;
            return newCell(type,pup, coord);
        }

        public int lives()
        {
            int count = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (group[i, j] != null)
                    {
                        if (!group[i, j].type.Equals("Zombie"))
                        {
                            if (group[i, j].alive) count++;
                        }
                    }
                }
            }
            return count;
        }

        public void display(Graphics g)
        {
            if (alive) g.FillRectangle(new SolidBrush(aliveColor),
                Form1.panX + coord.X * (Form1.cellWidth*Form1.z),
                Form1.panY + coord.Y * (Form1.cellHeight*Form1.z),
                Form1.cellWidth * Form1.z,
                Form1.cellHeight * Form1.z);

            if (!alive) g.FillRectangle(new SolidBrush(deadColor),
                Form1.panX + coord.X * (Form1.cellWidth*Form1.z),
                Form1.panY + coord.Y * (Form1.cellHeight*Form1.z),
                Form1.cellWidth * Form1.z,
                Form1.cellHeight * Form1.z);

            /*
            f(s/2, s/2) = (Xc, Yc)
            f(s/2 + 1, s/2 + 1) = (Xc +1/z, Yc + 1/z)
            f(x,y) = (ax + x0, ay + a0)
            */

        }
        public void display(int w, int h, Graphics g)
        {
            if (alive) g.FillRectangle(new SolidBrush(aliveColor),
                coord.X * (w),
                coord.Y * (h),
                w,
                h);

            if (!alive) g.FillRectangle(new SolidBrush(deadColor),
                coord.X * (w),
                coord.Y * (h),
                w,
                h);
        }

    }
}
