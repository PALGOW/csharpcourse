namespace UcuncuUniteProje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            label2.Text = sayi.ToString();*/

            /*int kup, sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            kup = sayi*sayi*sayi;
            label2.Text = kup.ToString();*/


            int pi, r, alan;
            pi = 3;
            r = Convert.ToInt16(textBox1.Text);
            alan = pi * r * r;
            label2.Text = alan.ToString();

        }
    }
}
