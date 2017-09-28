using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class Polynet : INet //Net trained to the grand polynomial
    {

        public NeuralNet net;
        public Random r = new Random();
        public delegate void TrainDelegate(float[] input1, float[] target);
        TrainDelegate trainer;
        public PolyStrat p;
        public double[] equation;
        public double scale;

        public Polynet(int n, double d)
        {
            net = new NeuralNet(1, 1, 50, 0.01F);
            equation = new double[n];
            scale = d;
        }

        public void display(List<TextBoxTuple> t)
        {
            foreach(TextBoxTuple tu in t)
            {
                float[] xa = new float[1];
                float x = (float)tu.valIn;
                xa[0] = x;
                tu.boxOut.Text = "" + net.evaluate(xa)[0] * scale;

            }
        }

        public double getError(int n)
        {
            double rSquared = 0;
            for (int i = 0; i < n; i++)
            {
                rSquared += net.error[i];
            }
            return rSquared / net.error.Length;
        }

        public void initialize(int neurons, float noiseMagnitude)
        {
            net = new NeuralNet(1, 1, neurons, noiseMagnitude);
            trainer = net.train;
        }

        public void paint(int width, int height, Graphics g)
        {
            throw new NotImplementedException();
        }

        public void setRate(float rate)
        {
            net = new NeuralNet(1, 1, net.numNeurons, rate);
        }

        public void train(int count)
        {
            //gotta do that polynomial, SON!
            float[] x = new float[1];
            float[] y = new float[1];
            for (int i = 0; i < count; i++)
            {
                x[0] = (float)((r.NextDouble() * 20 )- 10);
                y[0] = 0;
                for(int j = 0; j < equation.Length; j++)
                {
                    y[0] += (float)(Math.Pow(x[0], j + 1) / scale);
                }
                trainer(x, y);

            }
        }
    }
}
