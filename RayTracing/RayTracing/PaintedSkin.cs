using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class PaintedSkin : Skin
    {
        Texture t;

        public PaintedSkin(Texture t)
        {
            this.t = t;
        }

        public ColorV colorAt(SceneObject s, Vector v)
        {
            Vector sNorm = s.normal(v);
            ColorV sCol = t.colorAt(s.texture(v));
            ColorV sum = new ColorV(0, 0, 0);
            for(int i = 0; i < Form1.lights.Count; i++)
            {
                sum = sum.add(Form1.lights.ElementAt(i).illuminate(v, s.normal(v),s));
            }
            return sum.multiply(sCol);
            /*
            In PaintedSkin, define the ColorAt method to:

    Compute the surface normal from the scene object
    Compute the surface color by passing the texture point to the underlying texture
    Compute the illumination by adding up the light from each light source.
    Multiply the total illumination by the surface color and return it. 
            */
        }
    }
}
