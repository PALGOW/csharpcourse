namespace DorduncuUniteProje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string islem = textBox3.Text;
            int sayi1 = Convert.ToInt32(textBox1.Text); 
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam, cikar, carp;
            double bol;
            toplam=sayi1+sayi2;
            cikar=sayi1-sayi2;
            carp=sayi1*sayi2;
            bol=sayi1/sayi2;

            switch (islem)
            {
                case "+": label2.Text = toplam.ToString(); break;
                case "-": label2.Text= cikar.ToString(); break;
                case "*": label2.Text = carp.ToString(); break;
                case "/": label2.Text = bol.ToString(); break;
                default: label2.Text = "hata"; break;
            }

            // küsüratlı böldürmeyi yapamadım


















            /*string mevsim = textBox1.Text;

            switch (mevsim)
            {
                case "yaz": label2.Text = "haziran temmuz ağustos"; break;
                case "sonbahar": label2.Text = "eylül ekim kasım"; break;
                case "kış": label2.Text = "aralık ocak şubat"; break;
                case "ilkbahar": label2.Text = "mart nisan mayıs"; break;
                default:label2.Text = "hatalı mevsim"; break;
            }*/





            /*int ay = Convert.ToInt16(textBox1.Text);
            switch (ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Şubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz"; break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default: label2.Text = "Hatalı Ay"; break;
            }*/

        }
    }
}
