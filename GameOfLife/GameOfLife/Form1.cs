using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public static float PBOX_LENGTH = 500;
        public static float PBOX_HEIGHT = 500;
        public static float panX = 0, panY = 0, z = 1;
        public static int unisize = 50;
        public static Cell[,] grid = new Cell[unisize, unisize];
        public static Cell[,] tiny = new Cell[1,1];
        public static Cell[,] temp = new Cell[unisize, unisize];
        public static float cellWidth = PBOX_LENGTH / unisize;
        public static float cellHeight = PBOX_HEIGHT / unisize;
        public List<Point> temps = new List<Point>();
        public static bool wrap, running;
        public int livingCounter, genCount = 0;
        public bool touchdown = false, moved = false;
        public int px = -1, py = -1;
        public Point v0, v1;
        public Cell currentCellType = new Cell(true, new Point(7700, 600));
        public Random r = new Random();


        public static void resetGrid()
        {
            grid = new Cell[unisize, unisize];
            temp = new Cell[unisize, unisize];
            cellWidth = PBOX_LENGTH / unisize;
            cellHeight = PBOX_HEIGHT / unisize;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = new Cell(false, new Point(i, j));
                }
            }
            foreach (Cell c in grid)
            {
                if (wrap) c.groupit();
                else c.groupnot();
            }
        }

        public static int popPoll()
        {
            int c = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].alive) c++;
                }
            }
            return c;
        }

        public static void popLists(ComboBox x)
        {
            string[] names = new string[Prefabs.prefabList.Length];
            for(int i = 0; i < Prefabs.prefabList.Length; i++)
            {
                names[i] = Prefabs.prefabList[i].name;
            }
            x.Items.AddRange(names);
        }

        public Form1()
        {
            InitializeComponent();
            popLists(prefabSelector);
            tiny[0, 0] = new Cell(true, new Point(0, 0));
            prefabSelector.SelectedIndex = 0;
            cellTypeBox.SelectedIndex = 0;
            PBOX_HEIGHT = cellBox.Height;
            PBOX_LENGTH = cellBox.Width;
            wrap = wrapCheck.Checked;
            resetGrid();
            livingCounter = popPoll();
            running = false;
        }

        public void reformat()
        {
            PBOX_HEIGHT = cellBox.Height;
            PBOX_LENGTH = cellBox.Width;
            cellWidth = PBOX_LENGTH / unisize;
            cellHeight = PBOX_HEIGHT / unisize;
            livingCounter = popPoll();
        }


        public void applyTemplate()
        {
            for (int i = 0; i < temps.Count; i++)
            {
                Point p = temps[i];
                grid[p.X, p.Y] = Cell.newCell(currentCellType.type,true, p);
            }
        }

        private void cellBox_Paint(object sender, PaintEventArgs e)
        {
            foreach(Cell c in grid)
            {
                /*if (c != null) */ c.display(e.Graphics);
            }
            statusLabel.Text = "Population: " + livingCounter + "\nGeneration: " + genCount + "\nSize: " + unisize;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            foreach (Cell c in grid)
            {
                temp[c.coord.X, c.coord.Y] = c.state();
                //*if (c != null)*/ c.state();
            }
            foreach (Cell c in temp)
            {
                if (wrap) c.groupit();
                else c.groupnot();
            }
            
            grid = temp;
            genCount++;
            livingCounter = popPoll();
            exampleCell.BackColor = (genCount % 2 == 0) ? currentCellType.aliveColor : currentCellType.deadColor;
            Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                clock.Start();
                running = !running;
                saveButton.Enabled = false;
                loadButton.Enabled = false;
                stepButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                clock.Stop();
                running = !running;
                saveButton.Enabled = true;
                loadButton.Enabled = true;
                stepButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetGrid();
            applyTemplate();
            livingCounter = popPoll();
            genCount = 0;
            Refresh();
        }

        private void cellBox_MouseClick(object sender, MouseEventArgs e)
        {
            int cellx = (int)((e.X - panX) / (cellWidth * z));
            int celly = (int)((e.Y - panY) / (cellHeight * z));

            Cell c = grid[cellx,celly];
            StructurePrefab p = Prefabs.prefabList[prefabSelector.SelectedIndex];
            p.cellType = currentCellType.type;

            if (cellx == px && celly == py) p.reverseState(c.alive, c.coord.X, c.coord.Y);
            else p.addPrefab(c.coord.X, c.coord.Y);

            //c.alive = !c.alive;
            px = cellx;
            py = celly;
            livingCounter = popPoll();
            foreach(Cell t in grid)
            {
                if (wrap) t.groupit();
                else t.groupnot();
            }
            Refresh();
        }

        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(sizeBox.Text, out unisize);
            resetGrid();
            Refresh();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void sizeBox_Leave(object sender, EventArgs e)
        {
            int.TryParse(sizeBox.Text, out unisize);
            resetGrid();
            Refresh();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter w = new StreamWriter(saveFileDialog1.FileName);
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                string s = "";
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j].alive) s += "*";
                    else s += " ";
                }
                w.WriteLine(s);
            }
            w.Close();
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            float znew = (float)(1000 - vScrollBar1.Value) / 100;
             float xc = panX + (z * PBOX_LENGTH/2);
             float yc = panY + (z * PBOX_HEIGHT/2);
             float ic = (xc - panX) / z;
             float jc = (yc - panY) / z;

            panX = xc - (znew * ic);
            panY = yc - (znew * jc);
            z = znew;
            Refresh();
            Console.WriteLine(panX + ", " + panY + ", " + z);
        }

        private void prefabBox_Paint(object sender, PaintEventArgs e)
        {
            StructurePrefab p = Prefabs.prefabList[prefabSelector.SelectedIndex];
            int siz = Math.Max(p.sizeX, p.sizeY);
            foreach (Cell c in tiny)
            {
                c.display(100/siz,100/siz,e.Graphics);
            }
        }

        private void prefabSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int sel = prefabSelector.SelectedIndex;
            string w = currentCellType.type;
            StructurePrefab p = Prefabs.prefabList[sel];
            tiny = new Cell[p.sizeX, p.sizeY];
            for(int i = 0; i < tiny.GetLength(0); i++)
            {
                for(int j = 0; j < tiny.GetLength(1); j++)
                {
                    tiny[i, j] = Cell.newCell(w, false, new Point(i, j));
                }
            }
            for(int i = 0; i < p.structure.Length; i++)
            {
                Point v = p.structure[i];
                tiny[v.X, v.Y].alive = true;
            }
            Refresh();
        }

        public void confirmChange(NumericUpDown n)
        {
            int testval = (int)(normalProb.Value + priestProb.Value + nomadProb.Value +
                                zombieProb.Value + cancerProb.Value);
            n.Value -= (testval > 100) ? 1 : 0;
            if (normalProb.Value != 0) normalProb.Value = 100 - (testval - normalProb.Value);
            else normalProb.Value += (testval < 100) ? 1 : 0 ;
        }

        private void priestProb_ValueChanged(object sender, EventArgs e)
        {
            confirmChange(priestProb);
        }

        private void nomadProb_ValueChanged(object sender, EventArgs e)
        {
            confirmChange(nomadProb);
        }

        private void zombieProb_ValueChanged(object sender, EventArgs e)
        {
            confirmChange(zombieProb);
        }

        private void cancerProb_ValueChanged(object sender, EventArgs e)
        {
            confirmChange(cancerProb);
        }

        public void seedGrid()
        {
            grid = new Cell[unisize, unisize];
            temp = new Cell[unisize, unisize];
            cellWidth = PBOX_LENGTH / unisize;
            cellHeight = PBOX_HEIGHT / unisize;
            string[] probs = new string[100];
            int dex = 0;

            for(int i = dex; dex < i + normalProb.Value; dex++)
            {
                probs[dex] = "Normal";
            }
            for (int i = dex; dex < i + priestProb.Value; dex++)
            {
                probs[dex] = "Priest";
            }
            for (int i = dex; dex < i + nomadProb.Value; dex++)
            {
                probs[dex] = "Nomad";
            }
            for (int i = dex; dex < i + zombieProb.Value; dex++)
            {
                probs[dex] = "Zombie";
            }
            for (int i = dex; dex < i + cancerProb.Value; dex++)
            {
                probs[dex] = "Cancer";
            }

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    string s = probs[r.Next(100)];
                    grid[i, j] = Cell.newCell(s,false, new Point(i, j));
                }
            }
            foreach (Cell c in grid)
            {
                if (wrap) c.groupit();
                else c.groupnot();
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            seedGrid();
            livingCounter = popPoll();
            genCount = 0;
            Refresh();
        }

        private void cellTypeBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string s = cellTypeBox.GetItemText(cellTypeBox.SelectedItem);
            currentCellType = Cell.newCell(s, true,new Point(0, 0));
            exampleCell.BackColor = (genCount % 2 == 0) ? currentCellType.aliveColor : currentCellType.deadColor;
            prefabSelector_SelectionChangeCommitted(sender, e);
        }

        private void cellBox_MouseDown(object sender, MouseEventArgs e)
        {
            touchdown = true;
            moved = false;
            v0 = new Point(e.X, e.Y);
        }

        private void cellBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (touchdown)
            {
                v1 = new Point(e.X - v0.X, e.Y - v0.Y);
                moved = true;
            }
        }

        private void cellBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (moved)
            {
                panX += v1.X;
                panY += v1.Y;
                Refresh();
            }
            else cellBox_MouseClick(sender, e);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            temps = new List<Point>();
            StreamReader r = new StreamReader(openFileDialog1.FileName);
            int j = 0;
            String s = r.ReadLine();
            unisize = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ElementAt(i) == '*') temps.Add(new Point(j, i));
            }

            while (!r.EndOfStream)
            {
                s = r.ReadLine();
                j++;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s.ElementAt(i) == '*') temps.Add(new Point(j, i));
                }
            }
            resetButton_Click(sender, e);
            r.Close();
        }

        private void wrapCheck_CheckedChanged(object sender, EventArgs e)
        {
            wrap = wrapCheck.Checked;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            clock.Interval = 1000 - trackBar1.Value;
        }
    }
}
