using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            this.Result.Items.Clear();
            this.exception.Text = string.Empty;

            int index = 0;
            int count = 100;
            long start = 0;
            
            try
            {
                start = Convert.ToInt32(this.start_int.Text);
                count = Convert.ToInt16(this.count.Text);
                if ((start > 1000000000) || (start < 0) || (count < 1) || (count > 100))
                {
                    throw new Exception();
                }
            }
            catch
            {
                this.exception.Text = "Please enter a positive integer within range.";
                return;
            }

            while (index < count)
            {
                if (this.palindrome_helper(start))
                {
                    this.Result.Items.Add(start.ToString());
                    index++;
                }
                start++;
            }
        }
        private bool palindrome_helper(long start)
        {
            StringBuilder palindrome = new StringBuilder();
            string input = start.ToString();
            for (int i = 0; i < input.Length; i++)
            {
                palindrome.Append(input[(input.Length - i) - 1]);
            }
            if (input == palindrome.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
