
namespace Lab4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start_int = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListBox();
            this.exception = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Numeric Palindromes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a starting integer (0-1,000,000,000):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(970, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter count (1-100):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(512, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "by Chuwei Chen";
            // 
            // start_int
            // 
            this.start_int.Location = new System.Drawing.Point(613, 418);
            this.start_int.Name = "start_int";
            this.start_int.Size = new System.Drawing.Size(100, 35);
            this.start_int.TabIndex = 4;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(1226, 418);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 35);
            this.count.TabIndex = 5;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(710, 489);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(136, 46);
            this.Generate.TabIndex = 6;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 24;
            this.Result.Location = new System.Drawing.Point(640, 572);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(273, 244);
            this.Result.TabIndex = 7;
            // 
            // exception
            // 
            this.exception.AutoSize = true;
            this.exception.Location = new System.Drawing.Point(490, 872);
            this.exception.Name = "exception";
            this.exception.Size = new System.Drawing.Size(0, 24);
            this.exception.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 928);
            this.Controls.Add(this.exception);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.count);
            this.Controls.Add(this.start_int);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EC447 Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox start_int;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Label exception;
    }
}

