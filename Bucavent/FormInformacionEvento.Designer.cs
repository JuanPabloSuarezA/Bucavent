namespace Bucavent
{
    partial class FormInformacion
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblComienza = new System.Windows.Forms.Label();
            this.lblTermina = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.txtHoraFinal = new System.Windows.Forms.TextBox();
            this.comboSeleccionarEvento = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.linkLblPagina = new System.Windows.Forms.LinkLabel();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(70, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Evento: ";
            // 
            // lblComienza
            // 
            this.lblComienza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComienza.AutoSize = true;
            this.lblComienza.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComienza.Location = new System.Drawing.Point(70, 390);
            this.lblComienza.Name = "lblComienza";
            this.lblComienza.Size = new System.Drawing.Size(97, 21);
            this.lblComienza.TabIndex = 1;
            this.lblComienza.Text = "Comienza:";
            // 
            // lblTermina
            // 
            this.lblTermina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTermina.AutoSize = true;
            this.lblTermina.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermina.Location = new System.Drawing.Point(70, 430);
            this.lblTermina.Name = "lblTermina";
            this.lblTermina.Size = new System.Drawing.Size(92, 21);
            this.lblTermina.TabIndex = 2;
            this.lblTermina.Text = "Termina: ";
            // 
            // lblLugar
            // 
            this.lblLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(70, 195);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(75, 21);
            this.lblLugar.TabIndex = 3;
            this.lblLugar.Text = "Ciudad:";
            // 
            // lblTema
            // 
            this.lblTema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(70, 273);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(61, 21);
            this.lblTema.TabIndex = 4;
            this.lblTema.Text = "Tema:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(70, 313);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 21);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Script MT Bold", 30F);
            this.lblInformacion.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblInformacion.Location = new System.Drawing.Point(170, 14);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(389, 48);
            this.lblInformacion.TabIndex = 7;
            this.lblInformacion.Text = "Información del evento";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(290, 514);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(169, 41);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver al menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(70, 353);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 21);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtEvento
            // 
            this.txtEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEvento.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvento.Location = new System.Drawing.Point(178, 158);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.ReadOnly = true;
            this.txtEvento.Size = new System.Drawing.Size(194, 25);
            this.txtEvento.TabIndex = 11;
            // 
            // txtLugar
            // 
            this.txtLugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLugar.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(178, 195);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.ReadOnly = true;
            this.txtLugar.Size = new System.Drawing.Size(194, 25);
            this.txtLugar.TabIndex = 12;
            // 
            // txtTema
            // 
            this.txtTema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTema.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(178, 273);
            this.txtTema.Name = "txtTema";
            this.txtTema.ReadOnly = true;
            this.txtTema.Size = new System.Drawing.Size(194, 25);
            this.txtTema.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(178, 313);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(194, 25);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(178, 353);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(194, 25);
            this.txtFecha.TabIndex = 15;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraInicio.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraInicio.Location = new System.Drawing.Point(178, 390);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.ReadOnly = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(194, 25);
            this.txtHoraInicio.TabIndex = 16;
            // 
            // txtHoraFinal
            // 
            this.txtHoraFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoraFinal.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFinal.Location = new System.Drawing.Point(178, 427);
            this.txtHoraFinal.Name = "txtHoraFinal";
            this.txtHoraFinal.ReadOnly = true;
            this.txtHoraFinal.Size = new System.Drawing.Size(194, 25);
            this.txtHoraFinal.TabIndex = 17;
            // 
            // comboSeleccionarEvento
            // 
            this.comboSeleccionarEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboSeleccionarEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSeleccionarEvento.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSeleccionarEvento.FormattingEnabled = true;
            this.comboSeleccionarEvento.Location = new System.Drawing.Point(326, 95);
            this.comboSeleccionarEvento.Name = "comboSeleccionarEvento";
            this.comboSeleccionarEvento.Size = new System.Drawing.Size(121, 28);
            this.comboSeleccionarEvento.TabIndex = 18;
            this.comboSeleccionarEvento.SelectedIndexChanged += new System.EventHandler(this.comboSeleccionarEvento_SelectedIndexChanged);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(146, 98);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(162, 20);
            this.lblSeleccionar.TabIndex = 19;
            this.lblSeleccionar.Text = "Seleccionar evento:";
            // 
            // imgIcono
            // 
            this.imgIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgIcono.Location = new System.Drawing.Point(442, 261);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(107, 105);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 20;
            this.imgIcono.TabStop = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(469, 95);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(177, 29);
            this.btnExportar.TabIndex = 21;
            this.btnExportar.Text = "Exportar Evento";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(572, 301);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(137, 31);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // linkLblPagina
            // 
            this.linkLblPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLblPagina.AutoSize = true;
            this.linkLblPagina.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblPagina.Location = new System.Drawing.Point(190, 472);
            this.linkLblPagina.Name = "linkLblPagina";
            this.linkLblPagina.Size = new System.Drawing.Size(134, 21);
            this.linkLblPagina.TabIndex = 24;
            this.linkLblPagina.TabStop = true;
            this.linkLblPagina.Text = "Haz click aquí";
            this.linkLblPagina.Visible = false;
            this.linkLblPagina.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPagina_LinkClicked);
            // 
            // lblLink
            // 
            this.lblLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(70, 472);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(114, 21);
            this.lblLink.TabIndex = 25;
            this.lblLink.Text = "Pagina web:";
            this.lblLink.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(70, 236);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 21);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Lugar:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccion.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(178, 236);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(194, 25);
            this.txtDireccion.TabIndex = 27;
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(721, 572);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.linkLblPagina);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.imgIcono);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.comboSeleccionarEvento);
            this.Controls.Add(this.txtHoraFinal);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblTermina);
            this.Controls.Add(this.lblComienza);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Century", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información del evento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInformacion_FormClosed);
            this.Load += new System.EventHandler(this.FormInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblComienza;
        private System.Windows.Forms.Label lblTermina;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.TextBox txtHoraFinal;
        private System.Windows.Forms.ComboBox comboSeleccionarEvento;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.LinkLabel linkLblPagina;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}

