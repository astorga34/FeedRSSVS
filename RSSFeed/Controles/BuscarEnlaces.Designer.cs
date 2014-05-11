namespace RSSFeed.Controles
{
    partial class BuscarEnlaces
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_logico = new System.Windows.Forms.ComboBox();
            this.btn_limpiar_cb = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cb_busqueda = new System.Windows.Forms.ComboBox();
            this.chk_buscar = new System.Windows.Forms.CheckBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rss = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Enlaces";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_logico);
            this.groupBox1.Controls.Add(this.btn_limpiar_cb);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.cb_busqueda);
            this.groupBox1.Controls.Add(this.chk_buscar);
            this.groupBox1.Location = new System.Drawing.Point(20, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1246, 107);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // cb_logico
            // 
            this.cb_logico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_logico.FormattingEnabled = true;
            this.cb_logico.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cb_logico.Location = new System.Drawing.Point(866, 37);
            this.cb_logico.Name = "cb_logico";
            this.cb_logico.Size = new System.Drawing.Size(91, 37);
            this.cb_logico.TabIndex = 4;
            this.cb_logico.Text = "OR";
            // 
            // btn_limpiar_cb
            // 
            this.btn_limpiar_cb.Location = new System.Drawing.Point(1077, 38);
            this.btn_limpiar_cb.Name = "btn_limpiar_cb";
            this.btn_limpiar_cb.Size = new System.Drawing.Size(89, 37);
            this.btn_limpiar_cb.TabIndex = 3;
            this.btn_limpiar_cb.Text = "Limpiar";
            this.btn_limpiar_cb.UseVisualStyleBackColor = true;
            this.btn_limpiar_cb.Click += new System.EventHandler(this.btn_limpiar_cb_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(977, 37);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(89, 37);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cb_busqueda
            // 
            this.cb_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_busqueda.FormattingEnabled = true;
            this.cb_busqueda.Location = new System.Drawing.Point(121, 37);
            this.cb_busqueda.Name = "cb_busqueda";
            this.cb_busqueda.Size = new System.Drawing.Size(730, 37);
            this.cb_busqueda.TabIndex = 1;
            // 
            // chk_buscar
            // 
            this.chk_buscar.AutoSize = true;
            this.chk_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.chk_buscar.Location = new System.Drawing.Point(6, 37);
            this.chk_buscar.Name = "chk_buscar";
            this.chk_buscar.Size = new System.Drawing.Size(109, 33);
            this.chk_buscar.TabIndex = 0;
            this.chk_buscar.Text = "Buscar";
            this.chk_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(1108, 137);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(89, 37);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(1016, 137);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(89, 37);
            this.btn_leer.TabIndex = 16;
            this.btn_leer.Text = "Leer";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Type,
            this.URL});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(20, 290);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1246, 386);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 630;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 236;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 481;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(56, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "URL";
            // 
            // txt_rss
            // 
            this.txt_rss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rss.Location = new System.Drawing.Point(141, 137);
            this.txt_rss.Name = "txt_rss";
            this.txt_rss.Size = new System.Drawing.Size(867, 34);
            this.txt_rss.TabIndex = 13;
            this.txt_rss.Text = "http://www.nyaa.se/?page=rss&offset=1";
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(1162, 19);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(104, 97);
            this.btn_regresar.TabIndex = 19;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // BuscarEnlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rss);
            this.Controls.Add(this.label1);
            this.Name = "BuscarEnlaces";
            this.Size = new System.Drawing.Size(1300, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_logico;
        private System.Windows.Forms.Button btn_limpiar_cb;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cb_busqueda;
        private System.Windows.Forms.CheckBox chk_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rss;
        private System.Windows.Forms.Button btn_regresar;
    }
}
