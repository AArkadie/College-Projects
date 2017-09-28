using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class Multinet : INet //has multiple OneOneNets
    {
        public OneOneNet[] nets;
        public double scale;

        public Multinet(int n, double d)
        {
            nets = new OneOneNet[n];
            scale = d;
        }

        public void display(List<TextBoxTuple> t)
        {
            foreach (TextBoxTuple tu in t)
            {
                float sum = 0;
                for (int i = 0; i < nets.Length; i++)
                {
                    sum += nets[i].gibeCancer(tu);
                }
                tu.boxOut.Text = "" + sum * scale;
            }
            
        }

        public double getError(int n)
        {
            throw new NotImplementedException();
        }

        public void initialize(int neurons, float noiseMagnitude)
        {
            for(int i = 0; i < nets.Length; i++)
            {
                nets[i] = new OneOneNet(i+1, scale);
                nets[i].initialize(neurons, noiseMagnitude);
            }
        }

        public void paint(int width, int height, Graphics g)
        {
            foreach(OneOneNet a in nets)
            {
                a.paint(width, height, g);
            }
        }

        public void setRate(float rate)
        {
            foreach (OneOneNet a in nets)
            {
                a.setRate(rate);
            }
        }

        public void train(int count)
        {
            foreach (OneOneNet a in nets)
            {
                a.train(count);
            }
        }
    }
}
