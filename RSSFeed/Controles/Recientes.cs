using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RSSFeed.Controles
{
    public partial class Recientes : UserControl
    {
        List<RSSFeed.RSS> lista = new List<RSSFeed.RSS>();
        public Recientes()
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

        private void Recientes_Load(object sender, EventArgs e)
        {
            var hilo = new Thread(new ThreadStart(cargar_datos));
            hilo.Start();
        }

        private void cb_rss_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codigo para mostrar los enlaces del rss seleccionado.
            //dtg_enlaces.Rows.Clear();
            //var db = new DBEntities1();
            //var enlaces = (from enl in db.Enlaces where enl.Leido != true && enl.RSS == lista[cb_rss.SelectedIndex].ID select enl);
            //if (enlaces.Count() != 0)
            //{
            //    foreach (var enlace in enlaces)
            //    {
            //        dtg_enlaces.Rows.Add(enlace.Descripcion.Trim(), enlace.Link.Trim());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Actualmente el rss que selecciono, no tiene entradas sin leer", "Sin entradas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        public void cargar_datos()
        {
            try
            {
                var db = new DBEntities1();
                var rsss = (from rs in db.RSS select rs);
                cb_rss.Items.Clear();
                if (rsss.Count() != 0)
                {
                    lista = rsss.ToList();
                    foreach (var rs in lista)
                    {
                        cb_rss.Items.Add(rs.Nombre);
                    }
                }
                db.Dispose();
                box_loader.Hide();
            }
            catch (Exception f)
            {
                MessageBox.Show("Ocurrio un error.\n" + f.Message, "Error en la aplicación");
            }
        }

    }
}
