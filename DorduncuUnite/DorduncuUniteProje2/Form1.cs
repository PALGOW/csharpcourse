namespace DorduncuUniteIkinciProje
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
            double sinav1, sinav2, proje, ort;
            string durum;

            sinav1=Convert.ToDouble(this.textBox1.Text);
            sinav2=Convert.ToDouble(this.textBox2.Text);
            proje=Convert.ToDouble(this.textBox3.Text);

            ort = (sinav1 + sinav2 + proje) / 3;

            if (ort >= 50) 
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Geçemedi";
            }
            textBox4.Text = ort.ToString("0.00") + " / " +durum;
        }
    }
}
