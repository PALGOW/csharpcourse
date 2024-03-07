namespace UcuncuUniteProje8
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
            groupBox1 = new GroupBox();
            TxtBilet = new TextBox();
            label4 = new Label();
            TxtSu = new TextBox();
            label3 = new Label();
            TxtCay = new TextBox();
            label2 = new Label();
            TxtMisir = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            LblKasa = new Label();
            label12 = new Label();
            button1 = new Button();
            LblToplam = new Label();
            label9 = new Label();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGoldenrod;
            groupBox1.Controls.Add(TxtBilet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtSu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtCay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtMisir);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(110, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // TxtBilet
            // 
            TxtBilet.Location = new Point(96, 213);
            TxtBilet.Name = "TxtBilet";
            TxtBilet.Size = new Size(100, 31);
            TxtBilet.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 216);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 6;
            label4.Text = "Bilet:";
            // 
            // TxtSu
            // 
            TxtSu.Location = new Point(96, 159);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(100, 31);
            TxtSu.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 162);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 4;
            label3.Text = "Su:";
            // 
            // TxtCay
            // 
            TxtCay.Location = new Point(96, 105);
            TxtCay.Name = "TxtCay";
            TxtCay.Size = new Size(100, 31);
            TxtCay.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 108);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 2;
            label2.Text = "Çay:";
            // 
            // TxtMisir
            // 
            TxtMisir.Location = new Point(96, 51);
            TxtMisir.Name = "TxtMisir";
            TxtMisir.Size = new Size(100, 31);
            TxtMisir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 54);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 0;
            label1.Text = "Mısır: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightYellow;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(436, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilgi Ekranı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 206);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 8;
            label8.Text = "Bilet: 10 TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 155);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 8;
            label7.Text = "Su: 2 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 104);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 8;
            label6.Text = "Çay: 3 TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 53);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 8;
            label5.Text = "Mısır: 4 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkOrange;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(LblKasa);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(LblToplam);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(748, 199);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(272, 328);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // LblKasa
            // 
            LblKasa.AutoSize = true;
            LblKasa.Location = new Point(153, 279);
            LblKasa.Name = "LblKasa";
            LblKasa.Size = new Size(54, 23);
            LblKasa.TabIndex = 4;
            LblKasa.Text = "00 TL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(69, 279);
            label12.Name = "label12";
            label12.Size = new Size(57, 23);
            label12.TabIndex = 3;
            label12.Text = "Kasa: ";
            // 
            // button1
            // 
            button1.Location = new Point(59, 155);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 2;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LblToplam
            // 
            LblToplam.AutoSize = true;
            LblToplam.Location = new Point(143, 111);
            LblToplam.Name = "LblToplam";
            LblToplam.Size = new Size(54, 23);
            LblToplam.TabIndex = 1;
            LblToplam.Text = "00 TL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(59, 111);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 0;
            label9.Text = "Toplam: ";
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(110, 45);
            label11.Name = "label11";
            label11.Size = new Size(650, 56);
            label11.TabIndex = 3;
            label11.Text = "Sinema Büfe Satış Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(807, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(59, 207);
            button2.Name = "button2";
            button2.Size = new Size(148, 48);
            button2.TabIndex = 5;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1143, 690);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Sinema Büfesi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtMisir;
        private Label label1;
        private TextBox TxtBilet;
        private Label label4;
        private TextBox TxtSu;
        private Label label3;
        private TextBox TxtCay;
        private Label label2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Label LblToplam;
        private Label label9;
        private Button button1;
        private Label label11;
        private PictureBox pictureBox1;
        private Label LblKasa;
        private Label label12;
        private Button button2;
    }
}
