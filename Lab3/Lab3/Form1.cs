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

namespace Lab3
{
    public partial class Form1 : Form
    {
        private bool show_line = false;
        private ArrayList coordinates = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.show_line == false)
            {
                this.show_line = true;
                this.button1.Text = "Hide Lines";
            }
            else
            {
                this.show_line = false;
                this.button1.Text = "Show Lines";
            }
            base.Invalidate();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Point current_point;
            Point point1 = new Point(0, 0);
            bool buffer = true;
            
            if (this.show_line == true)
            {
                foreach (Point point in this.coordinates)
                {
                    current_point = point;
                    current_point.X += base.AutoScrollPosition.X;
                    current_point.Y += base.AutoScrollPosition.Y;
                    
                    if (!buffer)
                    {
                        graphics.DrawLine(Pens.Black, point1, current_point);
                        point1 = current_point;
                    }
                    else
                    {
                        buffer = false;
                        point1 = current_point;
                    }
                }
            }
            foreach (Point point in this.coordinates)
            {
                current_point = point;
                current_point.X += base.AutoScrollPosition.X;
                current_point.Y += base.AutoScrollPosition.Y;
                graphics.FillEllipse(Brushes.Red, current_point.X - 10, current_point.Y - 10, 20, 20);
            }
        }

        private void ChuweiChen_Lab3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                pt.X -= base.AutoScrollPosition.X;
                pt.Y -= base.AutoScrollPosition.Y;
                this.coordinates.Add(pt);
                base.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.coordinates.Clear();
                base.Invalidate();
            }
        }
    }
}
