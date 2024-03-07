namespace DorduncuUniteProje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;   
            BtnSonraki.Enabled = false;

            PicTrue.Visible = false;
            PicWrong.Visible = false;


            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {

                richTextBox1.Text = "Cumhuriyet kaç yılında kurulmuştur?";
                BtnA.Text = "1923";
                BtnB.Text = "1919";
                BtnC.Text = "1920";
                BtnD.Text = "1933";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi ilimiz Ege bölgesinde değildir";
                BtnA.Text = "İzmir";
                BtnB.Text = "İstanbul";
                BtnC.Text = "Aydın";
                BtnD.Text = "Muğla";
                label4.Text = "İstanbul";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi tek sayıdır?";
                BtnA.Text = "12";
                BtnB.Text = "10";
                BtnC.Text = "11";
                BtnD.Text = "9";
                label4.Text = "11";
                BtnSonraki.Text = "Sonuçlar";

            }
            if (soruno == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled= false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);

            }

        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruNo.Text = dogru.ToString();
                PicTrue.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisNo.Text = yanlis.ToString();
                PicWrong.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruNo.Text = dogru.ToString();
                PicTrue.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisNo.Text = yanlis.ToString();
                PicWrong.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruNo.Text = dogru.ToString();
                PicTrue.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisNo.Text = yanlis.ToString();
                PicWrong.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogruNo.Text = dogru.ToString();
                PicTrue.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlisNo.Text = yanlis.ToString();
                PicWrong.Visible = true;
            }
           
        }
    }
}

