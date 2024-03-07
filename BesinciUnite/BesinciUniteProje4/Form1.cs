using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BesinciUniteProje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(textBox1.Text);
            int f = 1;
            for (int i = 1; i <= sayi; i++)
            {
                f = f * i;

            }
           listBox1.Items.Add(f);
            
            
            
            
            
            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i%5== 0 && i%7==0)

                {
                    listBox1.Items.Add(i);
                }
            }*/
        }
    }
}
