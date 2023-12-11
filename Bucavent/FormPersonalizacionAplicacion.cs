using Bucavent;
using Bucavent.Properties;
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
    public partial class FormPersonalizar : Form
    {             
        public FormPersonalizar()
        {
            InitializeComponent();
        }

        public FormMenu formMenu { get; set; }
      
        //Variable para Actualizar()
        public bool actualizarLetra = false;

        /// <summary>
        /// Se cambia la configuración de los controles de este form
        /// en base a las configuración de aspecto guardada por el usuario en un
        /// FormPersonalizacionAplicacion anterior.
        /// </summary> 

        public void Actualizar()
        {
            BackColor = formMenu.colorFondo;

            if (actualizarLetra == true)
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

                    if (Controls[i].Name == lblPersonalizacion.Name)
                    {
                        Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 14);
                    }
                }
            }
        }

        //Lista con todos los colores existentes 
        public List<KnownColor> colors;

        /// <summary>
        /// Se cargan los combobox con todos los 
        /// colores existentes en el sistema y los
        /// tipos de letra disponibles.
        /// </summary>

        public void AjustarFormulario()
        {
            try
            {
                colors = new List<KnownColor>();
                comboColor.Items.Clear();
                comboFondo.Items.Clear();
                comboLetra.Items.Clear();

                string[] colores = Enum.GetNames(typeof(KnownColor));

                foreach (KnownColor colorValue in Enum.GetValues(typeof(KnownColor)))
                {
                    colors.Add(colorValue);
                }

                comboColor.Items.AddRange(colores);
                comboFondo.Items.AddRange(colores);

                foreach (FontFamily font in FontFamily.Families)
                {
                    string nombre = font.Name;
                    comboLetra.Items.Add(nombre);
                }
                comboLetra.Items.RemoveAt(0);
            }
            catch (Exception)
            {
            }
        }

        private void FormPersonalizar_Load(object sender, EventArgs e)
        {
            AjustarFormulario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {         
            Close();
            formMenu.Show();                  
        }

        private void FormPersonalizar_FormClosed(object sender, FormClosedEventArgs e)
        {          
           formMenu.Show();        
        }

        /// <summary>
        /// Se dibujan los elementos del comboFondo.
        /// </summary>

        private void comboColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                try
                {
                    e.DrawBackground();
                    string texto = comboColor.Items[e.Index].ToString();

                    Brush borde = new SolidBrush(e.ForeColor);
                    Color color = Color.FromName(texto);
                    Brush brocha = new SolidBrush(color);
                    Pen pen = new Pen(e.ForeColor);

                    e.Graphics.DrawRectangle(pen, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                    e.Graphics.FillRectangle(brocha, new Rectangle(e.Bounds.Left + 3,e.Bounds.Top + 3,48, e.Bounds.Height - 6));
                    e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
                    e.DrawFocusRectangle();                  
                }
                catch (Exception)
                {
                } 
            }
        }

        /// <summary>
        /// Se dibujan los elementos del comboFondo.
        /// </summary>
        
        private void comboFondo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index > -1)
            {
                try
                {
                    e.DrawBackground();
                    string texto = comboFondo.Items[e.Index].ToString();

                    Brush borde = new SolidBrush(e.ForeColor);
                    Color color = Color.FromName(texto);
                    Brush brocha = new SolidBrush(color);
                    Pen pen = new Pen(e.ForeColor);

                    e.Graphics.DrawRectangle(pen, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                    e.Graphics.FillRectangle(brocha, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                    e.Graphics.DrawString(texto, e.Font, borde, e.Bounds.Left + 65, e.Bounds.Top + 2);
                    e.DrawFocusRectangle();
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Se dibujan los elementos del comboLetra.
        /// </summary>
        
        private void comboLetra_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index > -1)
                {
                    e.DrawBackground();
                    string texto = comboLetra.Items[e.Index].ToString();
                    Font font = new Font(texto, e.Font.Size);
                    e.Graphics.DrawString(texto, font, new SolidBrush(e.ForeColor), e.Bounds.Left + 2, e.Bounds.Top + 2);
                    e.DrawFocusRectangle();
                }
            }
            catch (Exception)
            {
            }
        }
        //Determina si hay cambio de letra.
        bool cambiado = false;

        /// <summary>
        /// Se modifica el tipo de letra del comboLetra en base a la opción
        /// seleccionada
        /// </summary>
        
        private void comboLetra_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboLetra.Font = new Font(comboLetra.Text, comboLetra.Font.Size);
            cambiado = true;
        }

        //Variable para permitir cambios
        bool permitirCambios = true;

        /// <summary>
        /// Se validan las configuraciones seleccionadas por el usuario y se 
        /// cambian los Settings de Properties en el caso de que el usuario
        /// tenga un rango mayor al de visualizador, ademas se envian los
        /// elementos seleccionados al formEvento(ventana principal) para 
        /// aplicar los cambios.
        /// </summary>
       
        public void AplicarCambios()
        {
            try
            {
                int posicion1 = comboColor.SelectedIndex;
                int posicion2 = comboFondo.SelectedIndex;
                string nombreLetra = comboLetra.Font.Name;
                int verdad = 0;

                if (posicion1 != -1 || posicion2 != -1 || cambiado == true)
                {
                    if (posicion1 != -1 && posicion2 != -1)
                    {
                        if (Color.FromKnownColor(colors[posicion1]) == lblColor.ForeColor && Color.FromKnownColor(colors[posicion2]) == BackColor && nombreLetra == lblLetra.Font.Name)
                        {
                            verdad = 1;
                        }
                    }
                    else if (posicion1 != -1)
                    {
                        if (Color.FromKnownColor(colors[posicion1]) == lblColor.ForeColor && nombreLetra == lblLetra.Font.Name)
                        {
                            verdad = 1;
                        }
                    }
                    else if (posicion2 != -1)
                    {
                        if (Color.FromKnownColor(colors[posicion2]) == BackColor && nombreLetra == lblLetra.Font.Name)
                        {
                            verdad = 1;
                        }
                    }
                    else if (nombreLetra == lblLetra.Font.Name)
                    {
                        verdad = 1;
                    }
                }
                if (posicion2 != -1)
                {
                    try
                    {
                        formMenu.BackColor = Color.FromKnownColor(colors[posicion2]);
                        permitirCambios = true;
                    }
                    catch (Exception)
                    {
                        permitirCambios = false;
                        MessageBox.Show("Seleccionaste un color no permitido para el fondo", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (verdad == 0 && permitirCambios == true)
                {
                    if (posicion1 != -1)
                    {
                        if (Color.FromKnownColor(colors[posicion1]) != lblColor.ForeColor)
                        {
                            formMenu.colorLetra = Color.FromKnownColor(colors[posicion1]);
                            if (formMenu.rol.Identificacion != "")
                            {
                                Settings.Default.colorLetra = Color.FromKnownColor(colors[posicion1]);
                                Settings.Default.actualizarLetra = true;
                            }
                            actualizarLetra = true;
                        }
                        else
                        {
                            actualizarLetra = false;
                        }
                    }
                    if (posicion2 != -1)
                    {
                        formMenu.colorFondo = Color.FromKnownColor(colors[posicion2]);

                        if (formMenu.rol.Identificacion != "")
                        {
                            Settings.Default.colorFondo = Color.FromKnownColor(colors[posicion2]);
                        }

                    }
                    if (comboLetra.SelectedIndex != -1)
                    {
                        formMenu.tipoLetra = comboLetra.Font;

                        if (formMenu.rol.Identificacion != "")
                        {
                            Settings.Default.tipoLetra = comboLetra.Font;
                        }
                    }
                    if (comboColor.SelectedIndex == -1 && comboLetra.SelectedIndex == -1 && comboFondo.SelectedIndex == -1)
                    {
                        MessageBox.Show("No seleccionaste ninguna opción", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (comboColor.SelectedIndex != -1 || comboLetra.SelectedIndex != -1 || comboFondo.SelectedIndex != -1)
                    {
                        MessageBox.Show("Cambios aplicados", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        formMenu.actualizacion = true;
                        formMenu.actualizarLetra = actualizarLetra;

                        if (formMenu.rol.Identificacion != "")
                        {
                            if (formMenu.rol.Identificacion != Settings.Default.identificacion)
                            {
                                Settings.Default.Reset();

                                if (posicion1 != -1)
                                {
                                    if (Color.FromKnownColor(colors[posicion1]) != lblColor.ForeColor)
                                    {
                                        formMenu.colorLetra = Color.FromKnownColor(colors[posicion1]);
                                        Settings.Default.colorLetra = Color.FromKnownColor(colors[posicion1]);
                                        Settings.Default.actualizarLetra = true;
                                        actualizarLetra = true;
                                    }
                                    else
                                    {
                                        actualizarLetra = false;
                                    }
                                }
                                if (posicion2 != -1)
                                {
                                    formMenu.colorFondo = Color.FromKnownColor(colors[posicion2]);
                                    Settings.Default.colorFondo = Color.FromKnownColor(colors[posicion2]);

                                }
                                if (comboLetra.SelectedIndex != -1)
                                {
                                    formMenu.tipoLetra = comboLetra.Font;
                                    Settings.Default.tipoLetra = comboLetra.Font;
                                }
                            }
                            Settings.Default.identificacion = formMenu.rol.Identificacion;
                            Settings.Default.Save();
                        }
                        formMenu.Actualizar();
                        formMenu.Show();
                        Close();
                    }
                }
                else if (permitirCambios == true)
                {
                    MessageBox.Show("Esa configuración ya está aplicada", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al aplicar cambios", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCambios_Click(object sender, EventArgs e)
        {
            AplicarCambios();
        }
    }
}
