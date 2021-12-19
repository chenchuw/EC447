using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private Setting settingWindow = new Setting();
        private ArrayList objects = new ArrayList();
        private Point startPoint;
        private Point endPoint;
        private bool firstClick = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingWindow.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objects.Count > 0)
                objects.RemoveAt(objects.Count - 1);
            base.Invalidate();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objects.Clear();
            base.Invalidate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (firstClick)
            {
                startPoint = e.Location;
                firstClick = false;
                base.Invalidate();
            } 
            else
            {
                firstClick = true;
                endPoint = e.Location;
                Brush outside = null;
                Brush fill = null;
                Pen width = null;

                switch (settingWindow.PenColor.SelectedIndex)
                {
                    case 1:
                        outside = Brushes.Black;
                        break;
                    case 2:
                        outside = Brushes.Red;
                        break;
                    case 3:
                        outside = Brushes.Blue;
                        break;
                    case 4:
                        outside = Brushes.Green;
                        break;
                }
                
               switch (settingWindow.FillColor.SelectedIndex)
               {
                    case 1:
                        fill = Brushes.Black;
                        break;
                    case 2:
                        fill = Brushes.Red;
                        break;
                    case 3:
                        fill = Brushes.Blue;
                        break;
                    case 4:
                        fill = Brushes.Green;
                        break;
                }
               
                if (outside != null)
                {
                    width = new Pen(outside, (float)int.Parse((string)settingWindow.PenWidth.SelectedItem)); // turn the selected item into string into int then into float
                }
                if ((fill != null) || (width != null))
                {
                    objects.Add(new drawRectangle(startPoint, endPoint, width, fill));
                }
                else
                    MessageBox.Show("Fill and or pen/outline color must be selected.");
                base.Invalidate();
            }
            
        }

        // Class of drawing Rectangle
        public class drawRectangle
        {
            private Point start;
            private Point end;
            private Pen pen;
            private Brush brush;
            public drawRectangle(Point start, Point end, Pen pen, Brush brush)
            {
                this.start = start;
                this.end = end;
                this.pen = pen;
                this.brush = brush;
            }
            public void draw(Graphics g)
            {
                int length = Math.Abs(end.X - start.X);
                int width = Math.Abs(end.Y - start.Y);
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                if (brush != null)
                {
                    g.FillRectangle(brush, x, y, length, width);
                }
                if (pen != null)
                {
                    g.DrawRectangle(pen, x, y, length, width);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (drawRectangle obj in objects) // When any object is selected, draw it.
                obj.draw(g);
            if (!firstClick)
                g.FillEllipse(Brushes.Black, startPoint.X - 5, startPoint.Y - 5, 10, 10);
        }
    }
}
