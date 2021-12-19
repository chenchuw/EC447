using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        
        //dimensions
        private const float clientSize = 100;
        private const float linelength = 80;
        private const float block = linelength / 3;
        private const float offset = 10;
        private const float delta = 5;

        private float scale;    //current scale factor
                                
        public GameEngine TicTac;

        public Form1()
        {
            TicTac = new GameEngine();
            InitializeComponent();
            ResizeRedraw = true;
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyTransform(g);                                    // rescale via transform
            //draw board
            g.DrawLine(Pens.Black, block, 0, block, linelength);
            g.DrawLine(Pens.Black, 2 * block, 0, 2 * block, linelength);
            g.DrawLine(Pens.Black, 0, block, linelength, block);
            g.DrawLine(Pens.Black, 0, 2 * block, linelength, 2 * block);
            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    if (TicTac.grid[i, j] == 'O')            // draw o
                        DrawO(i, j, g);
                    else if (TicTac.grid[i, j] == 'X')       // draw x
                        DrawX(i, j, g);
        }

        private void ApplyTransform(Graphics g)
        {
            scale = Math.Min(ClientRectangle.Width / clientSize,
                ClientRectangle.Height / clientSize);
            if (scale == 0f) return;
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(offset, offset);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            ApplyTransform(g);                                        // rescale via transform
            PointF[] p = { new Point(e.X, e.Y) };
            g.TransformPoints(CoordinateSpace.World,
                            CoordinateSpace.Device, p);
            if (!TicTac.computer_turn)
            {
                Invalidate();
                TicTac.UserTurn(e, p, TicTac);                // if user move
            }

            if (TicTac.turn_count >= 0)                                 // if first turn has passed
            {
                computerStartToolStripMenuItem.Enabled = false;
                TicTac.computer_firstmove = false;
            }
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTac = new GameEngine();
            computerStartToolStripMenuItem.Enabled = true;
            Invalidate();
        } 
        private void computerStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            computerStartToolStripMenuItem.Enabled = false;        
            TicTac.computer_turn = true;
            TicTac.computer_firstmove = true;
            TicTac.CompTurn(TicTac);
            Invalidate();
        }
        public void DrawX(int i, int j, Graphics g)
        {
            g.DrawLine(Pens.Black, i * block + delta, j * block + delta, (i * block) + block - delta, (j * block) + block - delta);
            g.DrawLine(Pens.Black, (i * block) + block - delta, j * block + delta, (i * block) + delta, (j * block) + block - delta);
        }
        public void DrawO(int i, int j, Graphics g)
        {
            g.DrawEllipse(Pens.Black, i * block + delta, j * block + delta, block - 2 * delta, block - 2 * delta);
        }
    }
}
