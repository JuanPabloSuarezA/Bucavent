using EntidadesBucavent;
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
    public partial class FormEliminarEvento : Form
    {
        public FormEliminarEvento()
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
        /// Se añaden todos los nombres de los eventos del archivo
        /// "Evento.csv" al comboCuenta, si el usuario es un editor
        /// solo se agregarán los nombres de los eventos que el haya 
        /// eliminado.
        /// </summary>

        public void AñadirNombres()
        {
            try
            {
                comboEventos.Items.Clear();

                string[] strAllLines = File.ReadAllLines("Evento.csv");
                File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                StreamReader LectorDeNombres = File.OpenText("Evento.csv");
                string titulo = LectorDeNombres.ReadLine();

                while (titulo != null)
                {
                    if (titulo.Replace(" ", "") != "")
                    {
                        if (formMenu.rol.NivelAcceso == 1)
                        {                           
                            if (titulo.Split(';')[9] == formMenu.rol.Identificacion)
                            {
                                comboEventos.Items.Add(titulo.Split(';')[0]);
                            }                                                    
                        }
                        else
                        {
                            comboEventos.Items.Add(titulo.Split(';')[0]);
                        }
                    }              
                    titulo = LectorDeNombres.ReadLine();                   
                }
                LectorDeNombres.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar nombres de eventos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se escribe la información del evento eliminado
        /// en el archivo de texto "Actividad.txt".
        /// </summary>

        public void Actividad(string nombreEvento)
        {
            try
            {
                StreamWriter writer = File.AppendText("Actividad.txt");
                writer.WriteLine("Evento eliminado: " + nombreEvento);
                writer.WriteLine();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        private void FormEliminarEvento_Load(object sender, EventArgs e)
        {
            AñadirNombres();         
        }

        //Lista de eventos no seleccionados en el comboCuenta
        private List<string> listaEventosNoEliminados;

        /// <summary>
        /// Se guardan todos los eventos diferentes
        /// a los seleccionados en el comboEventos y se vuelven
        /// a reescribir en el archivo "Evento.csv".
        /// </summary>
        
        public bool EliminarEvento()
        {
            bool exito = true;

            try
            {
                listaEventosNoEliminados = new List<string>();
                StreamReader lector = File.OpenText("Evento.csv");
                string linea = lector.ReadLine();

                while (linea != null)
                {
                    if (linea.Split(';')[0] != comboEventos.Text)
                    {
                        listaEventosNoEliminados.Add(linea);
                    }
                    linea = lector.ReadLine();
                }
                lector.Close();

                string direccion = Path.Combine(Application.StartupPath, "Evento.csv");
                File.WriteAllText(direccion, string.Empty);

                StreamWriter escritor = File.AppendText("Evento.csv");

                for (int i = 0; i < listaEventosNoEliminados.Count; i++)
                {
                    escritor.WriteLine(listaEventosNoEliminados[i]);
                }
                escritor.WriteLine();
                escritor.Close();

                Actividad(comboEventos.SelectedItem.ToString());
                AñadirNombres();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        /// <summary>
        /// Se determina si el usuario seleccionó un 
        /// evento para posteriormente eliminarlo.
        /// </summary>

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboEventos.Text == "")
            {
                MessageBox.Show("No seleccionaste ningún evento", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult decision = MessageBox.Show("¿Seguro desea eliminar " + comboEventos.Text + "?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (decision == DialogResult.Yes)
                {
                    if (EliminarEvento() == true)
                    {
                        MessageBox.Show("Se ha eliminado el evento", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el evento", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();    
        }

        private void FormEliminarEvento_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }
    }
}
