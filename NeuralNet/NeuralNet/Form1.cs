using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNet
{
    
    public partial class Form1 : Form
    {
        //here are our variables
        public static int degree = 1;
        public string testing = "X^1";
        public double controlResults(double x)
        {
            double sum = 0;
            for (int i = 0; i < degree; i++)
            {
                sum += Math.Pow(x, i + 1);
            }
            return sum;
        }
        //and the rest
        public static double scaleFactor = Math.Pow(10, degree);
        public INet smallNets = new Multinet(degree, scaleFactor);
        public INet bigNet = new Polynet(degree, scaleFactor);
        public bool running;
        Random r = new Random();
        List<TextBoxTuple> controls, singles, multis;
        int count = 0;

        

        public Form1()
        {
            InitializeComponent();
            eqLabel.Text = "Training to: " + testing;
            controls = new List<TextBoxTuple>();
            singles = new List<TextBoxTuple>();
            multis = new List<TextBoxTuple>();
            //let's start the show
            controls.Add(new TextBoxTuple(-10, control0));
            controls.Add(new TextBoxTuple(-5, control1));
            controls.Add(new TextBoxTuple(-1, control2));
            controls.Add(new TextBoxTuple(-.5, control3));
            controls.Add(new TextBoxTuple(-.01, control4));
            controls.Add(new TextBoxTuple(-.001, control5));
            controls.Add(new TextBoxTuple(.001, control6));
            controls.Add(new TextBoxTuple(.01, control7));
            controls.Add(new TextBoxTuple(.5, control8));
            controls.Add(new TextBoxTuple(1, control9));
            controls.Add(new TextBoxTuple(5, control10));
            controls.Add(new TextBoxTuple(10, control11));
            //and the singles
            singles.Add(new TextBoxTuple(-10, single0));
            singles.Add(new TextBoxTuple(-5, single1));
            singles.Add(new TextBoxTuple(-1, single2));
            singles.Add(new TextBoxTuple(-.5, single3));
            singles.Add(new TextBoxTuple(-.01, single4));
            singles.Add(new TextBoxTuple(-.001, single5));
            singles.Add(new TextBoxTuple(.001, single6));
            singles.Add(new TextBoxTuple(.01, single7));
            singles.Add(new TextBoxTuple(.5, single8));
            singles.Add(new TextBoxTuple(1, single9));
            singles.Add(new TextBoxTuple(5, single10));
            singles.Add(new TextBoxTuple(10, single11));
            //all together now
            multis.Add(new TextBoxTuple(-10, multi0));
            multis.Add(new TextBoxTuple(-5, multi1));
            multis.Add(new TextBoxTuple(-1, multi2));
            multis.Add(new TextBoxTuple(-.5, multi3));
            multis.Add(new TextBoxTuple(-.01, multi4));
            multis.Add(new TextBoxTuple(-.001, multi5));
            multis.Add(new TextBoxTuple(.001, multi6));
            multis.Add(new TextBoxTuple(.01, multi7));
            multis.Add(new TextBoxTuple(.5, multi8));
            multis.Add(new TextBoxTuple(1, multi9));
            multis.Add(new TextBoxTuple(5, multi10));
            multis.Add(new TextBoxTuple(10, multi11));
            smallNets.initialize(100, 0.01F);
            bigNet.initialize(100, 0.01F);
            foreach(TextBoxTuple duple in controls)
            {
                duple.boxOut.Text = "" + controlResults(duple.valIn);
            }
            timer.Stop();
            running = false;
            stepCounter.Text = "Steps: " + count;
            }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                timer.Stop();
                goButton.Text = "Start";
            }
            if (!running)
            {
                timer.Start();
                goButton.Text = "Stop";
            }
            running = !running;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            smallNets.train(1000);
            bigNet.train(1000);
            smallNets.display(multis);
            bigNet.display(singles);
            count++;
            stepCounter.Text = "Steps: " + count;
            Refresh();
        }
    }
}
