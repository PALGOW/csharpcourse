using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltinciUniteProje4
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
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void renklendir ()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.Gold;
            textBox4.BackColor = Color.Beige;

        }
        void yazi()
        {
            textBox1.Text = "emir";
            textBox2.Text = "sinan";
            textBox3.Text = "23";
            textBox4.Text = "mühendis";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir ();
            yazi();
        }
    }
}
