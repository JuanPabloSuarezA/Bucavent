namespace Bucavent
{
    partial class FormCalendario
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mesIzquierda = new System.Windows.Forms.Button();
            this.mesDerecha = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.comboAnio = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitulo.Location = new System.Drawing.Point(246, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 41);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Calendario de eventos";
            // 
            // mesIzquierda
            // 
            this.mesIzquierda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesIzquierda.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.mesIzquierda.Location = new System.Drawing.Point(281, 59);
            this.mesIzquierda.Margin = new System.Windows.Forms.Padding(2);
            this.mesIzquierda.Name = "mesIzquierda";
            this.mesIzquierda.Size = new System.Drawing.Size(28, 33);
            this.mesIzquierda.TabIndex = 2;
            this.mesIzquierda.Text = "◄";
            this.mesIzquierda.UseVisualStyleBackColor = true;
            this.mesIzquierda.Click += new System.EventHandler(this.mesIzquierda_Click);
            // 
            // mesDerecha
            // 
            this.mesDerecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mesDerecha.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.mesDerecha.Location = new System.Drawing.Point(495, 59);
            this.mesDerecha.Margin = new System.Windows.Forms.Padding(2);
            this.mesDerecha.Name = "mesDerecha";
            this.mesDerecha.Size = new System.Drawing.Size(28, 33);
            this.mesDerecha.TabIndex = 3;
            this.mesDerecha.Text = "►";
            this.mesDerecha.UseVisualStyleBackColor = true;
            this.mesDerecha.Click += new System.EventHandler(this.mesDerecha_Click);
            // 
            // txtMes
            // 
            this.txtMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMes.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMes.Location = new System.Drawing.Point(336, 59);
            this.txtMes.Margin = new System.Windows.Forms.Padding(2);
            this.txtMes.Multiline = true;
            this.txtMes.Name = "txtMes";
            this.txtMes.ReadOnly = true;
            this.txtMes.Size = new System.Drawing.Size(132, 33);
            this.txtMes.TabIndex = 4;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(601, 59);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 33);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // comboAnio
            // 
            this.comboAnio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnio.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAnio.FormattingEnabled = true;
            this.comboAnio.Location = new System.Drawing.Point(137, 64);
            this.comboAnio.Name = "comboAnio";
            this.comboAnio.Size = new System.Drawing.Size(86, 25);
            this.comboAnio.TabIndex = 6;
            this.comboAnio.SelectedIndexChanged += new System.EventHandler(this.comboAnio_SelectedIndexChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(89, 67);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(42, 17);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "Año:";
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(786, 385);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.comboAnio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.mesDerecha);
            this.Controls.Add(this.mesIzquierda);
            this.Controls.Add(this.lblTitulo);
            this.Location = new System.Drawing.Point(150, 40);
            this.Name = "FormCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calendario de eventos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCalendario_FormClosed);
            this.Load += new System.EventHandler(this.FormCalendario_Load);
            this.LocationChanged += new System.EventHandler(this.FormCalendario_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.FormCalendario_SizeChanged);
            this.Resize += new System.EventHandler(this.FormCalendario_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button mesIzquierda;
        private System.Windows.Forms.Button mesDerecha;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox comboAnio;
        private System.Windows.Forms.Label lblAnio;
    }
}

