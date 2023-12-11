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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se determina si el usuario ingresó datos válidos
        /// y en caso de ser verdad se crea un formEvento 
        /// (ventana principal) y se envian los datos a través 
        /// de un objeto Rol para bloquear cierta funciones.
        /// </summary>

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            txtIdentificacion.Text = txtIdentificacion.Text.Trim();

            if (Convert.ToString(comboPerfil.SelectedItem) == "")
            {
                MessageBox.Show("No has seleccionado ningún perfil", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(comboPerfil.SelectedItem) == "Administrador")
            {
                Rol rol = new Rol(txtIdentificacion.Text, txtContraseña.Text, 2);
                if (rol.IniciarSesion() == true)
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.rol = rol;
                    formMenu.Actualizar();
                    formMenu.Show();
                    Hide();               
                }
                else
                {
                    MessageBox.Show("Datos erróneos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Convert.ToString(comboPerfil.SelectedItem) == "Editor")
            {
                Rol rol = new Rol(txtIdentificacion.Text, txtContraseña.Text, 1);
                if (rol.IniciarSesion() == true)
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.rol = rol;
                    formMenu.Actualizar();
                    formMenu.Show();                
                    Hide();
                }
                else
                {
                    MessageBox.Show("Datos erróneos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Rol rol = new Rol("", "", 0);
                FormMenu formMenu = new FormMenu();
                formMenu.rol = rol;
                formMenu.Show();
                Hide();
            }
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            TopMost = true;
            txtIdentificacion.Enabled = false;
            txtContraseña.Enabled = false;
            
        }

        /// <summary>
        /// Si el usuario selecciona un rol de visualizador puede
        /// iniciar sesión sin necesidad de ingresar datos pero
        /// no tendrá todas  las funcionalidades.
        /// </summary>
        
        private void comboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToString(comboPerfil.SelectedItem) != "Visualizador")
            {
                txtContraseña.Enabled = true;
                txtIdentificacion.Enabled = true;
            }
            else
            {
                MessageBox.Show("Presiona el botón Iniciar Sesión","Mensaje indicativo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                txtContraseña.Text = "";
                txtIdentificacion.Text = "";
                txtContraseña.Enabled = false;
                txtIdentificacion.Enabled = false;
            }
                      
        }

        /// <summary>
        /// Se crea un FormRegistro en caso de seleccionar
        /// el botón de registro.
        /// </summary>
        
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.formInicioSesion = this;
            formRegistro.Show();

            comboPerfil.SelectedIndex = -1;
            txtIdentificacion.Text = "";
            txtContraseña.Text = "";
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
