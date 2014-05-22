namespace RSSFeed.Controles
{
    partial class Recientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recientes));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cb_rss = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_marcar = new System.Windows.Forms.Button();
            this.dtg_enlaces = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_loader = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enlaces)).BeginInit();
            this.box_loader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enlaces recientes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_regresar
            // 
            this.btn_regresar.ImageKey = "Redoicon.png";
            this.btn_regresar.ImageList = this.imageList1;
            this.btn_regresar.Location = new System.Drawing.Point(1176, 29);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(70, 70);
            this.btn_regresar.TabIndex = 19;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exiticon.png");
            this.imageList1.Images.SetKeyName(1, "Redoicon.png");
            this.imageList1.Images.SetKeyName(2, "okicon.png");
            // 
            // cb_rss
            // 
            this.cb_rss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cb_rss.FormattingEnabled = true;
            this.cb_rss.Location = new System.Drawing.Point(192, 81);
            this.cb_rss.Name = "cb_rss";
            this.cb_rss.Size = new System.Drawing.Size(932, 37);
            this.cb_rss.TabIndex = 20;
            this.cb_rss.SelectedIndexChanged += new System.EventHandler(this.cb_rss_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(114, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "RSS";
            // 
            // btn_marcar
            // 
            this.btn_marcar.ImageKey = "okicon.png";
            this.btn_marcar.ImageList = this.imageList1;
            this.btn_marcar.Location = new System.Drawing.Point(1176, 114);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(70, 70);
            this.btn_marcar.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btn_marcar, "Marcar como leidos las entradas del rss seleccionado");
            this.btn_marcar.UseVisualStyleBackColor = true;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // dtg_enlaces
            // 
            this.dtg_enlaces.AllowUserToAddRows = false;
            this.dtg_enlaces.AllowUserToDeleteRows = false;
            this.dtg_enlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_enlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Link});
            this.dtg_enlaces.Location = new System.Drawing.Point(119, 138);
            this.dtg_enlaces.Name = "dtg_enlaces";
            this.dtg_enlaces.RowHeadersVisible = false;
            this.dtg_enlaces.RowTemplate.Height = 24;
            this.dtg_enlaces.Size = new System.Drawing.Size(1005, 529);
            this.dtg_enlaces.TabIndex = 22;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 400;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Width = 500;
            // 
            // box_loader
            // 
            this.box_loader.Controls.Add(this.label1);
            this.box_loader.Controls.Add(this.pictureBox1);
            this.box_loader.Location = new System.Drawing.Point(479, 200);
            this.box_loader.Name = "box_loader";
            this.box_loader.Size = new System.Drawing.Size(325, 248);
            this.box_loader.TabIndex = 23;
            this.box_loader.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargando datos, espere por favor...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Recientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_marcar);
            this.Controls.Add(this.box_loader);
            this.Controls.Add(this.dtg_enlaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_rss);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label3);
            this.Name = "Recientes";
            this.Size = new System.Drawing.Size(1300, 717);
            this.Load += new System.EventHandler(this.Recientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_enlaces)).EndInit();
            this.box_loader.ResumeLayout(false);
            this.box_loader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cb_rss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dtg_enlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Link;
        private System.Windows.Forms.GroupBox box_loader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_marcar;
    }
}
