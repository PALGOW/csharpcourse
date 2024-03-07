namespace Unite3Proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* string ad, soyad;
             int sinav1, sinav2, proje;
             double ortalama;

             ad = textBox1.Text;
             soyad = textBox2.Text;
             sinav1 = Convert.ToInt32(textBox3.Text);
             sinav2 = Convert.ToInt32(textBox4.Text);
             proje = Convert.ToInt32(textBox5.Text);

             ortalama = (sinav1 + sinav2 + proje) / 3;

             listBox1.Items.Add(ad + " " + soyad + " İlk Sınav Notunuz: " + sinav1 + " İkinci Sınav Notunuz: " + sinav2 + " Proje Notunuz: " + proje + " Ortalamanız: " + ortalama);
            */


        }

        private void label2_Click(object sender, EventArgs e)
        {
            string ad;
            int fiyat;
            double yuzde8, yuzde18;


            ad = textBox1.Text;
            fiyat = Convert.ToInt16(textBox2.Text);
            yuzde18 = Convert.ToInt16(textBox3.Text);
            yuzde8 = Convert.ToInt16(textBox4.Text);

            yuzde8 = (fiyat * 0, 08 + fiyat);
            yuzde18 = (fiyat * 0.18, 18 + fiyat);





        }
    }
}
