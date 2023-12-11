namespace Bucavent
{
    partial class FormHorario
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
            this.lblHorario = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Script MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.lblHorario.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblHorario.Location = new System.Drawing.Point(77, 37);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(283, 48);
            this.lblHorario.TabIndex = 0;
            this.lblHorario.Text = "Horario del día ";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(163, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(105, 42);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorario.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(49, 130);
            this.txtHorario.Multiline = true;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(333, 233);
            this.txtHorario.TabIndex = 5;
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblHorario);
            this.Name = "FormHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horario del día ";
            this.Load += new System.EventHandler(this.FormHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtHorario;
    }
}

