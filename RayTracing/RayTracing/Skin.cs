using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public interface Skin
    {
        ColorV colorAt(SceneObject s, Vector v);
    }
}
