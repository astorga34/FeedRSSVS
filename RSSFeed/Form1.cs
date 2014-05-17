using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSSFeed.Clases;
using RSSFeed.Controles;

namespace RSSFeed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //this.Hide();
            var control = new Principal();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(control);
            this.toolstripSize.Text = this.Size.Width + "x" + this.Size.Height;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {  
            /*
            Bloque de codigo para esconder la ventana principal cuando se minimiza
            */
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
            this.toolstripSize.Text = this.Size.Width + "x" + this.Size.Height;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            Bloque de codigo para mostrar la aplicación despues de estar minimizada.
            */
            this.Show();
            this.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bloque de codigo que se va a estar ejecutando cada cierto tiempo.
            
        }
    }
}
