using EntidadesBucavent;
using Bucavent;
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
    public partial class FormAgregar : Form
    {    
        public FormAgregar()
        {
            InitializeComponent();          
        }

        public FormMenu formMenu { get; set; }

        //Variable para guardar el nombre del archivo que contiene el icono del evento seleccionado
        public string imagen = "icono.jpg";

        /// <summary>
        /// Se reinician las configuraciones iniciales
        /// de los controles de este form y se establece 
        /// un formato que impide la selección de ciertos
        /// valores en los DateTimePickers.
        /// </summary>

        public void AjustarFormulario()
        {
            try
            {
                imagen = "icono.jpg";
                string nombreImagen = Path.Combine(Application.StartupPath, @"iconos\" + imagen);

                foreach (Control control in Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    if (control is DateTimePicker dateTime)
                    {
                        if (control.Name != "dateTimeFechaEvento")
                        {
                            dateTime.ShowUpDown = true;
                            dateTime.Format = DateTimePickerFormat.Time;
                            dateTime.Value = DateTime.Now.AddHours(1);
                        }
                        if (control.Name != "dateTimeHoraFinal")
                        {
                            dateTime.MinDate = DateTime.Now.AddHours(1);
                            dateTime.MaxDate = DateTime.Now.AddYears(10);
                        }
                    }
                    if (control is PictureBox picture)
                    {
                        picture.Image = Image.FromFile(nombreImagen);
                    }
                    if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception)
            {
            }                       
        }

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

                    if (Controls[i].Name == lblinformacion.Name)
                    {
                        Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 14);
                    }
                }
            }
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {            
            AjustarFormulario();         
        }
        
        // Objeto creado en btnAgregar_Click
        Evento evento;

        /// <summary>
        /// Se valida la información ingresada por el usuario y en caso de ser correcta
        /// se crea un objeto evento y se le asignan los valores ingresados en los
        /// distintos controles. Posteriormente se guardan los datos en "Evento.csv".
        /// </summary>

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TextBox textBox in Controls.OfType<TextBox>())
                {
                    textBox.Text = textBox.Text.Trim();
                }

                bool urlValida = Uri.TryCreate(txtUrl.Text, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (txtLugar.TextLength == 0 || txtPrecio.TextLength == 0 || comboTema.SelectedIndex == -1 || txtNombre.TextLength == 0 || comboUrl.SelectedIndex == -1 || txtDireccion.TextLength == 0)
                {
                    MessageBox.Show("No puedes dejar ningún campo vacío", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboTema.SelectedItem.ToString() == "Otro:" && txtTema.Text.Replace(" ", "").Length > 3)
                {
                    txtTema.Text = txtTema.Text.Substring(0, 1).ToUpper() + txtTema.Text.Substring(1).ToLower();
                }
                else if (comboTema.SelectedItem.ToString() == "Otro:" && txtTema.Text == "")
                {
                    MessageBox.Show("Debes ingresar el tema", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboTema.SelectedItem.ToString() == "Otro:" && txtTema.Text.Replace(" ", "").Length < 3)
                {
                    MessageBox.Show("El tema debe tener mínimo 3 caracteres", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtLugar.Text.Replace(" ", "").Length < 3 || txtNombre.Text.Replace(" ", "").Length < 3)
                {
                    MessageBox.Show("La ciudad y el nombre deben tener mínimo 3 caracteres", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboUrl.SelectedIndex == 1 && urlValida == false)
                {
                    MessageBox.Show("URL inválida", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToString(dateTimeHoraInicio.Value) == Convert.ToString(dateTimeHoraFinal.Value))
                {
                    MessageBox.Show("La hora de inicio no puede ser igual a la hora final", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtTema.Text.Replace(" ", "") == "Todas" && comboTema.SelectedItem.ToString() == "Otro:")
                {
                    MessageBox.Show("Cambia el nombre del tema (Todas es una palabra reservada)", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Precio() == false)
                {
                    MessageBox.Show("El precio debe ser un número", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (imagen == "icono.jpg")
                {
                    MessageBox.Show("Selecciona un icono dando click en la imagen", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {              
                    txtLugar.Text = txtLugar.Text.Substring(0, 1).ToUpper() + txtLugar.Text.Substring(1).ToLower();
                    txtNombre.Text = txtNombre.Text.Substring(0, 1).ToUpper() + txtNombre.Text.Substring(1).ToLower();

                    evento = new Evento();
                    evento.Nombre = txtNombre.Text;
                    evento.Lugar = txtLugar.Text;

                    if (comboTema.SelectedItem.ToString() != "Otro:")
                    {
                        evento.Tema = comboTema.SelectedItem.ToString();
                    }
                    else
                    {
                        txtTema.Text = txtTema.Text.Substring(0, 1).ToUpper() + txtTema.Text.Substring(1).ToLower();
                        evento.Tema = txtTema.Text;
                    }

                    evento.Precio = Convert.ToInt32(txtPrecio.Text);
                    evento.HoraInicio = dateTimeHoraInicio.Value;
                    evento.HoraFin = dateTimeHoraFinal.Value;
                    evento.Fecha = dateTimeFechaEvento.Value;
                    evento.NombreImagen = imagen;

                    if (comboUrl.SelectedIndex == 1)
                    {
                        evento.UrlEvento = txtUrl.Text;
                    }
                    else
                    {
                        evento.UrlEvento = "No";
                    }
                    evento.Direccion = txtDireccion.Text;
                    evento.Creador = formMenu.rol.Identificacion;

                    if (evento.Guardar() == true)
                    {
                        Actividad(evento.Nombre);
                        MessageBox.Show("Se almacenó su información con éxito", "Guardar evento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AjustarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Guardar evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal", "Guardar evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se comprueba si el valor ingresado por el usuario en el TextBox
        /// txtPrecio es un número.
        /// </summary>
        /// <returns></returns>

        public bool Precio()
        {           
            bool exito = true;
            try
            {
                txtPrecio.Text = txtPrecio.Text.Replace(" ", "");
                Convert.ToInt32(txtPrecio.Text);
            }
            catch (Exception)
            {

                exito = false;
            }
            return exito;
        }

        /// <summary>
        /// Se guarda la información sobre la importación o agregación 
        /// del evento en "Actividad.txt".
        /// </summary>
        /// <param name="nombreEvento">
        /// Nombre del evento agregado
        /// </param>

        private void Actividad(string nombreEvento)
        {
            try
            {
                StreamWriter writer = File.AppendText("Actividad.txt");
                writer.WriteLine("Evento agregado: " + nombreEvento);
                writer.WriteLine();
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Se obtiene la imagen elegida o agregada por el usuario en el formIconos
        /// y se muestra en el PictureBox de este Form.
        /// </summary>

        public void Imagen()
        {
            try
            {
                string nombreImagen = Path.Combine(Application.StartupPath, @"iconos\" + imagen);

                imgIcono.Image = Image.FromFile(nombreImagen);
            }
            catch (Exception)
            {
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();            
        }

        /// <summary>
        /// Se crea un objeto FormIconos donde se mostrarán
        /// las imagenes que se pueden incluir al evento creado.
        /// </summary>
        
        private void imgIcono_Click(object sender, EventArgs e)
        {
            FormIconos formIconos = new FormIconos();
            formIconos.tipoLetra = formMenu.tipoLetra;
            formIconos.colorFondo = formMenu.colorFondo;
            formIconos.colorLetra = formMenu.colorLetra;
            formIconos.Actualizar();
            formIconos.formAgregar = this;
            formIconos.Show();        
            Hide();          
        }

        private void FormAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {            
            formMenu.Show();           
        }

        /// <summary>
        /// Se permite al usuario agregar un tema distinto a los predeterminados
        /// mostrando un textbox visible.
        /// </summary>
        
        private void comboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTema.SelectedIndex != -1)
            {
                if (comboTema.SelectedItem.ToString() == "Otro:")
                {
                    comboTema.Size = new Size(64, comboTema.Size.Height);
                    txtTema.Visible = true;
                }
                else
                {
                    comboTema.Size = new Size(193, comboTema.Size.Height);
                    txtTema.Visible = false;
                } 
            }
            else
            {
                comboTema.Size = new Size(193, comboTema.Size.Height);
                txtTema.Visible = false;
            }
        }

        /// <summary>
        /// Si el usuario elige una fecha distinta a la del día actual se le 
        /// permite agregar cualquier hora de inicio, de lo contrario solo
        /// podrá elegir horas de inicio posteriores a la hora actual con
        /// una mínima diferencia de una hora.
        /// </summary>
 
        private void dateTimeFechaEvento_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFechaEvento.Value.ToString("dd/MM/yyyy") != DateTime.Now.ToString("dd/MM/yyyy"))
            {
                dateTimeHoraInicio.MinDate = DateTime.Today;
            }
            else
            {
                dateTimeHoraInicio.MinDate = DateTime.Now.AddHours(1);
            }
        }

        /// <summary>
        /// Si se validan los datos contenidos en el arhivo seleccionado, estos
        /// se escribirán  en "Evento.csv".
        /// </summary>
       
        public bool ImportarEvento(OpenFileDialog openFileDialog1)
        {
            bool exito = true;

            try
            {
                StreamReader reader = new StreamReader(openFileDialog1.OpenFile());
                string datoEvento = reader.ReadLine();

                while (datoEvento != null)
                {
                    if (datoEvento.Replace(" ", "") != "")
                    {
                        Evento evento = new Evento(datoEvento.Split(';')[0].Trim(), datoEvento.Split(';')[1].Trim(), datoEvento.Split(';')[2].Trim(), Convert.ToInt32(datoEvento.Split(';')[3].Trim()), DateTime.Parse(datoEvento.Split(';')[4].Trim()), DateTime.Parse(datoEvento.Split(';')[5].Trim()), DateTime.Parse(datoEvento.Split(';')[6].Trim()), datoEvento.Split(';')[7].Trim(), datoEvento.Split(';')[8].Trim(), datoEvento.Split(';')[9].Trim(), formMenu.rol.Identificacion);
                        if (evento.Guardar() == true)
                        {
                            Actividad(evento.Nombre);
                            exito = true;
                        }
                        else
                        {
                            exito = false;
                        }
                    }
                    datoEvento = reader.ReadLine();
                }
                reader.Close();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        /// <summary>
        /// Se abre un cuadro de diálogo mostrando el explorador
        /// de archivos para que el usuario elija un archivo de
        /// tipo .csv y se llama al método ImportarEvento() en
        /// caso de que el usuario abra el archivo.
        /// </summary>

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivos csv|*.csv";
                openFileDialog1.Title = "Selecciona un archivo";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (ImportarEvento(openFileDialog1) == true)
                    {
                        MessageBox.Show("La importación del evento fue exitosa", "Importar evento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Error al importar evento", "Importar evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se muestra un textbox para ingresar una URL valida si 
        /// el usuario confirma que su evento dispone de una 
        /// página web.
        /// </summary>
        
        private void comboUrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUrl.SelectedIndex == 1)
            {
                txtUrl.Visible = true;
            }
            else
            {
                txtUrl.Visible = false;
                txtUrl.Text = "";
            }
        }
    }
}
