namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Antalya");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mekatronik M�hendisi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox3.Text + " " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text);
        }
    }
}
