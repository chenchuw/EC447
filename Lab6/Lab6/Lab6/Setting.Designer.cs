
namespace Lab6
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PenWidth = new System.Windows.Forms.ListBox();
            this.FillColor = new System.Windows.Forms.ListBox();
            this.PenColor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PenWidth
            // 
            this.PenWidth.FormattingEnabled = true;
            this.PenWidth.ItemHeight = 18;
            this.PenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PenWidth.Location = new System.Drawing.Point(350, 62);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(120, 184);
            this.PenWidth.TabIndex = 0;
            // 
            // FillColor
            // 
            this.FillColor.FormattingEnabled = true;
            this.FillColor.ItemHeight = 18;
            this.FillColor.Items.AddRange(new object[] {
            "No Fill",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FillColor.Location = new System.Drawing.Point(192, 62);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(120, 94);
            this.FillColor.TabIndex = 1;
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.ItemHeight = 18;
            this.PenColor.Items.AddRange(new object[] {
            "No Outline",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PenColor.Location = new System.Drawing.Point(30, 62);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(120, 94);
            this.PenColor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fill Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Outline/Pen Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 317);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PenColor);
            this.Controls.Add(this.FillColor);
            this.Controls.Add(this.PenWidth);
            this.Name = "Setting";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox PenWidth;
        public System.Windows.Forms.ListBox FillColor;
        public System.Windows.Forms.ListBox PenColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}