namespace UcuncuUniteSonProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzun, kisa, alan;

            uzun = Convert.ToInt16(TxtUzun.Text);
            kisa = Convert.ToInt16(TxtKisa.Text);


            alan = kisa * uzun;

            TxtAlan.Text = alan.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cap, cemberalan;
            cap = Convert.ToInt16(TxtCap.Text);

            cemberalan = cap * cap * 3;

            TxtCemberAlan.Text = cemberalan.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, sinav4, ortalama;

            sinav1 = Convert.ToInt16(TxtSinav1.Text);
            sinav2 = Convert.ToInt16(TxtSinav2.Text);
            sinav3 = Convert.ToInt16(TxtSinav3.Text);
            sinav4 = Convert.ToInt16(TxtSinav4.Text);

            ortalama = (sinav1 + sinav2 + sinav3 + sinav4) / 4;

            TxtOrt.Text = ortalama.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, toplam, cikartim, carpim;

            sayi1 = Convert.ToInt16(TxtSayi1.Text);
            sayi2 = Convert.ToInt16(TxtSayi2.Text);
            sayi3= Convert.ToInt16(TxtSayi3.Text);

            toplam = sayi1+sayi2+sayi3;
            cikartim = sayi1-sayi2-sayi3;
            carpim = sayi1 * sayi2 * sayi3;

            TxtTopla.Text = toplam.ToString();
            TxtCikar.Text = cikartim.ToString();
            TxtCarp.Text = carpim.ToString();
        }
    }
}
