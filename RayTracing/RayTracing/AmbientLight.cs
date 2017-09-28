using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class AmbientLight : LightSource
    {
        ColorV c;

        public AmbientLight(ColorV a)
        {
            c = a;
        }

        public ColorV illuminate(Vector point, Vector direction, SceneObject s)
        {
            return c;
        }
    }
}
