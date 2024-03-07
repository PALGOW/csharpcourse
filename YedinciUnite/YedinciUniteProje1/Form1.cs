using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YedinciUniteProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb=new Araba();
            rb.renk = "Mavi";
            rb.hiz = 200;
            rb.motor = 1200.45;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.plaka = "34 krf 33";
            rb.muayene = 2018;
            rb.sahip = "emir";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            pictureBox1.BackColor = Color.AliceBlue;

            label6.Text= rb.muayene.ToString();
            label7.Text = rb.sahip.ToString();
            label8.Text = rb.plaka.ToString();
        }
    }
}
