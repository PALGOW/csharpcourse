namespace DorduncuUniteProje5
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblSoruNo = new Label();
            LblYanlisNo = new Label();
            LblDogruNo = new Label();
            BtnSonraki = new Button();
            PicTrue = new PictureBox();
            PicWrong = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)PicTrue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicWrong).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(859, 275);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // BtnA
            // 
            BtnA.Location = new Point(12, 293);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(352, 67);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new Point(386, 293);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(352, 67);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new Point(12, 366);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(352, 67);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new Point(386, 366);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(352, 67);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(936, 30);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(936, 83);
            label2.Name = "label2";
            label2.Size = new Size(92, 31);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(937, 138);
            label3.Name = "label3";
            label3.Size = new Size(91, 31);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            LblSoruNo.AutoSize = true;
            LblSoruNo.Location = new Point(1057, 30);
            LblSoruNo.Name = "LblSoruNo";
            LblSoruNo.Size = new Size(28, 31);
            LblSoruNo.TabIndex = 8;
            LblSoruNo.Text = "0";
            // 
            // LblYanlisNo
            // 
            LblYanlisNo.AutoSize = true;
            LblYanlisNo.Location = new Point(1057, 138);
            LblYanlisNo.Name = "LblYanlisNo";
            LblYanlisNo.Size = new Size(28, 31);
            LblYanlisNo.TabIndex = 9;
            LblYanlisNo.Text = "0";
            // 
            // LblDogruNo
            // 
            LblDogruNo.AutoSize = true;
            LblDogruNo.Location = new Point(1057, 83);
            LblDogruNo.Name = "LblDogruNo";
            LblDogruNo.Size = new Size(28, 31);
            LblDogruNo.TabIndex = 10;
            LblDogruNo.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new Point(886, 190);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(352, 67);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki Soru";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // PicTrue
            // 
            PicTrue.Image = (Image)resources.GetObject("PicTrue.Image");
            PicTrue.Location = new Point(873, 293);
            PicTrue.Name = "PicTrue";
            PicTrue.Size = new Size(192, 140);
            PicTrue.SizeMode = PictureBoxSizeMode.StretchImage;
            PicTrue.TabIndex = 12;
            PicTrue.TabStop = false;
            PicTrue.Visible = false;
            // 
            // PicWrong
            // 
            PicWrong.Image = (Image)resources.GetObject("PicWrong.Image");
            PicWrong.Location = new Point(1101, 293);
            PicWrong.Name = "PicWrong";
            PicWrong.Size = new Size(189, 140);
            PicWrong.SizeMode = PictureBoxSizeMode.StretchImage;
            PicWrong.TabIndex = 13;
            PicWrong.TabStop = false;
            PicWrong.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(787, 503);
            label4.Name = "label4";
            label4.Size = new Size(85, 31);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(787, 578);
            label5.Name = "label5";
            label5.Size = new Size(85, 31);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1349, 625);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PicWrong);
            Controls.Add(PicTrue);
            Controls.Add(BtnSonraki);
            Controls.Add(LblDogruNo);
            Controls.Add(LblYanlisNo);
            Controls.Add(LblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)PicTrue).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicWrong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblSoruNo;
        private Label LblYanlisNo;
        private Label LblDogruNo;
        private Button BtnSonraki;
        private PictureBox PicTrue;
        private PictureBox PicWrong;
        private Label label4;
        private Label label5;
    }
}
