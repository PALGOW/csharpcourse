﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YedinciUniteProje7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Kitap1"].Points.AddXY("Akdeniz", 5);
            chart1.Series["Kitap1"].Points.AddXY("Ege", 4);
            chart1.Series["Kitap1"].Points.AddXY("Karadeniz", 3);

        }
    }
}
