using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Vector
    {
        public double x, y, z;

        public static Vector Zero()
        {
            return new Vector(0, 0, 0);
        }

        public Vector(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;
        }

        public Vector(Vector a, Vector b)
        {
            x = b.x - a.x;
            y = b.y - a.y;
            z = b.z - a.z;
        }

        public Vector plus(Vector v)
        {
            return new Vector(x + v.x, y + v.y, z + v.z);
        }

        public Vector times(double d)
        {
            return new Vector(d * x, d * y, d * z);
        }

        public double magnitude()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public Vector unit()
        {
            return this.times(1 / magnitude());
        }

        public double dot(Vector v)
        {
            return (x * v.x) + (y * v.y) + (z * v.z);
        }

        public Vector cross(Vector v)
        {
            return new Vector((y * v.z) - (z * v.y),
                              (z * v.x) - (x * v.z),
                              (x * v.y) - (y * v.x));
        }

        public Vector fromSpherical(double r, double theta, double phi)
        {
            return new Vector((r * Math.Sin(theta) * Math.Cos(phi)),
                              (r * Math.Sin(theta) * Math.Sin(phi)),
                              (r * Math.Cos(theta)));
        }
    }
}
