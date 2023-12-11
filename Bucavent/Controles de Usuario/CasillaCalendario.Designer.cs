namespace Bucavent.Controles_de_Usuario
{
    partial class CasillaCalendario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasillaCalendario));
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaExacta = new System.Windows.Forms.Label();
            this.imgEvento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(11, 28);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 73);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "0";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblFechaExacta
            // 
            this.lblFechaExacta.AutoSize = true;
            this.lblFechaExacta.Location = new System.Drawing.Point(21, 15);
            this.lblFechaExacta.Name = "lblFechaExacta";
            this.lblFechaExacta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaExacta.TabIndex = 1;
            this.lblFechaExacta.Text = "label1";
            this.lblFechaExacta.Visible = false;
            // 
            // imgEvento
            // 
            this.imgEvento.BackColor = System.Drawing.Color.Transparent;
            this.imgEvento.Image = ((System.Drawing.Image)(resources.GetObject("imgEvento.Image")));
            this.imgEvento.InitialImage = null;
            this.imgEvento.Location = new System.Drawing.Point(62, 15);
            this.imgEvento.Name = "imgEvento";
            this.imgEvento.Size = new System.Drawing.Size(30, 20);
            this.imgEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEvento.TabIndex = 2;
            this.imgEvento.TabStop = false;
            this.imgEvento.Visible = false;
            // 
            // CasillaCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.imgEvento);
            this.Controls.Add(this.lblFechaExacta);
            this.Controls.Add(this.lblFecha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CasillaCalendario";
            this.Size = new System.Drawing.Size(112, 122);
            this.Load += new System.EventHandler(this.CasillaCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaExacta;
        private System.Windows.Forms.PictureBox imgEvento;
    }
}
