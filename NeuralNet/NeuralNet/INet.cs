using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public interface INet
    {
        void initialize(int neurons, float noiseMagnitude);
        void setRate(float rate);
        void train(int count);
        double getError(int n);
        void paint(int width, int height, System.Drawing.Graphics g);
        void display(List<TextBoxTuple> t);
    }
}
