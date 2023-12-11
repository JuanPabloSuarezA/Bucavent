using EntidadesBucavent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucavent
{
    public partial class FormRegistro : Form
    {      
        public FormRegistro()
        {
            InitializeComponent();          
        }

        public FormInicioSesion formInicioSesion { get; set; }

        /// <summary>
        /// Se limpian y habilitan los textbox del form y se cambia
        /// la visibilidad los controles que hacen referencia al código de 
        /// administrador.
        /// </summary>

        private void comboTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {               
                textBox.Clear();
                textBox.Enabled = true;
            }          

            if (Convert.ToString(comboTipoCuenta.SelectedItem) == "Administrador")
            {
                txtCodigo.Visible = true;
                lblCodigo.Visible = true;
            }
            else
            {
                txtCodigo.Visible = false;
                lblCodigo.Visible = false;
            }
        }

        /// <summary>
        /// Se valida si el usuario ingresó todos los datos 
        /// y se genera un nuevo rol segun el tipo de cuenta 
        /// seleccionada en el comboBox.
        /// </summary>
        
        public void CrearCuenta()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = textBox.Text.Replace(" ", "");
            }

            if (txtApellido.Text == "" || txtContraseña.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("No puedes dejar ningún campo vacío", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (Convert.ToString(comboTipoCuenta.SelectedItem) == "")
                {
                    MessageBox.Show("No has seleccionado ningún perfil", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToString(comboTipoCuenta.SelectedItem) == "Administrador")
                {

                    if (txtCodigo.Text == "")
                    {
                        MessageBox.Show("Debes llenar la casilla del código de administrador para crear la cuenta", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else if (txtCodigo.Text == "000")
                    {

                        Rol rol = new Rol(txtNombre.Text + "." + txtApellido.Text, txtContraseña.Text, 2);
                        if (rol.Registrar() == true)
                        {
                            MessageBox.Show("Te has registrado exitosamente", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("Identificación: " + rol.Identificacion + Environment.NewLine + "Contraseña: " + rol.Contraseña, "Datos de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            formInicioSesion.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Código erróneo", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Convert.ToString(comboTipoCuenta.SelectedItem) == "Editor")
                {

                    Rol rol = new Rol(txtNombre.Text + "." + txtApellido.Text, txtContraseña.Text, 1);
                    if (rol.Registrar() == true)
                    {
                        MessageBox.Show("Te has registrado exitosamente", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        MessageBox.Show("Identificación: " + rol.Identificacion + Environment.NewLine + "Contraseña: " + rol.Contraseña, "Datos de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        formInicioSesion.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {            
            formInicioSesion.Show();
            Close();
        }

        private void FormRegistro_FormClosed(object sender, FormClosedEventArgs e)
        {
            formInicioSesion.Show();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
