using Bucavent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bucavent.Controles_de_Usuario;
using System.IO;

namespace Bucavent
{
    public partial class FormCalendario : Form
    {
        public FormCalendario()
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
        
        enum Meses
        {
            Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
        }

        //Variables para AjustarFormulario()
        public int mesEnum;
        public List<string> listaFechas;

        /// <summary>
        /// Se configuran los controles de este Form y se obtiene una
        /// lista de fechas de los eventos asignados al archivo
        /// "Evento.csv".
        /// </summary>

        public void AjustarFormulario()
        {
            try
            {
                txtMes.Text = Convert.ToString((Meses)mesEnum);
                txtMes.ForeColor = formMenu.colorLetra;
                txtMes.BackColor = Color.White;

                for (int anio = DateTime.Now.Year; anio < DateTime.Now.Year + 11; anio++)
                {
                    comboAnio.Items.Add(anio);
                }

                comboAnio.SelectedIndex = 0;

                listaFechas = new List<string>();
                try
                {
                    string[] strAllLines = File.ReadAllLines("Evento.csv");
                    File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
                    StreamReader lector = File.OpenText("Evento.csv");
                    string lineas = lector.ReadLine();

                    while (lineas != null)
                    {
                        try
                        {
                            if (lineas.Replace(" ", "") != "")
                            {
                                listaFechas.Add(lineas.Split(';')[4]);
                            }
                        }
                        catch (Exception)
                        {
                        }
                        lineas = lector.ReadLine();
                    }
                    lector.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar eventos disponibles", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ajustar calendario.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCalendario_Load(object sender, EventArgs e)
        {
            AjustarFormulario();
            Cacillas();            
        }

        //contador para los días de un mes       
        int mesActual = DateTime.Now.Month - 1;

        /// <summary>
        /// Se cambia el mes mostrado en el textbox y
        /// se llaman a las funciones LimpiarCalendario()
        /// y Cacillas().
        /// </summary>

        private void mesIzquierda_Click(object sender, EventArgs e)
        {
            LimpiarCalendario();
            if (comboAnio.SelectedIndex == 0)
            {
                if (mesEnum == mesActual)
                {
                    mesEnum = 11;
                }
                else
                {
                    mesEnum -= 1;
                }
                           
            }
            else if(comboAnio.SelectedIndex == 10)
            {
                if (mesEnum == 0)
                {
                    mesEnum = mesActual;
                }
                else
                {
                    mesEnum -= 1;
                }
            }
            else
            {
                mesEnum -= 1;
                if (mesEnum == -1)
                {
                    mesEnum = 11;
                }
            }
            Cacillas();
        }

        /// <summary>
        /// Se cambia el mes mostrado en el textbox y
        /// se llaman a las funciones LimpiarCalendario()
        /// y Cacillas().
        /// </summary>

        private void mesDerecha_Click(object sender, EventArgs e)
        {
            LimpiarCalendario();
            if (comboAnio.SelectedIndex == 0)
            {
                if (mesEnum == 11)
                {
                    mesEnum = mesActual;
                }
                else
                {
                    mesEnum += 1;
                }
            }
            else if (comboAnio.SelectedIndex == 10)
            {
                if (mesEnum == mesActual)
                {
                    mesEnum = 0;
                }
                else
                {
                    mesEnum += 1;
                }
            }
            else
	        {
                mesEnum += 1;
                if (mesEnum == 12)
                {
                    mesEnum = 0;
                }
            }
            Cacillas();
        }

        // Variables para Cacillas()
        Size tamanio;      
        int columnas;
        int ultimoDia;

        /// <summary>
        /// Se genera una nueva colección de controles CasillaCalendario
        /// según el mes seleccionado y se comprueba si la fecha asignada
        /// a cada casilla equivale a una fecha asignada de evento para 
        /// mostrar la visibilidad del icono que indica la presencia 
        /// de  eventos en tales fechas.
        /// </summary>

        public void Cacillas()
        {
            try
            {
                txtMes.Text = Convert.ToString((Meses)mesEnum);
                int contador = 0;

                string anioElegido = Convert.ToString(comboAnio.SelectedItem.ToString());

                if (mesEnum == 0 || mesEnum == 2 || mesEnum == 4 || mesEnum == 6 || mesEnum == 7 || mesEnum == 9 || mesEnum == 11)
                {
                    ultimoDia = 30;
                    columnas = 4;
                }
                else if (mesEnum == 3 || mesEnum == 5 || mesEnum == 8 || mesEnum == 10)
                {
                    ultimoDia = 29;
                    columnas = 3;
                }
                else
                {
                    columnas = 3;
                    int anioBisiesto = Convert.ToInt32(anioElegido);

                    if (anioBisiesto % 4 == 0)
                    {
                        if (anioBisiesto % 100 == 0)
                        {
                            if (anioBisiesto % 400 == 0)
                            {
                                ultimoDia = 28;
                            }
                            else
                            {
                                ultimoDia = 27;
                            }
                        }
                        else
                        {
                            ultimoDia = 28;
                        }
                    }
                    else
                    {
                        ultimoDia = 27;
                    }
                }

                for (int x = 0; x < columnas; x++) // For para agregar cada columna 
                {
                    for (int u = 0; u < 10; u++) //For para agregar cada casilla
                    {
                        CasillaCalendario nuevaCasilla1 = new CasillaCalendario();
                        nuevaCasilla1.Name = "casilla" + u.ToString(); // para tener el nombre de cada casilla
                        nuevaCasilla1.Location = new Point(u * nuevaCasilla1.Width, (x * nuevaCasilla1.Height) + nuevaCasilla1.Height); // va moviendo la casilla en la columna
                        nuevaCasilla1.colorFondo = formMenu.colorFondo;
                        nuevaCasilla1.colorLetra = formMenu.colorLetra;
                        nuevaCasilla1.tipoLetra = formMenu.tipoLetra;
                        nuevaCasilla1.actualizarLetra = formMenu.actualizarLetra;

                        int dia = u + contador + 1;

                        nuevaCasilla1.Controls[2].Text = dia.ToString(); // asigna el número

                        if (mesEnum < 9)
                        {
                            nuevaCasilla1.Controls[1].Text = dia.ToString() + "/0" + (mesEnum + 1).ToString() + "/" + anioElegido;
                        }

                        else
                        {
                            nuevaCasilla1.Controls[1].Text = dia.ToString() + "/" + (mesEnum + 1).ToString() + "/" + anioElegido;
                        }

                        try
                        {
                            for (int t = 0; t < listaFechas.Count; t++)
                            {
                                if (listaFechas[t] == nuevaCasilla1.Controls[1].Text)
                                {
                                    nuevaCasilla1.Controls[0].Visible = true;
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                        Controls.Add(nuevaCasilla1); // Se asigna la casilla a controles
                        Width = (nuevaCasilla1.Width * 10) + 15;
                        Height = nuevaCasilla1.Height * (columnas + 1) + 40;
                        if (u + contador >= ultimoDia)
                        {
                            break;
                        }
                    }
                    contador = contador + 10;
                }
                tamanio = Size;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear casillas", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se eliminan todos los controles de tipo CasillaCalendario al cambiar de mes o año.
        /// </summary>

        public void LimpiarCalendario()
        {
            while(Controls.Count > 7)
            {               
                foreach (CasillaCalendario casilla in Controls.OfType<CasillaCalendario>())
                {
                    Controls.Remove(casilla);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {          
            Close();
            formMenu.Show();          
        }

        private void FormCalendario_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        private void FormCalendario_LocationChanged(object sender, EventArgs e)
        {
            Location = new Point(150, 40);
        }

        /// <summary>
        /// Se reajusta el tamaño del formulario a sus dimensiones
        /// iniciales en caso de que el usuario las modifique 
        /// </summary>

        private void FormCalendario_SizeChanged(object sender, EventArgs e)
        {
            if (!(Size.Width == 1135 && Size.Height == 528) && !(Size.Width == 1135 && Size.Height == 650) && !(Controls.Count < 9) && (Size != tamanio))
            {
                Size = tamanio;
            }
        }

        /// <summary>
        /// Se reajusta el tamaño del formulario a sus dimensiones
        /// iniciales en caso de que el usuario las modifique 
        /// </summary>

        private void FormCalendario_Resize(object sender, EventArgs e)
        {
            if (Controls.Count > 9 && WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Se eliminan y modifican los controles en base al año
        /// seleccionado por el usuario, para el año final e inicial
        /// se usan condicionales para evitar que el usuario seleccione
        /// un mes que ya haya pasado o en el cual no se puedan agregar
        /// eventos actualmente ( La fecha máxima para agregar
        /// eventos es 10 años despues de la fecha actual)
        /// </summary>

        private void comboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaFechas != null)
            {
                if (comboAnio.SelectedIndex == 0 && mesEnum < mesActual)
                {
                    mesEnum = mesActual;
                }
                if (comboAnio.SelectedIndex == 10 && mesEnum > mesActual)
                {
                    mesEnum = 0;
                }
                LimpiarCalendario();
                Cacillas(); 
            }
        }
    }
}
