﻿namespace DorduncuUniteIkinciProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 38);
            button1.Name = "button1";
            button1.Size = new Size(123, 47);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 149);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 1;
            label1.Text = "Sınav 1:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 251);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 3;
            label2.Text = "Proje:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 201);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 4;
            label3.Text = "Sınav 2:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 34);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 201);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 34);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(438, 201);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 34);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 201);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 7;
            label4.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1600, 840);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
    }
}
