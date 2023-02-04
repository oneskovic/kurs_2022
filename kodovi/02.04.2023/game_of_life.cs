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

        private int d = 10;
        private void NacrtajMatricu(bool[,] matrica,int n, int m, Graphics g)
        {
            var b = new SolidBrush(Color.Black);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrica[i,j])
                    {
                        Point p = new Point(j * d, i * d);
                        g.FillRectangle(b, p.X, p.Y, d, d);
                    }
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int w = ClientRectangle.Width;
            int h = ClientRectangle.Height;
            int r = 100;

            var g = CreateGraphics();
            g.Clear(Color.White);
            int n = h / d;
            int m = w / d;

            bool[,] matrica = new bool[n, m];

            var rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int red = rand.Next(n);
                int kolona = rand.Next(m);
                matrica[red,kolona] = true;
            }

            NacrtajMatricu(matrica, n, m, g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
