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
            this.txt_rss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_busqueda = new System.Windows.Forms.ComboBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_limpiar_cb = new System.Windows.Forms.Button();
            this.cb_logico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_rss
            // 
            this.txt_rss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rss.Location = new System.Drawing.Point(237, 170);
            this.txt_rss.Name = "txt_rss";
            this.txt_rss.Size = new System.Drawing.Size(730, 34);
            this.txt_rss.TabIndex = 7;
            this.txt_rss.Text = "http://www.nyaa.se/?page=rss&offset=1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(159, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "URL";
            // 
            // cb_busqueda
            // 
            this.cb_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_busqueda.FormattingEnabled = true;
            this.cb_busqueda.Location = new System.Drawing.Point(237, 235);
            this.cb_busqueda.Name = "cb_busqueda";
            this.cb_busqueda.Size = new System.Drawing.Size(730, 37);
            this.cb_busqueda.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(1070, 235);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 37);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar_cb
            // 
            this.btn_limpiar_cb.Location = new System.Drawing.Point(1181, 236);
            this.btn_limpiar_cb.Name = "btn_limpiar_cb";
            this.btn_limpiar_cb.Size = new System.Drawing.Size(105, 37);
            this.btn_limpiar_cb.TabIndex = 3;
            this.btn_limpiar_cb.Text = "Limpiar";
            this.btn_limpiar_cb.UseVisualStyleBackColor = true;
            // 
            // cb_logico
            // 
            this.cb_logico.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_logico.FormattingEnabled = true;
            this.cb_logico.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cb_logico.Location = new System.Drawing.Point(973, 236);
            this.cb_logico.Name = "cb_logico";
            this.cb_logico.Size = new System.Drawing.Size(91, 37);
            this.cb_logico.TabIndex = 4;
            this.cb_logico.Text = "OR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(44, 238);
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
            this.btn_regresar.Location = new System.Drawing.Point(1151, 34);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(104, 97);
            this.btn_regresar.TabIndex = 15;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(1041, 34);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 97);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // AgregarRSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

    }
}
