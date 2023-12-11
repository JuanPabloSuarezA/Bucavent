namespace Bucavent
{
    partial class FormEliminarEvento
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEventos = new System.Windows.Forms.Label();
            this.comboEventos = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 30F);
            this.lblTitulo.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTitulo.Location = new System.Drawing.Point(69, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Eliminar evento";
            // 
            // lblEventos
            // 
            this.lblEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(35, 100);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(140, 17);
            this.lblEventos.TabIndex = 1;
            this.lblEventos.Text = "Seleccionar evento:";
            // 
            // comboEventos
            // 
            this.comboEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboEventos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEventos.FormattingEnabled = true;
            this.comboEventos.Location = new System.Drawing.Point(205, 97);
            this.comboEventos.Name = "comboEventos";
            this.comboEventos.Size = new System.Drawing.Size(148, 25);
            this.comboEventos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(136, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Location = new System.Drawing.Point(136, 220);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 40);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormEliminarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(386, 286);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboEventos);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEliminarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar evento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEliminarEvento_FormClosed);
            this.Load += new System.EventHandler(this.FormEliminarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.ComboBox comboEventos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
    }
}