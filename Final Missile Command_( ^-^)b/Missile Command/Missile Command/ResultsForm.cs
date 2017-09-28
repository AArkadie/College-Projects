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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            if (Form1.enemyCandidate.loseCondition())
            {
                pictureBox1.Image = Form1.enemyCandidate.candidateWinPicture();
                label1.Text = "President " + Form1.enemyCandidate.candidateName();
            }
            else {
                pictureBox1.Image = Form1.playerCandidate.candidateWinPicture();
                label1.Text = "President " + Form1.playerCandidate.candidateName();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
