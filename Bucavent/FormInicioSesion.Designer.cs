namespace Bucavent
{
    partial class FormInicioSesion
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
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.comboPerfil = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 26F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Aqua;
            this.lblTitulo.Location = new System.Drawing.Point(51, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(423, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario de inicio de sesión";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(127, 227);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(104, 20);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(247, 169);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(176, 29);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(247, 224);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(176, 29);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(105, 172);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(126, 20);
            this.lblIdentificacion.TabIndex = 4;
            this.lblIdentificacion.Text = "Identificación:";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.Location = new System.Drawing.Point(42, 321);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(140, 43);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarse.Location = new System.Drawing.Point(188, 321);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(146, 43);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // comboPerfil
            // 
            this.comboPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPerfil.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPerfil.FormattingEnabled = true;
            this.comboPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Editor",
            "Visualizador"});
            this.comboPerfil.Location = new System.Drawing.Point(247, 118);
            this.comboPerfil.Name = "comboPerfil";
            this.comboPerfil.Size = new System.Drawing.Size(176, 29);
            this.comboPerfil.TabIndex = 7;
            this.comboPerfil.SelectedIndexChanged += new System.EventHandler(this.comboPerfil_SelectedIndexChanged);
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(111, 121);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(120, 20);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Tipo de perfil:";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(340, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 43);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(501, 396);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.comboPerfil);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInicioSesion_FormClosed);
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.ComboBox comboPerfil;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnSalir;
    }
}