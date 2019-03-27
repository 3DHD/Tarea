using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Divi ingreso4;
        Multi ingreso3;
        Resta ingreso2;
        Operaciones ingreso;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             ingreso = new Operaciones();
             ingreso.V1 = double.Parse(textBox1.Text);
             ingreso.V2 = double.Parse(textBox2.Text);
             label4.Text= ingreso.calcular().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingreso2 = new Resta();
            ingreso2.N1 = double.Parse(textBox1.Text);
            ingreso2.N2 = double.Parse(textBox2.Text);
            label4.Text = ingreso2.calcular().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingreso3 = new Multi();
            ingreso3.Valor1 = double.Parse(textBox1.Text);
            ingreso3.Valor2 = double.Parse(textBox2.Text);
            label4.Text = ingreso3.calcular().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ingreso4 = new Divi();
            ingreso4.Campo1 = double.Parse(textBox1.Text);
            ingreso4.Campo2 = double.Parse(textBox2.Text);
            label4.Text = ingreso4.calcular().ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
