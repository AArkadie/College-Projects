using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class DirectionalLight : LightSource
    {
        public ColorV c;
        public Vector direction;

        public DirectionalLight(ColorV color, Vector d)
        {
            c = color;
            direction = d;
        }

        public ColorV illuminate(Vector point, Vector direction, SceneObject s)
        {
            double dot = direction.dot(this.direction);
            if (dot < 0) return new ColorV(0, 0, 0);
            else
            {
                Ray r = new Ray(point, this.direction);
                SceneObject testy = null;
                double d = Form1.shoot(r, s, out testy);
                if(d == -1)
                {
                    return c.scale((float)dot);
                }
                else /*if (testy != null) */return new ColorV(0, 0, 0);

                //Otherwise, shoot a ray from the surface - if it hits anything, return black.
            }
            //return c.scale((float)dot);
        }
    }
}
