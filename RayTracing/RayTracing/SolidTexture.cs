using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class SolidTexture : Texture
    {
        ColorV c;

        public SolidTexture(ColorV c)
        {
            this.c = c;
        }

        public ColorV colorAt(Point p)
        {
            return c;
        }
    }
}
