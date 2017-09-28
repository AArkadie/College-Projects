using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNet
{
    public class TextBoxTuple
    {
        public double valIn { get; }
        public TextBox boxOut { get; }

        public TextBoxTuple(double d, TextBox t)
        {
            valIn = d;
            boxOut = t;
        }
    }
}
