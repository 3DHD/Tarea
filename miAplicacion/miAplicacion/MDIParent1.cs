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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = System.Drawing.Color.LightSkyBlue;
                    //  ctlMDI.BackgroundImage = Properties.Resources.Culture;
                   // menuStrip2.Enabled = true;

                }
                catch (InvalidCastException )
                {

                    //catch and ignore the error if casting failed
                }

            }
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hijo = new Form1();
            hijo.MdiParent = this;
            hijo.Show();

        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 hijo2 = new Form2();
            hijo2.MdiParent = this;
            hijo2.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijo3 = new Form3();
            hijo3.MdiParent = this;
            hijo3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 hijo4 = new Form4();
            hijo4.MdiParent = this;
            hijo4.Show();
        }

        private void ejercicio41ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4_1 hijo4_1 = new Form4_1();
            hijo4_1.MdiParent = this;
            hijo4_1.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 hijo6 = new Form6();
            hijo6.MdiParent = this;
            hijo6.Show();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 hijo7 = new Form7();
            hijo7.MdiParent = this;
            hijo7.Show();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 hijo8 = new Form8();
            hijo8.MdiParent = this;
            hijo8.Show();
        }
    }
}
