using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayTracing
{
    public partial class Form1 : Form
    {
        public static List<SceneObject> objects = new List<SceneObject>();
        public static List<LightSource> lights = new List<LightSource>();
        public ColorV bgColor = new ColorV(0, 0, 0);
        public Vector camera = new Vector(0, -5, 0);
        public Texture earthmap = new ImageTexture(RayTracing.Properties.Resources.earthmap);
        public Texture facemap = new ImageTexture(RayTracing.Properties.Resources.morgan);
        public ColorV[,] colors = new ColorV[200,200];
        public bool traced = false;

        public static double shoot(Ray r, SceneObject s, out SceneObject hit)
        {
            double distance = -1;
            hit = null;
            foreach(SceneObject k in objects)
            {
                if (k != s)
                {
                    double tdist = k.intersects(r);
                    if (tdist != -1 && (distance == -1 || tdist < distance))
                    {
                        distance = tdist;
                        hit = k;
                    }
                }
            }

            return distance;
        }

        public Form1()
        {
            InitializeComponent();
            lights.Add(new DirectionalLight(new ColorV(.8F, .8F, .8F), new Vector(1, -1, 1).unit()));
            lights.Add(new AmbientLight(new ColorV(.2F, .2F, .2F)));
            //objects.Add(new Sphere(Vector.Zero(), 1, new SolidTexture(new ColorV(1, 0, 0), new Vector(0,0,1), new Vector(0,1,0))));
            objects.Add(new Sphere(new Vector(0, 0, 0), 1, earthmap, new Vector(0,0,1), new Vector(0,1,0)));
            //objects.Add(new Sphere(new Vector(0, 0, 0), 1, facemap, new Vector(0,0,1), new Vector(0,1,0)));
        }

        private void start_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < colors.GetLength(0); i++)
            {
                for(int j = 0; j < colors.GetLength(1); j++)
                {
                    double x = ((double)i / colors.GetLength(0)) * 2 - 1;
                    double z = ((double)j / colors.GetLength(1)) * 2 - 1;
                    Ray tracer = new Ray(camera, new Vector(camera, new Vector(x,0,z)));
                    SceneObject hit = null;
                    double d = shoot(tracer, null, out hit);
                    if (d == -1)
                    {
                        colors[i, j] = bgColor;
                    }
                    else
                    {
                        colors[i, j] = hit.skin().colorAt(hit, tracer.travel((float)d));
                    }
                }
            }
            traced = true;
            Refresh();
        }

        private void pBox_Paint(object sender, PaintEventArgs e)
        {
            int smallWidth = colors.GetLength(0);
            int smallHeight = colors.GetLength(1);
            float pixelWidth = (float)pBox.Width / smallWidth;
            float pixelHeight = (float)pBox.Height / smallHeight;

            if (traced)
            {
                Graphics g = e.Graphics;
                for (int i = 0; i < smallWidth; i++)
                {
                    for (int j = 0; j < smallHeight; j++)
                    {
                        Brush b = new SolidBrush(colors[i, j].toRGB());
                        g.FillRectangle(b, i * pixelWidth, j * pixelHeight, pixelWidth, pixelHeight);
                    }
                }
            }
        }

        private void distControl_Scroll(object sender, EventArgs e)
        {
            camera = new Vector(0, (double)distControl.Value, 0);
            start_Click(sender, e);
        }
        /*
        private void phiControl_Scroll(object sender, EventArgs e)
        {
            directional = new ColorV(directional.r, (float)phiControl.Value / 100, directional.b);
            start_Click(sender, e);
        }

        private void thetaControl_Scroll(object sender, EventArgs e)
        {
            directional = new ColorV(directional.r, directional.g, (float)thetaControl.Value / 100);
            start_Click(sender, e);
        }
        */
    }
}
