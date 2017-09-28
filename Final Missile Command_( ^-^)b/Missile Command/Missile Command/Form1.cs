using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Missile_Command
{
    public partial class Form1 : Form
    {

        public static int numCities = 6, curGen = 0;
        public static double score = 0;
        public static bool lunch = false;
        public static List<GObj> world = new List<GObj>();
        public static CandidateTemplate playerCandidate, enemyCandidate;
        public static Cell[,] grid;
        public Point2 target = null;
        public const int bottom = 400;  // Dimensions of the screen
        public const int rightEdge = 800;
        public const int launcherWidth = 20;  // The launcher
        public const int launcherHeight = 10;
        public const int launcherX = 400;
        public const int launcherY = bottom - launcherHeight;
        public static City[] cities = { new City(Color.Red, 100), new City(Color.Orange, 200), new City(Color.Yellow, 300)
        ,new City(Color.Blue, 500),new City(Color.Indigo, 600), new City(Color.Violet, 700)  };

        public void reset()
        {
            world = new List<GObj>();
            score = 0;
            numCities = 6;
            curGen = 0;
            grid = new Cell[playerCandidate.lifeSize() * 2, playerCandidate.lifeSize()];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Cell(false, new Point(i, j));
                }
            }
            foreach (Cell c in grid)
            {
                c.groupnot();
                world.Add(c);
            }
            lunch = false;
            world.Add(new City(Color.Red, 100));
            world.Add(new City(Color.Orange, 200));
            world.Add(new City(Color.Yellow, 300));
            world.Add(new City(Color.Blue, 500));
            world.Add(new City(Color.Indigo, 600));
            world.Add(new City(Color.Violet, 700));
            world.Add(new Launcher(Color.Green, 400));
            world.Add(new Enemy(10));// new Shell(Color.Black, new Point2(150, 0), 5, new Point2((float)1.5, 4), Color.White));
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Cell[,] temp = new Cell[playerCandidate.lifeSize() * 2, playerCandidate.lifeSize()];
            if (target != null)
            {
                world.Add(new Missile(new Point2(launcherX, launcherY), target));
                target = null;
            }
            foreach (Cell c in grid)
            {
                temp[c.coord.X, c.coord.Y] = grid[c.coord.X, c.coord.Y];
            }
            foreach (Cell c in temp)
            {
                c.state(curGen);
            }
            curGen++;
            foreach (Cell c in temp)
            {
                c.groupnot();
            }

            grid = temp;
            foreach (GObj f in world)
            {
                foreach(GObj s in world)
                {
                    f.interact(s);
                }
            }
            List<GObj> newer = new List<GObj>();
            foreach (GObj g in world)
            {
                newer.AddRange(g.move());
            }
            world = newer;
            Refresh();
            if (enemyCandidate.loseCondition() || enemyCandidate.winCondition())
            {
                ResultsForm rf = new ResultsForm();
                timer1.Stop();
                this.Hide();
                rf.ShowDialog();
                this.Show();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            statusLabel.Text = "Score: " + (int)score + " Cities: " + numCities;
            foreach(GObj o in world)
            {
                o.display(e.Graphics);
            }
        }

        private void toCandidateChooser_Click(object sender, EventArgs e)
        {
            CandidateChooser candy = new CandidateChooser();
            candy.ShowDialog();
            playerLabel.Text = playerCandidate.candidateName();
            enemyLabel.Text = enemyCandidate.candidateName();
            startButton.Enabled = true;
        }

        private void vsLabel_Click(object sender, EventArgs e)
        {

        }

        private void enemyLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            target = new Point2(e.X, e.Y);
        }

        public Form1()
        {
            InitializeComponent();
            playerCandidate = new DefaultSettings();
            enemyCandidate = new DefaultSettings();
            grid = new Cell[playerCandidate.lifeSize() * 2, playerCandidate.lifeSize()];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Cell(false, new Point(i, j));
                }
            }
            foreach (Cell c in grid)
            {
                c.groupnot();
            }
        }
    }
}
