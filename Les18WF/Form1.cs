﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les18WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Value: {trackBar1.Value}";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = $"Value: {trackBar1.Value}";
        }
    }
}
