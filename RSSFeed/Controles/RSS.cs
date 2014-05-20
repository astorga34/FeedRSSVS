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
            
            if (listView1.SelectedIndices.Count != 0)
            {
                if (listView1.SelectedIndices.Count == 1)
                {
                    int id = (int)listView1.SelectedItems[0].Tag;
                    var control = new AgregarRSS(id);
                    Form1 form = (Form1)Application.OpenForms["Form1"];
                    form.panel1.Controls.Clear();
                    form.panel1.Controls.Add(control);
                }
                else
                    MessageBox.Show("No debe elegir mas de una opción. Es sólo una, por favor.", "Error en la elección");
            }
            else
                    MessageBox.Show("Debe seleccionar un sólo elemento, por favor.","Error en la elección");

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0)
            {
                try
                {
                    var context = new DBEntities1();
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        var indice = item.Tag;

                        var obj = context.RSS.Find(indice);
                        context.RSS.Attach(obj);
                        var entry = context.Entry(obj);
                        entry.State = System.Data.Entity.EntityState.Deleted;
                    }
                    context.SaveChanges();
                    context.Dispose();
                    MessageBox.Show("Los elementos seleccionados han sido eliminados.", "Error en la elección");

                    RSS control = new RSS();
                    Form1 form = (Form1)Application.OpenForms["Form1"];
                    form.panel1.Controls.Clear();
                    form.panel1.Controls.Add(control);
                }
                catch (Exception f)
                {
                    MessageBox.Show("Ocurrio un error.\n" + f.Message, "Error en la aplicación");
                }

                
            }
            else
                MessageBox.Show("Debe seleccionar un sólo elemento, por favor.", "Error en la elección");
        }

        public void cargar_datos()
        {
            var context = new DBEntities1();
            var objs = (from rss in context.RSS select rss);
            foreach (var obj in objs)
            {
                ListViewItem ax = new ListViewItem();
                ax.Tag = obj.ID;
                ax.Text = obj.Nombre.Trim();
                ax.SubItems.Add(obj.Link.Trim());
                ax.SubItems.Add(obj.Palabras.Trim());
                listView1.Items.Add(ax);
            }
            box_loader.Visible = false;
            context.Dispose();
        }


    }
}
