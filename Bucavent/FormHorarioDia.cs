using Bucavent.Controles_de_Usuario;
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
    public partial class FormHorario : Form
    {
        public FormHorario()
        {
            InitializeComponent();
        }

        public CasillaCalendario casilla { get; set; }

        /// <summary>
        /// Se aplican las variables de personalización al form.
        /// </summary>
        
        public void Actualizar()
        {
            BackColor = casilla.colorFondo;

            if (casilla.actualizarLetra == true)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].ForeColor = casilla.colorLetra;
                }
            }
            if (casilla.tipoLetra != null)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Font = casilla.tipoLetra;

                    if (Controls[i].Name == lblHorario.Name)
                    {
                        Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 14);
                    }
                }
            }
        }

        //Variable para AñadirHorario()
        public string fechaExacta = null;

        /// <summary>
        /// Se añaden las horas y los títulos de los eventos del día 
        /// indicado por la fecha exacta.
        /// </summary>

        public bool AñadirHorario()
        {
            bool exito = true;
            txtHorario.BackColor = Color.White;

            try
            {
                string[] strAllLines = File.ReadAllLines("Evento.csv");

                File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                StreamReader lector = File.OpenText("Evento.csv");
                string lineas = lector.ReadLine();
                txtHorario.Text = "";
                while (lineas != null)
                {
                    if (lineas.Split(';')[4] == fechaExacta)
                    {
                        txtHorario.AppendText(lineas.Split(';')[5] + " - " + lineas.Split(';')[6] + ": " + lineas.Split(';')[0]);
                        txtHorario.AppendText(Environment.NewLine);
                    }
                    lineas = lector.ReadLine();
                }
                lector.Close();

                if (txtHorario.Text == "")
                {
                    txtHorario.Text = "No hay horas asignadas";
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        private void FormHorario_Load(object sender, EventArgs e)
        {
            if (AñadirHorario() == false)
            {
                txtHorario.Text = "Ha ocurrido un error al acceder a la información del evento";
            }                   
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
