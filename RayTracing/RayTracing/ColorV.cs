using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class ColorV
    {
        public float r, g, b;

        public ColorV(float a, float c, float d)
        {
            r = a;
            g = c;
            b = d;
        }

        public ColorV scale(float d)
        {
            return new ColorV(r * d, g * d, b * d);
        }

        public ColorV add(ColorV c)
        {
            return new ColorV(r + c.r, g + c.g, b + c.b);
        }

        public float intensity()
        {
            return (float)Math.Sqrt((r * r) + (g * g) + (b * b));
        }

        public Color toRGB()
        {
            return Color.FromArgb((int)(r*255),(int)(g*255),(int)(b*255));
        }

        public ColorV multiply(ColorV c)
        {
            return new ColorV(r * c.r, g * c.g, b * c.b);
        }
    }
}
