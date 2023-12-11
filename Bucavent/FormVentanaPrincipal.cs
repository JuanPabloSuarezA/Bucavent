using Bucavent.Properties;
using EntidadesBucavent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace Bucavent
{
    public partial class FormMenu : Form
    {         
        public FormMenu()
        {
            InitializeComponent();
        }

        //Se almacena la cuenta enviada desde FormInicioSesion (visualizador,editor o admin)
        public Rol rol { get; set; }

        //Variables para Notificacion()
        public List<string> lineasDeFecha;      
        public bool abierto = false;

        /// <summary>
        /// Se guardan las horas de los eventos de hoy y las compara con la hora
        /// de hoy, si la diferencia en horas es menor a 1 se mostrará una
        /// notificación con el nombre del evento que comenzará pronto.
        /// </summary>

        public void Notificacion()
        {
            if (abierto == false)
            {
                try
                {
                    lineasDeFecha = new List<string>();
                    string horaActual = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
                    string hoy = DateTime.Now.ToString("d/MM/yyyy");

                    string[] strAllLines = File.ReadAllLines("Evento.csv");
                    File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                    StreamReader lector = File.OpenText("Evento.csv");
                    string lineas = lector.ReadLine();

                    while (lineas != null)
                    {
                        if (lineas.Split(';')[4] == hoy)
                        {
                            lineasDeFecha.Add(lineas);
                        }
                        lineas = lector.ReadLine();
                    }
                    lector.Close();                   

                    foreach (string infoEvento in lineasDeFecha)
                    {
                        string horaEvento = infoEvento.Split(';')[5];
                        TimeSpan timeSpan = Convert.ToDateTime(horaEvento).Subtract(Convert.ToDateTime(horaActual));
                        double diferencia = timeSpan.TotalHours;

                        if (diferencia <= 1 && diferencia > 0)
                        {
                            notifyEvento.BalloonTipText = "El evento \"" + infoEvento.Split(';')[0] + "\" comenzará a las " + infoEvento.Split(';')[5];                          
                            notifyEvento.ShowBalloonTip(0);
                        }
                    }
                }
                catch (Exception)
                {                 
                }
            }                 
        }

        // Variables para Actualizar()
        public Color colorLetra = Color.FromName("ControlText");
        public Color colorFondo = Color.FromName("LemonChiffon");
        public Font tipoLetra = null;
        public bool actualizacion = false;
        public bool actualizarLetra = false;

        /// <summary>
        /// Se cambia la configuración de los controles de este form
        /// en base a las configuración de aspecto seleccionada por el usuario en el
        /// FormPersonalizacionAplicacion.      
        /// </summary> 
        
        public void Actualizar()
        {            
            if (actualizacion == true)
            {
                BackColor = colorFondo;
                txtTitulo.BackColor = colorFondo;
                lblTitulo.BackColor = colorFondo;

                if (actualizarLetra == true)
                {
                    for (int i = 0; i < Controls.Count; i++)
                    {                      
                       Controls[i].ForeColor = colorLetra;                 
                    }
                    menuOpciones.BackColor = colorLetra;
                    opcionesToolStripMenuItem.ForeColor = Color.FromKnownColor(KnownColor.Black);
                    administradorToolStripMenuItem.ForeColor = Color.FromKnownColor(KnownColor.Black);
                }                   
                if (tipoLetra != null)
                {
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i].Name != "txtTitulo")
                        {
                            Controls[i].Font = tipoLetra;
                        }
                        if (Controls[i].Name == lblTitulo.Name)
                        {
                            Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 28);
                        }
                    }
                }               
            }        
        }

        /// <summary>
        /// Se determina si el usuario que ingresó fue el que aplicó
        /// las últimas configuraciones a la aplicación, en caso de ser verdad se mostrarán
        /// tales configuraciones aplicadas en su anterior inicio de sesión.
        /// </summary>

        private void ActualizarGuardado()
        {
            if (rol.Identificacion == Settings.Default.identificacion && rol.Identificacion != "")
            {
                if (Settings.Default.actualizarLetra == true)
                {
                    actualizarLetra = true;
                }

                BackColor = Settings.Default.colorFondo;
                tipoLetra = Settings.Default.tipoLetra;
                colorLetra = Settings.Default.colorLetra;
                colorFondo = Settings.Default.colorFondo;
                actualizacion = true;
                
                Actualizar();
            }
        }

        /// <summary>
        /// Se abre el archivo txt que contiene la actividad de los editores 
        /// y administradores y escribe la información del usuario que ingresó.
        /// </summary>
        
        public void Actividad()
        {
            if (rol.NivelAcceso > 0)
            {
                try
                {
                    string hoy = DateTime.Now.ToString("d/MM/yyyy");
                    string ahora = string.Format("{0:hh:mm:ss tt}", DateTime.Now);

                    StreamWriter writer = File.AppendText("Actividad.txt");
                    writer.WriteLine("<☻>");
                    writer.WriteLine("Actividad de " + rol.Identificacion + ":");
                    writer.WriteLine("Fecha: " + hoy);
                    writer.WriteLine("Hora de ingreso: " + ahora);
                    writer.WriteLine();
                    writer.Close();
                }
                catch (Exception)
                {
                }
            }
        }

        // Se almacenan los eventos que tienen una fecha igual o posterior al día de hoy.
        List<string> EventosNuevos;

        /// <summary>
        /// Se desaparecen todos los eventos que tengan una fecha anterior al día de hoy.
        /// </summary>
        public void EliminarEventosPasados()
        {
            try
            {
                EventosNuevos = new List<string>();
                string hoy = DateTime.Now.ToString("d/MM/yyyy");
                StreamReader lector = File.OpenText("Evento.csv");
                string lineas = lector.ReadLine();

                while (lineas != null)
                {
                    TimeSpan timeSpan = Convert.ToDateTime(lineas.Split(';')[4]).Subtract(Convert.ToDateTime(hoy));

                    double diferencia = timeSpan.TotalDays;

                    if (diferencia >= 0)
                    {
                        EventosNuevos.Add(lineas);
                    }

                    lineas = lector.ReadLine();
                }
                lector.Close();

                string direccion = Path.Combine(Application.StartupPath, "Evento.csv");
                File.WriteAllText(direccion, string.Empty);

                StreamWriter escritor = File.AppendText("Evento.csv");
                for (int i = 0; i < EventosNuevos.Count; i++)
                {
                    escritor.WriteLine(EventosNuevos[i]);
                }
                escritor.WriteLine();
                escritor.Close();
            }
            catch (Exception)
            {
            }
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {                    
            ActualizarGuardado();
            
            if (restablecerConfiguracion == false)
            {
                Actividad();
                Notificacion();
                EliminarEventosPasados();
            }
            else
            {
                restablecerConfiguracion = false;
            }
            
            timerNotificacion.Start();
            
            if (rol.NivelAcceso == 2)
            {
                administradorToolStripMenuItem.Visible = true;
            }
        }

        /// <summary>
        /// Se crea un FormCalendario, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FormCalendario formCalendario = new FormCalendario();
            formCalendario.formMenu = this;        
            formCalendario.mesEnum = DateTime.Now.Month - 1;

            if (actualizacion == true)
            {
                formCalendario.Actualizar();
            }              
            Hide();
            formCalendario.Show();
        }

        /// <summary>
        /// Se crea un FormCategorias, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FormCategorias formCategorias = new FormCategorias();
            formCategorias.formMenu = this;

            if (actualizacion == true)
            {
                formCategorias.Actualizar();
            }           
            Hide();
            formCategorias.Show();            
        }

        /// <summary>
        /// Se crea un FormPersonalizar, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void btnOpcion_Click(object sender, EventArgs e)
        {
            FormPersonalizar formPersonalizar = new FormPersonalizar();
            formPersonalizar.formMenu = this;
            if (actualizacion == true)
            {
                formPersonalizar.actualizarLetra = actualizarLetra;
                formPersonalizar.Actualizar();
            }         
            Hide();
            formPersonalizar.Show();
        }

        /// <summary>
        /// Se crea un FormInformacion, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void btnVerEvento_Click(object sender, EventArgs e)
        {
            FormInformacion formInformacion = new FormInformacion();
            formInformacion.formMenu = this;
            if (actualizacion == true)
            {
                formInformacion.Actualizar();
            }           
            Hide();
            formInformacion.Show();
        }

        /// <summary>
        /// Se crea un FormAgregar, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>
      
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rol.NivelAcceso < 1)
            {
                MessageBox.Show("No tienes permiso para agregar eventos", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAgregar formAgregar = new FormAgregar();
                formAgregar.formMenu = this;
                if (actualizacion == true)
                {
                    formAgregar.Actualizar();
                }
                formAgregar.Show();                
                Hide();
            }         
        }
        
        private void FormEvento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (restablecerConfiguracion == false)
            {
                try
                {
                    Process.Start(Application.ExecutablePath);
                    Process.GetCurrentProcess().Kill();
                }
                catch (Exception) 
                {
                    //Caso excepcional
                    FormInicioSesion form = new FormInicioSesion();
                    form.Show();
                }
            }
        }

        /// <summary>
        /// Se crea un FormEliminarEvento, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            if (rol.NivelAcceso > 0)
            {
                FormEliminarEvento formEliminarEvento = new FormEliminarEvento();
                formEliminarEvento.formMenu = this;
                if (actualizacion == true)
                {
                    formEliminarEvento.Actualizar();
                }               
                formEliminarEvento.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("No tienes permiso para eliminar eventos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Evita que se muestre la notificación de nuevo si ya se está mostrando.
        private void notifyEvento_BalloonTipShown(object sender, EventArgs e)
        {
            abierto = true;
        }

        private void notifyEvento_BalloonTipClosed(object sender, EventArgs e)
        {
            abierto = false;
        }

        private void timerNotificacion_Tick(object sender, EventArgs e)
        {
            Notificacion();
        }

        /// <summary>
        /// Se crea un FormEliminarCuenta, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void eliminarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarCuenta formEliminarCuenta = new FormEliminarCuenta();
            formEliminarCuenta.formMenu = this;
            if (actualizacion == true)
            {
                formEliminarCuenta.Actualizar();
            }
            formEliminarCuenta.Show();
            Hide();
        }

        /// <summary>
        /// Se crea un FormActividad, se muestra con las personalización de este Form,
        /// y se oculta este Form.
        /// </summary>

        private void verRegistroDeActividadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormActividad formActividad = new FormActividad();
            formActividad.formMenu = this;
            if (actualizacion == true)
            {
                formActividad.Actualizar();
            }
            formActividad.Show();
            Hide();
        }

        /// <summary>
        /// Se activan o desactivan las notificaciones de los eventos 
        /// según su estado anterior.
        /// </summary>

        private void silenciarNotificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (silenciarNotificacionesToolStripMenuItem.Text == "Desactivar notificaciones")
                {
                    timerNotificacion.Stop();
                    silenciarNotificacionesToolStripMenuItem.Text = "Activar notificaciones";
                    notifyEvento.BalloonTipTitle = "Aviso";
                    notifyEvento.BalloonTipText = "Notificaciones desactivadas";                   
                    notifyEvento.ShowBalloonTip(0);                  
                }
                else
                {                   
                    timerNotificacion.Start();
                    silenciarNotificacionesToolStripMenuItem.Text = "Desactivar notificaciones";
                    notifyEvento.BalloonTipTitle = "Aviso";
                    notifyEvento.BalloonTipText = "Notificaciones activadas";
                    notifyEvento.ShowBalloonTip(0);
                }
                notifyEvento.BalloonTipTitle = "Aviso de evento";
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Se cierran los formularios y se vuelve a ejecutar la aplicación.     
        /// </summary>
        
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro desea cerrar sesión?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (decision == DialogResult.Yes)
            {
                try
                {
                    Process.Start(Application.ExecutablePath);
                    Process.GetCurrentProcess().Kill();
                }
                catch
                {
                    //Caso excepcional
                    FormInicioSesion form = new FormInicioSesion();
                    form.Show();
                }
            }
        }

        bool restablecerConfiguracion = false;

        /// <summary>
        /// Se reinicia la configuración de la personalización de la aplicación.
        /// </summary>
        
        private void restablecerConfiguraciónPredeterminadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restablecerConfiguracion = true;

            FormMenu formMenu = new FormMenu();
            formMenu.rol = rol;
            formMenu.restablecerConfiguracion = true;

            if (rol.Identificacion == Settings.Default.identificacion && rol.Identificacion != "")
            {
                Settings.Default.Reset();
            }
            Close();
            formMenu.Show();
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            lblFocus.Focus();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
