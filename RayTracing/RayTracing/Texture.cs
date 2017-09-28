using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public interface Texture
    {
        ColorV colorAt(Point p);
    }
}
