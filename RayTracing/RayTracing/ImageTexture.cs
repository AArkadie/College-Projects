using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracing
{
    public class ImageTexture : Texture
    {
        Bitmap pic;

        public ImageTexture(Bitmap i)
        {
            pic = i;
        }

        public ColorV colorAt(Point p)
        {
            double multFactorX = pic.Width - 1;
            double multFactorY = pic.Height - 1;
            Color c = pic.GetPixel((int)(p.x * multFactorX), (int)(p.y * multFactorY));
            return new ColorV((float)c.R / 255, (float)c.G / 255, (float)c.B / 255);
        }
    }
}
