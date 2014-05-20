namespace RSSFeed.Controles
{
    partial class AgregarRSS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarRSS));
            this.txt_rss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_limpiar_cb = new System.Windows.Forms.Button();
            this.cb_logico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_guardar = new System.Windows.Forms.Button();
            this.ayuda_url = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_url = new System.Windows.Forms.PictureBox();
            this.pic_clave = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pic_nombre = new System.Windows.Forms.PictureBox();
            this.ayuda_nombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_url)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rss
            // 
            this.txt_rss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rss.Location = new System.Drawing.Point(237, 156);
            this.txt_rss.Name = "txt_rss";
            this.txt_rss.Size = new System.Drawing.Size(730, 34);
            this.txt_rss.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(159, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            // 
            // cb_busqueda
            // 
            this.cb_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_busqueda.FormattingEnabled = true;
            this.cb_busqueda.Location = new System.Drawing.Point(238, 306);
            this.cb_busqueda.Name = "cb_busqueda";
            this.cb_busqueda.Size = new System.Drawing.Size(730, 37);
            this.cb_busqueda.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(1071, 306);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 37);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_limpiar_cb
            // 
            this.btn_limpiar_cb.Location = new System.Drawing.Point(1182, 307);
            this.btn_limpiar_cb.Name = "btn_limpiar_cb";
            this.btn_limpiar_cb.Size = new System.Drawing.Size(105, 37);
            this.btn_limpiar_cb.TabIndex = 3;
            this.btn_limpiar_cb.Text = "Limpiar";
            this.btn_limpiar_cb.UseVisualStyleBackColor = true;
            this.btn_limpiar_cb.Click += new System.EventHandler(this.btn_limpiar_cb_Click);
            // 
            // cb_logico
            // 
            this.cb_logico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_logico.FormattingEnabled = true;
            this.cb_logico.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cb_logico.Location = new System.Drawing.Point(974, 307);
            this.cb_logico.Name = "cb_logico";
            this.cb_logico.Size = new System.Drawing.Size(91, 37);
            this.cb_logico.TabIndex = 4;
            this.cb_logico.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(45, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palabras Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agregar/Modificar RSS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_regresar
            // 
            this.btn_regresar.ImageKey = "Redoicon.png";
            this.btn_regresar.ImageList = this.imageList1;
            this.btn_regresar.Location = new System.Drawing.Point(1117, 34);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(70, 70);
            this.btn_regresar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btn_regresar, "Regresar a la opción anterior");
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "returnicon.png");
            this.imageList1.Images.SetKeyName(1, "addicon.png");
            this.imageList1.Images.SetKeyName(2, "Redoicon.png");
            // 
            // btn_guardar
            // 
            this.btn_guardar.ImageKey = "addicon.png";
            this.btn_guardar.ImageList = this.imageList1;
            this.btn_guardar.Location = new System.Drawing.Point(1041, 34);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(70, 70);
            this.btn_guardar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btn_guardar, "Agregar RSS");
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // ayuda_url
            // 
            this.ayuda_url.AutoSize = true;
            this.ayuda_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ayuda_url.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ayuda_url.Location = new System.Drawing.Point(274, 202);
            this.ayuda_url.Name = "ayuda_url";
            this.ayuda_url.Size = new System.Drawing.Size(319, 20);
            this.ayuda_url.TabIndex = 16;
            this.ayuda_url.Text = "Introduzca la url del RSS del que se leera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(274, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Introduzca las palabras clave que se utilizaran para leer";
            // 
            // pic_url
            // 
            this.pic_url.Location = new System.Drawing.Point(238, 197);
            this.pic_url.Name = "pic_url";
            this.pic_url.Size = new System.Drawing.Size(30, 30);
            this.pic_url.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_url.TabIndex = 18;
            this.pic_url.TabStop = false;
            // 
            // pic_clave
            // 
            this.pic_clave.Location = new System.Drawing.Point(237, 349);
            this.pic_clave.Name = "pic_clave";
            this.pic_clave.Size = new System.Drawing.Size(30, 30);
            this.pic_clave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_clave.TabIndex = 19;
            this.pic_clave.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(192, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(775, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "A continuación, a complete los siguientes campos.  Los campos con el * son obliga" +
    "torios";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "addicon.png");
            this.imageList2.Images.SetKeyName(1, "wrongicon.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(140, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(89, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "*";
            // 
            // pic_nombre
            // 
            this.pic_nombre.Location = new System.Drawing.Point(238, 274);
            this.pic_nombre.Name = "pic_nombre";
            this.pic_nombre.Size = new System.Drawing.Size(30, 30);
            this.pic_nombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nombre.TabIndex = 25;
            this.pic_nombre.TabStop = false;
            // 
            // ayuda_nombre
            // 
            this.ayuda_nombre.AutoSize = true;
            this.ayuda_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ayuda_nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ayuda_nombre.Location = new System.Drawing.Point(274, 279);
            this.ayuda_nombre.Name = "ayuda_nombre";
            this.ayuda_nombre.Size = new System.Drawing.Size(266, 20);
            this.ayuda_nombre.TabIndex = 24;
            this.ayuda_nombre.Text = "Introduzca un nombre para el RSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label9.Location = new System.Drawing.Point(118, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(237, 233);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(730, 34);
            this.txt_nombre.TabIndex = 22;
            // 
            // AgregarRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pic_nombre);
            this.Controls.Add(this.ayuda_nombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pic_clave);
            this.Controls.Add(this.pic_url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ayuda_url);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_logico);
            this.Controls.Add(this.btn_limpiar_cb);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.cb_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rss);
            this.Name = "AgregarRSS";
            this.Size = new System.Drawing.Size(1300, 717);
            this.Load += new System.EventHandler(this.AgregarRSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_url)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_clave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_busqueda;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_limpiar_cb;
        private System.Windows.Forms.ComboBox cb_logico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label ayuda_url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_url;
        private System.Windows.Forms.PictureBox pic_clave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_nombre;
        private System.Windows.Forms.Label ayuda_nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombre;

    }
}
