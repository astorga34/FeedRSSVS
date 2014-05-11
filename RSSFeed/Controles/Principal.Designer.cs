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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rss = new System.Windows.Forms.Button();
            this.btn_recientes = new System.Windows.Forms.Button();
            this.btn_enlaces = new System.Windows.Forms.Button();
            this.btn_configuracion = new System.Windows.Forms.Button();
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
            this.btn_rss.Location = new System.Drawing.Point(417, 168);
            this.btn_rss.Name = "btn_rss";
            this.btn_rss.Size = new System.Drawing.Size(104, 97);
            this.btn_rss.TabIndex = 1;
            this.btn_rss.Text = "Ver RSSs";
            this.btn_rss.UseVisualStyleBackColor = true;
            this.btn_rss.Click += new System.EventHandler(this.btn_rss_Click);
            // 
            // btn_recientes
            // 
            this.btn_recientes.Location = new System.Drawing.Point(538, 168);
            this.btn_recientes.Name = "btn_recientes";
            this.btn_recientes.Size = new System.Drawing.Size(104, 97);
            this.btn_recientes.TabIndex = 2;
            this.btn_recientes.Text = "Ver enlaces recientes";
            this.btn_recientes.UseVisualStyleBackColor = true;
            // 
            // btn_enlaces
            // 
            this.btn_enlaces.Location = new System.Drawing.Point(659, 168);
            this.btn_enlaces.Name = "btn_enlaces";
            this.btn_enlaces.Size = new System.Drawing.Size(104, 97);
            this.btn_enlaces.TabIndex = 3;
            this.btn_enlaces.Text = "Buscar Enlaces";
            this.btn_enlaces.UseVisualStyleBackColor = true;
            this.btn_enlaces.Click += new System.EventHandler(this.btn_enlaces_Click);
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.Location = new System.Drawing.Point(780, 168);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(104, 97);
            this.btn_configuracion.TabIndex = 4;
            this.btn_configuracion.Text = "Configuración";
            this.btn_configuracion.UseVisualStyleBackColor = true;
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
    }
}
