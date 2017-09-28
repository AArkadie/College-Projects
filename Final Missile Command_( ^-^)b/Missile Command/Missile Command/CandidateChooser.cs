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
    public partial class CandidateChooser : Form
    {
        Random r = new Random();
        public CandidateChooser()
        {
            InitializeComponent();
        }

        public static CandidateTemplate newCand(String s)
        {
            switch (s)
            {
                case "Elephant":
                    return new ElephantSettings();
                case "Donkey":
                    return new DonkeySettings();
                case "Cat":
                    return new CatSettings();
                case "Dog":
                    return new DogSettings();
                case "Octopus":
                    return new OctopusSettings();
                case "Tapeworm":
                    return new TapewormSettings();
                case "Cactus":
                    return new CactusSettings();
                case "Sunfish":
                    return new SunfishSettings();
                case "Spider":
                    return new SpiderSettings();
                case "Frog":
                    return new FrogSettings();
                case "Falcon":
                    return new FalconSettings();
                case "Mushroom":
                    return new MushroomSettings();
                case "Bacteria":
                    return new BacteriaSettings();
                default:
                    return new DefaultSettings();
            }
        }

        private void candidateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.playerCandidate = newCand(candidateBox.SelectedItem.ToString());
            int candidateIndex = r.Next(candidateBox.Items.Count);
            while(candidateIndex == candidateBox.SelectedIndex) candidateIndex = r.Next(candidateBox.Items.Count);
            Form1.enemyCandidate = newCand(candidateBox.GetItemText(candidateBox.Items[candidateIndex]));
            descriptionBox.Text = Form1.playerCandidate.description();
            candidatePicture.Image = Form1.playerCandidate.candidatePicture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
