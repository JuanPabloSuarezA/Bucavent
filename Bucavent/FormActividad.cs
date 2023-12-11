using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucavent
{
    public partial class FormActividad : Form
    {
        public FormActividad()
        {
            InitializeComponent();
        }

        // Variable para Actualizar()
        public FormMenu formMenu { get; set; }

        /// <summary>
        /// Se cambia la configuración de los controles de este form
        /// en base a las configuración de aspecto seleccionada por el usuario en el
        /// FormPersonalizacionAplicacion.      
        /// </summary> 

        public void Actualizar()
        {
            BackColor = formMenu.colorFondo;

            if (formMenu.actualizarLetra == true)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].ForeColor = formMenu.colorLetra;
                }
            }    
            if (formMenu.tipoLetra != null)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Font = formMenu.tipoLetra;

                    if (Controls[i].Name == lblTitulo.Name)
                    {
                        Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 14);
                    }
                }
            }
        }

        /// <summary>
        /// Se abre el archivo txt que contiene la actividad de los editores y administradores, que 
        /// incluye agregar, importar o eliminar eventos, y tambien eliminar cuentas.
        /// </summary> 

        public void LeerActividad()
        {
            txtActividad.BackColor = Color.White;

            try
            {
                string[] strAllLines = File.ReadAllLines("Actividad.txt");
                File.WriteAllLines(Application.StartupPath + @"\Actividad.txt", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                StreamReader lector = File.OpenText("Actividad.txt");
                string lineas = lector.ReadLine();
                txtActividad.Clear();

                while (lineas != null)
                {
                    txtActividad.AppendText(lineas);
                    txtActividad.AppendText(Environment.NewLine);
                    lineas = lector.ReadLine();
                }
                lector.Close();

                if (txtActividad.Text == "")
                {
                    txtActividad.Text = "No han habido movimientos";
                }
            }
            catch (Exception)
            {
                txtActividad.Text = "No han habido movimientos";
            }
        }


        private void FormActividad_Load(object sender, EventArgs e)
        {
            LeerActividad();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();
        }

        private void FormActividad_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        /// <summary>
        /// Se borra el registro de la actividad de los editores y administradores.
        /// </summary>
        
        private void btnBorrarRegistro_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro desea borrar el registro?", "Borrar registro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                try
                {
                    txtActividad.Clear();
                    string direccion = Path.Combine(Application.StartupPath, "Actividad.txt");
                    File.WriteAllText(direccion, string.Empty);
                    formMenu.Actividad();
                    btnVolver.PerformClick();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar el registro", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
