﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miAplicacion
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gfarenheit, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gfarenheit = ct1 * 1.8 + 32.0;
            textBox2.Text = gfarenheit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gcentigrados, ct1;
            ct1 = Convert.ToDouble(textBox1.Text);
            gcentigrados = (ct1 - 32.0) / 1.8;
            textBox2.Text = gcentigrados.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
