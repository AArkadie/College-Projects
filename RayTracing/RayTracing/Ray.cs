using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Ray
    {
        public Vector origin, direction;

        public Ray(Vector a, Vector b)
        {
            origin = a;
            direction = b.unit();
        }

        public Vector travel(float t)
        {
            return origin.plus(direction.times(t));
        }
    }
}
