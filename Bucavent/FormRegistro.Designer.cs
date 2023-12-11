namespace Bucavent
{
    partial class FormRegistro
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
            this.lblTituloRegistro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.comboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloRegistro
            // 
            this.lblTituloRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloRegistro.AutoSize = true;
            this.lblTituloRegistro.Font = new System.Drawing.Font("Script MT Bold", 30F);
            this.lblTituloRegistro.ForeColor = System.Drawing.Color.Cyan;
            this.lblTituloRegistro.Location = new System.Drawing.Point(118, 27);
            this.lblTituloRegistro.Name = "lblTituloRegistro";
            this.lblTituloRegistro.Size = new System.Drawing.Size(314, 48);
            this.lblTituloRegistro.TabIndex = 0;
            this.lblTituloRegistro.Text = "Registro de cuenta";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(81, 202);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(191, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Ingresa tu primer nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(291, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 25);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(81, 247);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(198, 17);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Ingresa tu primer apellido: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(291, 247);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(129, 25);
            this.txtApellido.TabIndex = 4;
            // 
            // comboTipoCuenta
            // 
            this.comboTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoCuenta.FormattingEnabled = true;
            this.comboTipoCuenta.Items.AddRange(new object[] {
            "Editor",
            "Administrador"});
            this.comboTipoCuenta.Location = new System.Drawing.Point(158, 125);
            this.comboTipoCuenta.Name = "comboTipoCuenta";
            this.comboTipoCuenta.Size = new System.Drawing.Size(154, 25);
            this.comboTipoCuenta.TabIndex = 5;
            this.comboTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.comboTipoCuenta_SelectedIndexChanged);
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Location = new System.Drawing.Point(155, 95);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(110, 17);
            this.lblTipoCuenta.TabIndex = 6;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCuenta.Location = new System.Drawing.Point(126, 417);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(108, 40);
            this.btnCrearCuenta.TabIndex = 7;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(81, 300);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(176, 17);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Ingresa una contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(291, 297);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(129, 25);
            this.txtContraseña.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Location = new System.Drawing.Point(271, 417);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 40);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(81, 354);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(185, 17);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Código de administrador:";
            this.lblCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Location = new System.Drawing.Point(291, 354);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(129, 25);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.Visible = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(527, 486);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblTipoCuenta);
            this.Controls.Add(this.comboTipoCuenta);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloRegistro);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistro_FormClosed);
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}