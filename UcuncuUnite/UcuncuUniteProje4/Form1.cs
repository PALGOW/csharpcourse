namespace UcuncuUniteProje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double sayi;
            sayi = 4.25;
            label1.Text = sayi.ToString();*/

            /* double s1, s2, s3, ort;
             s1 = 60;
             s2 = 40;
             s3 = 73;
             ort = (s1+s2 + s3) / 3;
             label1.Text = ort.ToString("0.00");*/

            double sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
