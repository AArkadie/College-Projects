using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile_Command
{
    public class Cell : GObj
    {
        public static int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        public int gen = 0;
        public bool alive { get; set; }
        public bool prev;
        public Cell[,] group = new Cell[3, 3];
        public Point coord;
        public Color deadColor, aliveColor;
        Random r = new Random();

        public Cell(bool b, Point p)
        {
            alive = b;
            coord = p;
            deadColor = Color.Empty;// Color.Red;
            aliveColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        public static Cell newCell(string s, bool b, Point p)
        {
            switch (s)
            {
                case "Enemy":
                    return new EnemyCell(b, p);
                default:
                    return new Cell(b, p);
            }
        }

       /* public void groupit()
        {
            int icount = 0;
            for (int i = mod(coord.X - 1, Form1.playerCandidate.lifeSize()); icount < 3; i = mod(i + 1, Form1.playerCandidate.lifeSize()))
            {
                int jcount = 0;
                for (int j = coord.Y - 1; jcount < 3; j = mod(j + 1, Form1.playerCandidate.lifeSize()))
                {
                    group[icount, jcount] = Form1.grid[mod(i, Form1.playerCandidate.lifeSize()), mod(j, Form1.playerCandidate.lifeSize())];
                    jcount++;
                }
                icount++;
            }
        }*/

        public void groupnot()
        {
            int icount = 0;
            for (int i = coord.X - 1; icount < 3; i++)
            {
                int jcount = 0;
                for (int j = coord.Y - 1; jcount < 3; j++)
                {
                    if (i < 0 || j < 0 || i >= Form1.playerCandidate.lifeSize() * 2 || j >= Form1.playerCandidate.lifeSize()) group[icount, jcount] = null;
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

        public void state(int curGen)
        {
            int red = aliveColor.R;
            int green = aliveColor.G;
            int blue = aliveColor.B;
            red = Math.Abs((red + (r.Next(21) - 10)) % 256);
            green = Math.Abs((green + (r.Next(21) - 10)) % 256);
            blue = Math.Abs((blue + (r.Next(21) - 10)) % 256);

            int pow = lives(curGen);
            bool pup = alive;
            if (alive && ((pow - 1) < 2 || (pow - 1) > 3)) pup = false;
            else if (!alive && pow == 3)
            {
                pup = true;
                aliveColor = Color.FromArgb(red, green, blue);
            }
            prev = alive;
            alive = pup;
            gen = curGen + 1;
        }

        public int lives(int curGen)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (group[i, j] != null && group[i, j].liveGen(curGen)) count++;
                }
            }
            return count;
        }

        public bool liveGen(int curGen)
        {
            if (gen == curGen) return alive;
            else return prev;
        }

        public override void display(Graphics g)
        {
            if (alive) g.FillRectangle(new SolidBrush(aliveColor),
                coord.X * (400/ Form1.playerCandidate.lifeSize()),
                coord.Y * (400 / Form1.playerCandidate.lifeSize()),
                400 / Form1.playerCandidate.lifeSize(),
                400 / Form1.playerCandidate.lifeSize());

            if (!alive) g.FillRectangle(new SolidBrush(deadColor),
                coord.X * (400 / Form1.playerCandidate.lifeSize()),
                coord.Y * (400 / Form1.playerCandidate.lifeSize()),
                400 / Form1.playerCandidate.lifeSize(),
                400 / Form1.playerCandidate.lifeSize());

        }
        public override void interact(GObj o)
        {
            if (alive)o.envelop(
                new Point2(
                    coord.X* 400 / Form1.playerCandidate.lifeSize(),
                    coord.Y * 400 / Form1.playerCandidate.lifeSize()),
                400 / Form1.playerCandidate.lifeSize(),
                this);
        }

    }
}
