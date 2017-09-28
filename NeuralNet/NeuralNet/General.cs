using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class GeneralPoly : PolyStrat
    {

        public int deg;

        public GeneralPoly(int n)
        {
            deg = n;
        }

        public float degree(float x)
        {
            return (float)Math.Pow(x, deg);
        }
    }
}
