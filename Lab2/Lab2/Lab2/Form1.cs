using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point point = new Point(e.X, e.Y);
                this.coordinates.Add(point);
                this.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.coordinates.Clear();
                this.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (Point point in this.coordinates)
            {
                graphics.FillEllipse(Brushes.Red, point.X - 10, point.Y - 10, 20, 20);
                graphics.DrawString(point.ToString(), this.Font, Brushes.Black, (float)(point.X + 20), (float)(point.Y - 5));
            }
        }
    }
}
