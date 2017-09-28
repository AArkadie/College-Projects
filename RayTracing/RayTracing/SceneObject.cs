using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public interface SceneObject
    {
        double intersects(Ray ray);
        Vector normal(Vector v);
        Point texture(Vector v);
        Skin skin();
    }
}
