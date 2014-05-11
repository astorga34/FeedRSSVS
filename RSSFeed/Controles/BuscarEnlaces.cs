using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSSFeed.Clases;

namespace RSSFeed.Controles
{
    public partial class BuscarEnlaces : UserControl
    {
        public BuscarEnlaces()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            var control = new Principal();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            FeedRSS lector = new FeedRSS(txt_rss.Text.Trim());
            List<entry> lista = new List<entry>();
            if (chk_buscar.Checked)
            {
                var cs = new List<string>();
                foreach (var ds in cb_busqueda.Items)
                {
                    cs.Add(ds.ToString());
                }
                bool andor = (cb_logico.SelectedItem.ToString().Trim() == "AND" ? true : false);
                lista = lector.getFeed(cs, andor);
            }
            else
            {
                lista = lector.getFeed();
            }

            //Bloque de codigo para verificar  si ocurrio un error interno en los metodos
            if (lector.Mensaje != null)
            {
                ListViewItem ax = new ListViewItem();
                ax.Text = lector.Mensaje.Source;
                listView1.Items.Add(ax);
            }
            else
            {
                //Se ejecuta este codigo en caso de no haber ocurrido algun error interno.
                listView1.Items.Clear();
                foreach (var entrada in lista)
                {
                    ListViewItem ax = new ListViewItem();
                    ax.Text = entrada.Name;
                    ax.SubItems.Add(entrada.Type);
                    ax.SubItems.Add(entrada.Url);
                    listView1.Items.Add(ax);
                }

                if (lista.Count == 0)
                {
                    ListViewItem ax = new ListViewItem();
                    ax.Text = "No se encontraron elementos con los criterios seleccionados...";
                    listView1.Items.Add(ax);
                }
            }


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cb_busqueda.Items.Add(cb_busqueda.Text.Trim());
            cb_busqueda.Text = "";
        }

        private void btn_limpiar_cb_Click(object sender, EventArgs e)
        {
            cb_busqueda.Items.Clear();
            cb_busqueda.Text = "";
        }
    }
}
