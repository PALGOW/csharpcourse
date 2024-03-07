using System;
using System.Windows.Forms;

namespace AltinciUniteProje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(4, 3).ToString();
            label2.Text = toplam(5, 3).ToString();
            label3.Text = toplam(6, 3).ToString();
        }
        int carpim (int s1, int s2, int s3) 
        {
            int s4 = s1*s2*s3;
            return s4;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           label4.Text=carpim(4,3,2).ToString();
        }
    }
}
