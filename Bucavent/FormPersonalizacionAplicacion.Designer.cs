namespace Bucavent
{
    partial class FormPersonalizar
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
            this.lblPersonalizacion = new System.Windows.Forms.Label();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.comboLetra = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblColorFondo = new System.Windows.Forms.Label();
            this.btnCambios = new System.Windows.Forms.Button();
            this.comboFondo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPersonalizacion
            // 
            this.lblPersonalizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonalizacion.AutoSize = true;
            this.lblPersonalizacion.Font = new System.Drawing.Font("Script MT Bold", 30F);
            this.lblPersonalizacion.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblPersonalizacion.Location = new System.Drawing.Point(52, 38);
            this.lblPersonalizacion.Name = "lblPersonalizacion";
            this.lblPersonalizacion.Size = new System.Drawing.Size(458, 48);
            this.lblPersonalizacion.TabIndex = 0;
            this.lblPersonalizacion.Text = "Personalización de interfaz";
            // 
            // comboColor
            // 
            this.comboColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColor.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(240, 137);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(279, 26);
            this.comboColor.TabIndex = 1;
            this.comboColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboColor_DrawItem);
            // 
            // comboLetra
            // 
            this.comboLetra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboLetra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLetra.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLetra.FormattingEnabled = true;
            this.comboLetra.Location = new System.Drawing.Point(240, 196);
            this.comboLetra.Name = "comboLetra";
            this.comboLetra.Size = new System.Drawing.Size(279, 26);
            this.comboLetra.TabIndex = 2;
            this.comboLetra.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboLetra_DrawItem);
            this.comboLetra.SelectedIndexChanged += new System.EventHandler(this.comboLetra_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(57, 140);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(167, 17);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Cambiar color de letra:";
            // 
            // lblLetra
            // 
            this.lblLetra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLetra.AutoSize = true;
            this.lblLetra.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.Location = new System.Drawing.Point(63, 199);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(161, 17);
            this.lblLetra.TabIndex = 4;
            this.lblLetra.Text = "Cambiar tipo de letra:";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(289, 345);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(168, 42);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblColorFondo
            // 
            this.lblColorFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColorFondo.AutoSize = true;
            this.lblColorFondo.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorFondo.Location = new System.Drawing.Point(51, 264);
            this.lblColorFondo.Name = "lblColorFondo";
            this.lblColorFondo.Size = new System.Drawing.Size(173, 17);
            this.lblColorFondo.TabIndex = 8;
            this.lblColorFondo.Text = "Cambiar color de fondo:";
            // 
            // btnCambios
            // 
            this.btnCambios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCambios.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.Location = new System.Drawing.Point(89, 345);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(168, 42);
            this.btnCambios.TabIndex = 9;
            this.btnCambios.Text = "Aplicar cambios";
            this.btnCambios.UseVisualStyleBackColor = true;
            this.btnCambios.Click += new System.EventHandler(this.btnCambios_Click);
            // 
            // comboFondo
            // 
            this.comboFondo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboFondo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboFondo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFondo.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFondo.FormattingEnabled = true;
            this.comboFondo.Location = new System.Drawing.Point(240, 261);
            this.comboFondo.Name = "comboFondo";
            this.comboFondo.Size = new System.Drawing.Size(279, 26);
            this.comboFondo.TabIndex = 10;
            this.comboFondo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboFondo_DrawItem);
            // 
            // FormPersonalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(555, 432);
            this.Controls.Add(this.comboFondo);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.lblColorFondo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.comboLetra);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.lblPersonalizacion);
            this.Name = "FormPersonalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalización de interfaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonalizar_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonalizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonalizacion;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.ComboBox comboLetra;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblColorFondo;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.ComboBox comboFondo;
    }
}

