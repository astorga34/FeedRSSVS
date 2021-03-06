﻿using System;
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
    public partial class AgregarRSS : UserControl
    {
        private RSSFeed.RSS obj;
        private int id = -1;
        public AgregarRSS(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AgregarRSS_Load(object sender, EventArgs e)
        {
            var context = new DBEntities1();
            var query = (from rs in context.RSS where rs.ID == id select rs);
            if (query.Count() != 0)
            {
                obj = query.ToList()[0];
                txt_rss.Text = obj.Link.Trim();
                txt_nombre.Text = obj.Nombre.Trim();
                var palabras = obj.Palabras.Split(',');
                cb_busqueda.Items.Clear();
                foreach (var palabra in palabras)
                {
                    cb_busqueda.Items.Add(palabra);
                }

                if (obj.Operador)
                {
                    cb_logico.SelectedIndex = 0;
                }
                else
                {
                    cb_logico.SelectedIndex = 1;
                }
            }
            else
            {
                txt_nombre.Text.Trim();
                txt_rss.Text.Trim();
                cb_busqueda.Items.Clear();
            }


            context.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Boton para guardar
            var rss = validar_rss();
            var nombre = validar_nombre();
            if (rss && nombre)
            {
                try
                {
                    var cs = new List<string>();
                    foreach (var ds in cb_busqueda.Items)
                    {
                        cs.Add(ds.ToString());
                    }
                    var context = new DBEntities1();
                    

                    //obj.ID = context.RSS.Max(f => f.ID) + 1;
                    if(id != -1)
                    {
                        obj.Link = txt_rss.Text.Trim();
                        obj.Nombre = txt_nombre.Text.Trim();
                        obj.Operador = (cb_logico.SelectedItem.ToString().Trim() == "AND" ? true : false);
                        obj.Palabras = string.Join(",", cs);
                        context.RSS.Attach(obj);
                        var entry = context.Entry(obj);
                        entry.State = System.Data.Entity.EntityState.Modified;

                        context.SaveChanges();
                        MessageBox.Show("El registro se actualizó de manera exitosa.", "Guardado exitoso.");
                    }
                    else
                    {
                        RSSFeed.RSS obj2 = new RSSFeed.RSS();
                        obj2.Link = txt_rss.Text.Trim();
                        obj2.Nombre = txt_nombre.Text.Trim();
                        obj2.Operador = (cb_logico.SelectedItem.ToString().Trim() == "AND" ? true : false);
                        obj2.Palabras = string.Join(",", cs);
                        context.RSS.Add(obj2);
                        context.SaveChanges();
                        MessageBox.Show("El registro se guardó de manera exitosa.", "Guardado exitoso.");
                    }

                    context.Dispose();
                    btn_regresar_Click(null,null);
                }
                catch (Exception f)
                {
                    MessageBox.Show("Ocurrio un error.\n" + f.Message,"Error en la aplicación");
                }

            }
            else 
            {
                MessageBox.Show("Revise que todos los campos obligatorios hayan sido proporcionados.");
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            var control = new RSS();
            Form1 form = (Form1)Application.OpenForms["Form1"];
            form.panel1.Controls.Clear();
            form.panel1.Controls.Add(control);
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

        //Metodos para validar
        public bool validar_rss()
        {
            string valor = txt_rss.Text.Trim();
            if (valor != "")
            {
                ayuda_url.ForeColor = Color.DarkGreen;
                ayuda_url.Text = "Campo correcto.";
                return true;
            }
            else
            {
                ayuda_url.ForeColor = Color.Red;
                ayuda_url.Text = "El campo de enlace es obligatorio. Favor de proporcionarlo.";
                return false;

            }
        }

        //Metodos para validar
        public bool validar_nombre()
        {
            string valor = txt_nombre.Text.Trim();
            if (valor != "")
            {
                ayuda_nombre.ForeColor = Color.DarkGreen;
                ayuda_nombre.Text = "Campo correcto.";
                return true;
            }
            else
            {
                ayuda_nombre.ForeColor = Color.Red;
                ayuda_nombre.Text = "El campo de nombre es obligatorio. Favor de proporcionarlo.";
                return false;

            }
        }

    }
}
