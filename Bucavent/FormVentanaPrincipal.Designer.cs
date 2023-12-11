namespace Bucavent
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnOpcion = new System.Windows.Forms.Button();
            this.btnVerEvento = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.notifyEvento = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerNotificacion = new System.Windows.Forms.Timer(this.components);
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silenciarNotificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroDeActividadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFocus = new System.Windows.Forms.Label();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalendario
            // 
            this.btnCalendario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalendario.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.Location = new System.Drawing.Point(251, 177);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(141, 41);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategoria.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(251, 239);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(141, 41);
            this.btnCategoria.TabIndex = 3;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnOpcion
            // 
            this.btnOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpcion.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcion.Location = new System.Drawing.Point(251, 301);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(141, 41);
            this.btnOpcion.TabIndex = 4;
            this.btnOpcion.Text = "Personalizar";
            this.btnOpcion.UseVisualStyleBackColor = true;
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // btnVerEvento
            // 
            this.btnVerEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerEvento.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEvento.Location = new System.Drawing.Point(70, 177);
            this.btnVerEvento.Name = "btnVerEvento";
            this.btnVerEvento.Size = new System.Drawing.Size(141, 41);
            this.btnVerEvento.TabIndex = 5;
            this.btnVerEvento.Text = "Ver eventos";
            this.btnVerEvento.UseVisualStyleBackColor = true;
            this.btnVerEvento.Click += new System.EventHandler(this.btnVerEvento_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(70, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 41);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar evento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarEvento.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEvento.Location = new System.Drawing.Point(70, 301);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(141, 41);
            this.btnEliminarEvento.TabIndex = 9;
            this.btnEliminarEvento.Text = "Eliminar evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // notifyEvento
            // 
            this.notifyEvento.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyEvento.BalloonTipText = ".";
            this.notifyEvento.BalloonTipTitle = "Aviso de evento";
            this.notifyEvento.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyEvento.Icon")));
            this.notifyEvento.Text = "Notificación";
            this.notifyEvento.Visible = true;
            this.notifyEvento.BalloonTipClosed += new System.EventHandler(this.notifyEvento_BalloonTipClosed);
            this.notifyEvento.BalloonTipShown += new System.EventHandler(this.notifyEvento_BalloonTipShown);
            // 
            // timerNotificacion
            // 
            this.timerNotificacion.Interval = 60000;
            this.timerNotificacion.Tick += new System.EventHandler(this.timerNotificacion_Tick);
            // 
            // menuOpciones
            // 
            this.menuOpciones.BackColor = System.Drawing.Color.LightGreen;
            this.menuOpciones.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(448, 25);
            this.menuOpciones.TabIndex = 14;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem,
            this.silenciarNotificacionesToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(81, 21);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // restablecerConfiguraciónPredeterminadaToolStripMenuItem
            // 
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem.Name = "restablecerConfiguraciónPredeterminadaToolStripMenuItem";
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem.Text = "Restablecer configuración predeterminada";
            this.restablecerConfiguraciónPredeterminadaToolStripMenuItem.Click += new System.EventHandler(this.restablecerConfiguraciónPredeterminadaToolStripMenuItem_Click);
            // 
            // silenciarNotificacionesToolStripMenuItem
            // 
            this.silenciarNotificacionesToolStripMenuItem.Name = "silenciarNotificacionesToolStripMenuItem";
            this.silenciarNotificacionesToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.silenciarNotificacionesToolStripMenuItem.Text = "Desactivar notificaciones";
            this.silenciarNotificacionesToolStripMenuItem.Click += new System.EventHandler(this.silenciarNotificacionesToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(372, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarCuentaToolStripMenuItem,
            this.verRegistroDeActividadToolStripMenuItem1});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(126, 21);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Visible = false;
            // 
            // eliminarCuentaToolStripMenuItem
            // 
            this.eliminarCuentaToolStripMenuItem.Name = "eliminarCuentaToolStripMenuItem";
            this.eliminarCuentaToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.eliminarCuentaToolStripMenuItem.Text = "Eliminar cuenta";
            this.eliminarCuentaToolStripMenuItem.Click += new System.EventHandler(this.eliminarCuentaToolStripMenuItem_Click);
            // 
            // verRegistroDeActividadToolStripMenuItem1
            // 
            this.verRegistroDeActividadToolStripMenuItem1.Name = "verRegistroDeActividadToolStripMenuItem1";
            this.verRegistroDeActividadToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.verRegistroDeActividadToolStripMenuItem1.Text = "Ver registro de actividad";
            this.verRegistroDeActividadToolStripMenuItem1.Click += new System.EventHandler(this.verRegistroDeActividadToolStripMenuItem1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.ForeColor = System.Drawing.Color.LightGreen;
            this.txtTitulo.Location = new System.Drawing.Point(42, 43);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(379, 354);
            this.txtTitulo.TabIndex = 15;
            this.txtTitulo.Text = resources.GetString("txtTitulo.Text");
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.Enter += new System.EventHandler(this.txtTitulo_Enter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTitulo.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTitulo.Location = new System.Drawing.Point(88, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 77);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Bucavent";
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(12, 27);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 17;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(448, 409);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerEvento);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.menuOpciones);
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bucavent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEvento_FormClosed);
            this.Load += new System.EventHandler(this.FormEvento_Load);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnOpcion;
        private System.Windows.Forms.Button btnVerEvento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.NotifyIcon notifyEvento;
        private System.Windows.Forms.Timer timerNotificacion;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restablecerConfiguraciónPredeterminadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silenciarNotificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRegistroDeActividadToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFocus;
    }
}

