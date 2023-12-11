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
    public partial class FormEliminarCuenta : Form
    {
        public FormEliminarCuenta()
        {
            InitializeComponent();
        }

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
        /// Se añaden todas las identificaciones de los editores del archivo
        /// "Editores.config" al comboCuenta.
        /// </summary>

        public void AñadirNombres()
        {
            try
            {
                comboCuenta.Items.Clear();

                string[] strAllLines = File.ReadAllLines("Editores.config");
                File.WriteAllLines(Application.StartupPath + @"\Editores.config", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                StreamReader LectorDeNombres = File.OpenText("Editores.config");
                string identificacion = LectorDeNombres.ReadLine();
                while (identificacion != null)
                {
                    if (identificacion.Replace(" ", "") != "")
                    {
                        comboCuenta.Items.Add(identificacion.Split(';')[0]);
                    }

                    try
                    {
                        identificacion = LectorDeNombres.ReadLine();
                    }
                    catch (Exception)
                    {
                        identificacion = null;
                    }
                }
                LectorDeNombres.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar identificaciones de cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se escribe la información de la cuenta eliminada
        /// en el archivo de texto "Actividad.txt".
        /// </summary>

        public void Actividad(string nombreCuenta)
        {
            try
            {
                StreamWriter writer = File.AppendText("Actividad.txt");
                writer.WriteLine("Cuenta eliminada: " + nombreCuenta);
                writer.WriteLine();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        private void FormEliminarCuenta_Load(object sender, EventArgs e)
        {
            AñadirNombres();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();            
        }

        private void FormEliminarCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        //Lista de cuentas no seleccionadas en el comboCuenta
        List<string> listaCuentasNoEliminadas;

        /// <summary>
        /// Se guardan todas las identificaciones diferentes
        /// a la seleccionada en el comboCuenta y se vuelven
        /// a reescribir en el archivo "Editores.config".
        /// </summary>
        
        public bool EliminarCuenta()
        {
            bool exito = true;
            try
            {
                listaCuentasNoEliminadas = new List<string>();

                StreamReader lector = File.OpenText("Editores.config");

                string linea = lector.ReadLine();

                while (linea != null)
                {
                    if (linea.Split(';')[0] != comboCuenta.Text)
                    {
                        listaCuentasNoEliminadas.Add(linea);
                    }
                    linea = lector.ReadLine();
                }
                lector.Close();

                string direccion = Path.Combine(Application.StartupPath, "Editores.config");

                File.WriteAllText(direccion, string.Empty);

                StreamWriter escritor = File.AppendText("Editores.config");

                for (int i = 0; i < listaCuentasNoEliminadas.Count; i++)
                {
                    escritor.WriteLine(listaCuentasNoEliminadas[i]);
                }
                escritor.WriteLine();
                escritor.Close();

                Actividad(comboCuenta.SelectedItem.ToString());
                AñadirNombres();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        /// <summary>
        /// Se verifica si el administrador eligió una cuenta
        /// y a continuación se elimina.
        /// </summary>

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboCuenta.Text == "")
            {
                MessageBox.Show("No seleccionaste ninguna cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult decision = MessageBox.Show("¿Seguro desea eliminar " + comboCuenta.Text + "?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    if (EliminarCuenta() == true)
                    {
                        MessageBox.Show("Se ha eliminado la cuenta", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la cuenta", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
