using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RSSFeed.Controles
{
    public partial class RSS : UserControl
    {
        public RSS()
        {
            InitializeComponent();
        }

        private void RSS_Load(object sender, EventArgs e)
        {
            Thread hilo1 = new Thread(new ThreadStart(cargar_datos));
            hilo1.Start();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            var control = new Principal();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var control = new AgregarRSS(-1);
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            var control = new AgregarRSS(-1);
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        public void cargar_datos()
        {
            var context = new DBEntities1();
            var objs = (from rss in context.RSS select rss);
            foreach (var obj in objs)
            {
                ListViewItem ax = new ListViewItem();
                ax.Text = obj.Nombre.Trim();
                ax.SubItems.Add(obj.Link.Trim());
                ax.SubItems.Add(obj.Palabras.Trim());
                listView1.Items.Add(ax);
            }
            box_loader.Visible = false;
        }
    }
}
