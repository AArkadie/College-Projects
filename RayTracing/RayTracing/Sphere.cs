using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class Sphere : SceneObject
    {
        public Vector center, vn, ve;
        public double radius;
        Skin s;

        public Sphere(Vector c, double r, Texture t, Vector n, Vector e)
        {
            center = c;
            radius = r;
            s = new PaintedSkin(t);
            vn = normal(n);
            ve = vn.cross(e);
        }

        public double intersects(Ray ray)
        {
            if (new Vector(center, ray.origin).magnitude() < radius) return -1;
            Vector EO = new Vector(ray.origin, center);
            Vector V = ray.direction;
            double c = EO.magnitude();
            double v = EO.dot(V);
            double d = Math.Sqrt((radius * radius) - ((c * c) - (v * v)));

            
            double disc = (radius * radius) - ((EO.dot(EO) - (v * v)));
            if (disc < 0)
            {
                return -1;
            }
            else
            {
                d = Math.Sqrt(disc);
                double ans1 = v - d;
                double ans2 = v + d;

                if (ans1 > 0) return ans1;
                if (ans2 > 0) return ans2;
                return -1;
            }
        }

        public Vector normal(Vector v)
        {
            return new Vector(center, v).times(1/ radius);
        }

        public Skin skin()
        {
            return s;
        }

        public Point texture(Vector v1)
        {
            //*
            Vector vp = v1.unit();
            //       vn = normal(new Vector(0,0,1));
            //       ve = vp.cross(vn);
            double phi = Math.Acos( -vp.dot(vn));
            double v = phi / Math.PI;
            double u;
            double theta = ( Math.Acos( vp.dot(ve) / Math.Sin( phi )) ) / ( 2 * Math.PI);
            if ( vn.cross(ve).dot(vp) > 0 ) u = theta; 
            else u = 1 - theta;
            /*/
            Vector d = new Vector(v1, center).unit();
            double u = 0.5 + (Math.Atan2(d.z, d.x) / (2 * Math.PI));
            double v = 0.5 - (Math.Asin(d.y) / Math.PI);
            //*/
            return new Point(u, v);
            
        }
    }
}
