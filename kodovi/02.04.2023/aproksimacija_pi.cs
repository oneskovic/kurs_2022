using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private double udaljenost(Point A, Point B)
        {
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int w = ClientRectangle.Width;
            int h = ClientRectangle.Height;
            int r = 100;

            var g = CreateGraphics();
            g.Clear(Color.White);

            Point centar = new Point(w / 2, h / 2);
            g.DrawEllipse(Pens.Black, w / 2 - r, h / 2 - r, 2*r, 2*r);

            int n = 500000;
            var rand = new Random();
            int tacke_u_krugu = 0;

            for (int i = 0; i < n; i++)
            {
                int x = rand.Next(w);
                int y = rand.Next(h);

                Point p = new Point(x, y);
                SolidBrush b;
                if (udaljenost(p, centar) <= r)
                {
                    b = new SolidBrush(Color.Red);
                    tacke_u_krugu++;
                }
                else
                    b = new SolidBrush(Color.Blue);

                g.FillRectangle(b, x, y, 1, 1);
            }
            double verovatnoca = (double)tacke_u_krugu / n;
            double a = verovatnoca * w * h / (r * r);

            label1.Text = a.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
