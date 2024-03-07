using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltinciUniteProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string[] kisiler = { "ali", "mehmet", "alp", "elif" };
            label1.Text = kisiler[0];*/

            /*int[] sayilar = { 1, 2, 3, 4 };
            label1.Text = sayilar [3].ToString();*/

            /*double[] ondalik = { 0.01, 0.02, 0.03 };
            label1.Text = ondalik[0].ToString();*/

            char[] harfler = { 'A', 'n', 'c' };
            label1.Text = harfler[0].ToString();

        }
    }
}
