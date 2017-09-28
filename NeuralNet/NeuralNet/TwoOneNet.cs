using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class TwoOneNet : INet
    {
        public NeuralNet net;
        public Random r = new Random();
        public delegate void TrainDelegate(float[] input1, float[] target);
        TrainDelegate trainer;

        public TwoOneNet()
        {
            net = new NeuralNet(2, 1, 100, 0.01F);
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
            net = new NeuralNet(2, 1, neurons, noiseMagnitude);
            trainer = net.train;
        }

        public void paint(int width, int height, Graphics g)
        {
            float[] xa = new float[2];
            for (int i = -width/2; i < width/2; i += 5)
            {
                for (int j = -height/2; j < height/2; j += 5)
                { 

                    float x = ((float)i / ((float)width));
                    float y = ((float)j / ((float)height));
                    xa[0] = x;
                    xa[1] = y;
                    float b = (float)(Math.Sqrt((xa[0] * xa[0]) + (xa[1] * xa[1])));
                    b = Math.Max(0, (1 - (b / .8F)));
                    b = Math.Min(1, b);
                    b = Math.Max(0, b);
                    float z = (float)net.evaluate(xa)[0];
                    z = Math.Max(0, (1 - (z / .8F)));
                    z = Math.Min(1, z);
                    z = Math.Max(0, z);
                    
                    int rg = (int)(z * 255);
                    int bl = (int)(b * 255);
                    Brush blubber = new SolidBrush(Color.FromArgb(bl, rg, rg));
                    g.FillRectangle(blubber, i + width/2, j + height/2, 5, 5);
                }
            }
        }

        public void setRate(float rate)
        {
            net = new NeuralNet(2, 1, net.numNeurons, rate);
        }

        public void train(int count)
        {

            float[] x = new float[2];
            float[] y = new float[1];
            for (int i = 0; i < count; i++)
            {
                x[0] = (float)(r.NextDouble());
                x[1] = (float)(r.NextDouble());
                y[0] = (float)(Math.Sqrt((x[0] * x[0]) + (x[1] * x[1])));
                trainer(x, y);

            }
        }

        public void display(List<TextBoxTuple> t)
        {
            throw new NotImplementedException();
        }
    }
}
