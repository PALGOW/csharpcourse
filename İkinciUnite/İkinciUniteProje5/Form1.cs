namespace Proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Güzergah: " + comboBox1.Text + " - " + comboBox2.Text + " Gün: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri: " + textBox1.Text + " Yolcu TC: " + maskedTextBox2.Text + " Yolcu Telefon No: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydi Yapilmistir.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text; 
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text =label9.Text ;
        }
    }
}
