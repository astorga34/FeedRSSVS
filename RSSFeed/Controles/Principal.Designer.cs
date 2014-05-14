namespace RSSFeed.Controles
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rss = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_recientes = new System.Windows.Forms.Button();
            this.btn_enlaces = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pantalla Principal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rss
            // 
            this.btn_rss.ImageKey = "RSS.png";
            this.btn_rss.ImageList = this.imageList1;
            this.btn_rss.Location = new System.Drawing.Point(440, 168);
            this.btn_rss.Name = "btn_rss";
            this.btn_rss.Size = new System.Drawing.Size(70, 70);
            this.btn_rss.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_rss, "Ir a catalogo de RSS");
            this.btn_rss.UseVisualStyleBackColor = true;
            this.btn_rss.Click += new System.EventHandler(this.btn_rss_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "RSS.png");
            this.imageList1.Images.SetKeyName(1, "linkreciente.png");
            this.imageList1.Images.SetKeyName(2, "search.png");
            this.imageList1.Images.SetKeyName(3, "engine.png");
            // 
            // btn_recientes
            // 
            this.btn_recientes.ImageKey = "linkreciente.png";
            this.btn_recientes.ImageList = this.imageList1;
            this.btn_recientes.Location = new System.Drawing.Point(546, 168);
            this.btn_recientes.Name = "btn_recientes";
            this.btn_recientes.Size = new System.Drawing.Size(70, 70);
            this.btn_recientes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_recientes, "Ver enlaces recientes");
            this.btn_recientes.UseVisualStyleBackColor = true;
            this.btn_recientes.Click += new System.EventHandler(this.btn_recientes_Click);
            // 
            // btn_enlaces
            // 
            this.btn_enlaces.ImageKey = "search.png";
            this.btn_enlaces.ImageList = this.imageList1;
            this.btn_enlaces.Location = new System.Drawing.Point(652, 168);
            this.btn_enlaces.Name = "btn_enlaces";
            this.btn_enlaces.Size = new System.Drawing.Size(70, 70);
            this.btn_enlaces.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btn_enlaces, "Buscar enlaces");
            this.btn_enlaces.UseVisualStyleBackColor = true;
            this.btn_enlaces.Click += new System.EventHandler(this.btn_enlaces_Click);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.ImageKey = "engine.png";
            this.btn_configuracion.ImageList = this.imageList1;
            this.btn_configuracion.Location = new System.Drawing.Point(758, 168);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(70, 70);
            this.btn_configuracion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_configuracion, "Ir a Configuración");
            this.btn_configuracion.UseVisualStyleBackColor = true;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_configuracion);
            this.Controls.Add(this.btn_enlaces);
            this.Controls.Add(this.btn_recientes);
            this.Controls.Add(this.btn_rss);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Size = new System.Drawing.Size(1300, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rss;
        private System.Windows.Forms.Button btn_recientes;
        private System.Windows.Forms.Button btn_enlaces;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
