using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltinciUniteProje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int toplam =0;
            int[] sinavlar = { 70, 75, 80, 85, 90, 100 };
            foreach (int i in sinavlar)
            {
                listBox1.Items.Add(i);
                toplam = toplam + i;
                
            }
            label1.Text=toplam.ToString();

            int ortalama = toplam / sinavlar.Length;
            label2.Text=ortalama.ToString();*/
            int toplam = 0;
            int adet = 0;
            int[] sayilar = { 70, 75, 80, 85, 90, 100,160 };
            foreach (int i in sayilar) 
            { 
                if (i%4== 0) 
                {
                    listBox1.Items.Add(i);
                    adet++;
                    toplam = i+ toplam;
                    
                }
                label1.Text = adet.ToString();
                label2.Text = toplam.ToString();
            }








            /* string[] kisiler = { "ahmet", "mehmet", "ali", "sevge", "manas" };
            foreach (string s in kisiler)
            {
                listBox1.Items.Add(s);
            }*/
        }
    }
}
