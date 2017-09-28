using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class OneOneNet : INet
    {
        public NeuralNet net;
        public Random r = new Random();
        public delegate void TrainDelegate(float[] input1, float[] target);
        TrainDelegate trainer;
        public int degree;
        public double scale;

        public OneOneNet(int n, double d)
        {
            net = new NeuralNet(1, 1, 50, 0.01F);
            degree = n;
            scale = d;
        }

        public double getError(int n)//avg error over n points (r^2 value)
        {
            double rSquared = 0;
            for(int i = 0; i < n; i++)
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
            Brush netBrush = new SolidBrush(Color.Green);
            Brush sinBrush = new SolidBrush(Color.Blue);
            float[] xa = new float[1];
            for (int i = 0; i < width; i += 5)
            {
                float x = (float)i / ((float)(width)) * 2 * (float)Math.PI;
                xa[0] = x;
                float y1 = (float)Math.Sin(x);
                float y2 = net.evaluate(xa)[0];
                float y1p = ((y1 + 1.5F) / 3F) * height;
                float y2p = ((y2 + 1.5F) / 3F) * height;
                g.FillEllipse(sinBrush, i, y1p, 5, 5);
                g.FillEllipse(netBrush, i, y2p, 5, 5);

            }
        }

        public void setRate(float rate)
        {
            net = new NeuralNet(1, 1, net.numNeurons, rate);
        }

        public void train(int count)
        {
            float[] x = new float[1];
            float[] y = new float[1];
            for (int i = 0; i < count; i++)
            {
                x[0] = (float)((r.NextDouble() * 20) - 10);
                y[0] = (float)(Math.Pow(x[0], degree)/scale);
                trainer(x, y);

            }
        }

        public float gibeCancer(TextBoxTuple t)
        {
                float[] xa = new float[1];
                float x = (float)t.valIn;
                xa[0] = x;
                return net.evaluate(xa)[0];
        }

        public void display(List<TextBoxTuple> t)
        {
            Console.Write("I don't do that, you clod!");
        }
    }
}
