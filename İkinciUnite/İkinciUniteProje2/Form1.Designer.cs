namespace Proje3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            listBox2 = new ListBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(149, 15);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 31);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 1;
            label1.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Tc Kimlik:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(149, 79);
            maskedTextBox2.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(185, 31);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 5;
            label3.Text = "Tarih";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(149, 137);
            maskedTextBox3.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(185, 31);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 7;
            label4.Text = "Saat:";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(149, 200);
            maskedTextBox4.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(185, 31);
            maskedTextBox4.TabIndex = 6;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(55, 374);
            button1.Name = "button1";
            button1.Size = new Size(86, 59);
            button1.TabIndex = 8;
            button1.Text = "Bilgi Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(42, 255);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 96);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(611, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(586, 280);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 31);
            dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(586, 340);
            button2.Name = "button2";
            button2.Size = new Size(86, 42);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 597);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 13;
            label5.Text = "TcNo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 481);
            label6.Name = "label6";
            label6.Size = new Size(32, 23);
            label6.TabIndex = 14;
            label6.Text = "Ad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 518);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 15;
            label7.Text = "Soyad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 554);
            label8.Name = "label8";
            label8.Size = new Size(33, 23);
            label8.TabIndex = 16;
            label8.Text = "Tel";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 478);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 518);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 31);
            textBox2.TabIndex = 18;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(136, 555);
            maskedTextBox5.Mask = "(999) 000-0000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(127, 31);
            maskedTextBox5.TabIndex = 19;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(136, 597);
            maskedTextBox6.Mask = "00000000000";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(127, 31);
            maskedTextBox6.TabIndex = 20;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(367, 478);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 21;
            label9.Text = "Şehir";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Çorum", "Ankara", "İstanbul", "Malatya", "Kocaeli", "Muğla" });
            comboBox1.Location = new Point(435, 475);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(367, 526);
            label10.Name = "label10";
            label10.Size = new Size(69, 23);
            label10.TabIndex = 23;
            label10.Text = "Doğum";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(442, 520);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 31);
            dateTimePicker2.TabIndex = 24;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(586, 413);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(545, 96);
            listBox2.TabIndex = 25;
            // 
            // button3
            // 
            button3.Location = new Point(731, 563);
            button3.Name = "button3";
            button3.Size = new Size(155, 65);
            button3.TabIndex = 26;
            button3.Text = "JettirBaba";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 690);
            Controls.Add(button3);
            Controls.Add(listBox2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox4;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private Label label9;
        private ComboBox comboBox1;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private ListBox listBox2;
        private Button button3;
    }
}
