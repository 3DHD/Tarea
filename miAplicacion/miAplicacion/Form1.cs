using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, suma;
            n1 = int.Parse(txtNumero1.Text);
            n2 = int.Parse(txtNumero2.Text);
            suma = n1 + n2;
            txtResultado.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Application.Exit();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          /*  txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";*/

            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

    }
}
