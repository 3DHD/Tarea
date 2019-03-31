using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        double N1, N2, Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            Resultado = N1 + N2;

            label3.Text = "El resultado : " + Resultado.ToString();
           // MessageBox.Show("El resutado de la Suma es : " + Resultado);
            
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            Resultado = N1 - N2;

            label3.Text = "El resultado : " + Resultado.ToString();
           // MessageBox.Show("El resultado de la Resta es : "+ Resultado);

            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            Resultado = N1 * N2;

            label3.Text = "El resultado : " + Resultado.ToString();
          //  MessageBox.Show("El resultado de la Multiplicacion es : "+ Resultado);

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            N1 = double.Parse(textBox1.Text);
            N2 = double.Parse(textBox2.Text);
            Resultado = N1 / N2;

            label3.Text = "El resultado : " + Resultado.ToString();
          //  MessageBox.Show("El resultado de la Division es : "+ Resultado);

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
