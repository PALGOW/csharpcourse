using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltinciUniteProje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 2, 3,4,5,6,7,10,12,45,323,77,36,44 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i]>10)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }












            /*string[] sehirler = { "ankara", "eskisehir", "antalya", "adana" };
            for (int i = 0;i< sehirler.Length; i++)
            {
                listBox1.Items.Add(sehirler[i]);
            }*/

        } 
    }
}
