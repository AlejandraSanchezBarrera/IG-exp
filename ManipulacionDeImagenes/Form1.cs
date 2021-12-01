using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacionDeImagenes
{
    public partial class Form1 : Form
    {
        Image img,img2;
        Bitmap bmp,bmp2;

        public Form1()
        {
            InitializeComponent();

            img=Image.FromFile(@"D:\alexa\UASLP\Semestre V (2021-2022)\Interfaces gráficas\VisualStudio\ManipulacionDeImagenes\hojas.jpg");
            img2 = Image.FromFile(@"D:\alexa\UASLP\Semestre V (2021-2022)\Interfaces gráficas\VisualStudio\ManipulacionDeImagenes\hojas.jpg");
            bmp = (Bitmap)img;
            bmp2 =(Bitmap)img2;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 100, 55);
        }

        private void original_MouseClick(object sender, MouseEventArgs e)
        {
            Color c;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp2.GetPixel(x, y);

                    bmp.SetPixel(x, y, c);
                }
            }

            Invalidate();
        }

        private void invertir_MouseClick(object sender, MouseEventArgs e)
        {
            Color c,nc;

            for(int y = 0; y < bmp.Height; y++) 
            {
                for (int x = 0; x < bmp.Width; x++) 
                {
                    c=bmp.GetPixel(x, y);

                    nc = Color.FromArgb(c.A,255-c.R,255-c.G,255-c.B);

                    bmp.SetPixel(x, y, nc);
                }
            }

            Invalidate(); //le dice al SO que mande un mensaje de que se tiene que redibujar
        }

        private void bw_MouseClick(object sender, MouseEventArgs e)
        {
            Color c, nc;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    byte gray = (byte)(c.R * 0.3f + c.G * 0.59f + c.B * 0.11f);
                    byte value = 0;
                    if (gray > 100)
                    {
                        value = 255;
                    }
                    nc = Color.FromArgb(c.A, value, value, value);

                    bmp.SetPixel(x, y, nc);
                }
            }

            Invalidate();
        }

        private void gris_MouseClick(object sender, MouseEventArgs e)
        {
            Color c, nc;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    c = bmp.GetPixel(x, y);
                    int intensidad = (c.R + c.G + c.B) / 3;
                    nc = Color.FromArgb(c.A, intensidad, intensidad, intensidad);

                    bmp.SetPixel(x, y, nc);
                }
            }

            Invalidate();
        }
    }
}
