using System;
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

    public partial class Setting : Form
    {
        private int penColor, fillColor, width;
        public Setting()
        {
            InitializeComponent();
            PenColor.SelectedIndex = 0;
            FillColor.SelectedIndex = 0;
            PenWidth.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e) // OK button
        {
            base.Close();
        }

        private void button1_Click(object sender, EventArgs e) // cancel button
        {
            PenColor.SelectedIndex = penColor;
            FillColor.SelectedIndex = fillColor;
            PenWidth.SelectedIndex = width;
            base.Close();
        }

        protected override void OnShown (EventArgs e)
        {
            penColor = PenColor.SelectedIndex;
            fillColor = FillColor.SelectedIndex;
            width = PenWidth.SelectedIndex;
        }
    }
}
