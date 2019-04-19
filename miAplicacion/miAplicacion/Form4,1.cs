using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace miAplicacion
{
    public partial class Form4_1 : Form
    {
        private int tiempo;
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MONITORPOWER = 0xF170;
        [DllImport("user32.dll")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam,int lparam);
        [DllImport("winmm")]
        public static extern void mciSendString(string lpstrCommand, string lpstrRetunrString, int uReturnLength, int hwndCallback); 
        public Form4_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApagarMonitor();
        }

        private void Form4_1_Load(object sender, EventArgs e)
        {

        }
        private void ApagarMonitor()
        {
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, 2);
            //el 2 es para apagar
        }
        private void EncenderMonitor()
        {
            SendMessage(this.Handle,WM_SYSCOMMAND, SC_MONITORPOWER, -1);
            //el -1 es para encender
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tiempo = 5;
            ApagarMonitor();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tiempo != 0)
            {
                tiempo--;
            }
            else
            {
                timer1.Stop();
                EncenderMonitor();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door open ", "",127,0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mciSendString("set CDAudio door close", "",127,0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
