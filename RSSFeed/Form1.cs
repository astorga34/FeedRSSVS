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
            //Extras.existe_db();
            var control = new Principal();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(control);
            this.toolstripSize.Text = this.Size.Width + "x" + this.Size.Height;

            var db = new DBEntities1();
            var query2 = (from obj in db.Enlaces where obj.Leido == false select obj);
            this.toolstrip_rss.Text = string.Format("{0} entrada(s) sin leer.", query2.Count());
            db.Dispose();
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
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            Bloque de codigo para mostrar la aplicación despues de estar minimizada.
            */
            this.Show();
            this.Focus();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //Codigo para mostrar la pantalla en donde estan las nuevas entradas.
            this.Show();
            this.Focus();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            Recientes control = new Recientes();
            form.panel1.Controls.Add(control);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bloque de codigo que se va a estar ejecutando cada cierto tiempo.
            try
            {
                //Se hace la consulta de los entries de los rss.
                var db = new DBEntities1();
                var objs = (from obj in db.RSS select obj);
                foreach (var obj in objs)
                {
                    FeedRSS aux = new FeedRSS(obj.Link.Trim());
                    List<entry> enlaces;
                    if (obj.Palabras.Length != 0)
                    {
                        enlaces = aux.getFeed(obj.Palabras.Split(',').ToList(),obj.Operador);
                    }
                    else
                    {
                        enlaces = aux.getFeed();
                    }

                    //Se procede a guardar los nuevos rss
                    foreach (var enlace in enlaces)
                    {
                        //Ver si ya existen un id
                        var query = (from enl in db.Enlaces where enl.Link == enlace.Url && enl.RSS == obj.ID select enl);
                        if (query.Count() == 0)
                        {
                            Enlaces nuevo = new Enlaces();
                            nuevo.Link = enlace.Url;
                            nuevo.Descripcion = enlace.Name;
                            nuevo.Categoria = enlace.Type;
                            nuevo.RSS = obj.ID;
                            nuevo.Fecha = DateTime.Now;
                            nuevo.Leido = false;
                            db.Enlaces.Add(nuevo);
                        }
                    }
                    
                }
                if (db.Enlaces.Local.Count != 0)
                {
                    db.SaveChanges();
                    notifyIcon1.ShowBalloonTip(20000, "Nuevas entradas de rss",
                        string.Format("Se han encontrado {0} nuevas entradas de los rss que se tienen en la base de datos. Haga clic aqui para ir a verles.", db.Enlaces.Local.Count),
                        ToolTipIcon.Info);
                    
                }
                var query2 = (from obj in db.Enlaces where obj.Leido ==false select obj);
                this.toolstrip_rss.Text = string.Format("{0} entrada(s) sin leer.",query2.Count());
                this.notifyIcon1.Text = string.Format("{0} entrada(s) sin leer.", query2.Count());
                this.toolIntento.Text = string.Format("Ultimo intento de lectura de entradas de RSS hecha a las {0}.",
                DateTime.Now.ToString("dd-MM-yyyy hh:mm"));            
                db.Dispose();
            }
            catch (Exception f)
            {
                MessageBox.Show("Ocurrio un error.\n" + f.Message,"Error en la aplicación");
            }
        }


    }
}
