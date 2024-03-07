namespace Proje2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            listBox2 = new ListBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bursa", "Ankara", "Muğla", "Çorum", "Aydın", "İzmir", "Antep" });
            comboBox1.Location = new Point(60, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(78, 108);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(415, 120);
            button2.Name = "button2";
            button2.Size = new Size(100, 44);
            button2.TabIndex = 2;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 3;
            label1.Text = "Şehir";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(415, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Elektrik Mühendisi", "Endüstri Mühendisi", "Makina Mühendisi", "Otomotiv Mühendisi" });
            listBox1.Location = new Point(81, 238);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 88);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(99, 354);
            button3.Name = "button3";
            button3.Size = new Size(82, 52);
            button3.TabIndex = 6;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 270);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 7;
            label2.Text = "Meslek";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(415, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(428, 319);
            button4.Name = "button4";
            button4.Size = new Size(76, 36);
            button4.TabIndex = 9;
            button4.Text = "Ekle2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 437);
            label3.Name = "label3";
            label3.Size = new Size(29, 21);
            label3.TabIndex = 10;
            label3.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 469);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 11;
            label4.Text = "Soyad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 503);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 12;
            label5.Text = "Meslek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 538);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 13;
            label6.Text = "Maaş";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(428, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(428, 472);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(428, 507);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 29);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(428, 542);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 29);
            textBox6.TabIndex = 17;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(12, 436);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(303, 88);
            listBox2.TabIndex = 18;
            // 
            // button5
            // 
            button5.Location = new Point(415, 587);
            button5.Name = "button5";
            button5.Size = new Size(142, 41);
            button5.TabIndex = 19;
            button5.Text = "Verileri Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1029, 630);
            Controls.Add(button5);
            Controls.Add(listBox2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ListBox listBox2;
        private Button button5;
    }
}
