namespace UcuncuUniteProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad;
            string meslek;
            string cinsiyet;
            string yas;

            adsoyad = textBox1.Text;
            meslek = textBox2.Text;
            yas = maskedTextBox1.Text;
            cinsiyet = comboBox1.Text;

            listBox1.Items.Add(adsoyad+meslek+cinsiyet+yas);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
