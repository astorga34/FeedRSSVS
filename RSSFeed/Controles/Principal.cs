using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSFeed.Controles
{
    public partial class Principal : UserControl
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_rss_Click(object sender, EventArgs e)
        {
            var control = new RSS();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_enlaces_Click(object sender, EventArgs e)
        {
            var control = new BuscarEnlaces();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_recientes_Click(object sender, EventArgs e)
        {
            var control = new Recientes();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            var control = new Configuracion();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.Close();
        }
    }
}
