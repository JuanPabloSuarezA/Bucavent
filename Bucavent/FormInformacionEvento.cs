using Bucavent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucavent
{
    public partial class FormInformacion : Form
    {
        public FormInformacion()
        {
            InitializeComponent();         
        }

        public FormMenu formMenu { get; set; }

        //Objetos para impresión       
        private PrintDocument DocumentoParaImprimir = new PrintDocument();
        private PrintDialog Impresora = new PrintDialog();
        private PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        private Bitmap bmp;

        private void DocumentoParaImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        /// <summary>
        /// Se genera una captura del formulario actual.
        /// </summary>

        public void CapturaFormulario()
        {
            Graphics mygraphics = CreateGraphics();
            Size sz = ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width,
                   ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

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

                    if (Controls[i].Name == lblInformacion.Name)
                    {                      
                        Controls[i].Font = new Font(Controls[i].Font.Name, Controls[i].Font.Size + 14);
                    }
                }
            }
        }

        /// <summary>
        /// Se cargan los nombres de los eventos existentes de Evento.csv en un
        /// comboBox y se habilita la opción para imprimir formularios.
        /// </summary>

        public void AjustarFormulario()
        {
            try
            {
                DocumentoParaImprimir.PrintPage += new PrintPageEventHandler(DocumentoParaImprimir_PrintPage);
                string[] strAllLines = File.ReadAllLines("Evento.csv");
                File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

                StreamReader LectorDeNombres = File.OpenText("Evento.csv");
                string titulo = LectorDeNombres.ReadLine();
                while (titulo != null)
                {
                    if (titulo.Replace(" ", "") != "")
                    {
                        comboSeleccionarEvento.Items.Add(titulo.Split(';')[0]);
                    }

                    try
                    {
                        titulo = LectorDeNombres.ReadLine();
                    }
                    catch (Exception)
                    {
                        titulo = null;
                    }
                }
                LectorDeNombres.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar nombres de eventos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FormInformacion_Load(object sender, EventArgs e)
        {
            AjustarFormulario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();
        }

        //Variable para guardar la url del evento.
        string url = null;
               
        /// <summary>
        /// Se cambian los datos del evento mostrados en 
        /// el form al seleccionar un elemento distinto
        /// en el comboEventos.
        /// </summary>
         
        public bool CargarEvento()
        {
            bool exito = true;

            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.BackColor = Color.White;
            }
           
            try
            {
                StreamReader lector = File.OpenText("Evento.csv");
                string lineas = lector.ReadLine();

                while (lineas.Split(';')[0] != comboSeleccionarEvento.SelectedItem.ToString() && lineas != null)
                {
                    lineas = lector.ReadLine();
                }
                txtEvento.Text = lineas.Split(';')[0];
                txtLugar.Text = lineas.Split(';')[1];
                txtTema.Text = lineas.Split(';')[2];
                txtPrecio.Text = lineas.Split(';')[3];
                txtFecha.Text = lineas.Split(';')[4];
                txtHoraInicio.Text = lineas.Split(';')[5];
                txtHoraFinal.Text = lineas.Split(';')[6];
                imgIcono.Image = Image.FromFile(Path.Combine(Application.StartupPath, @"iconos\" + lineas.Split(';')[7]));
                imgIcono.Tag = lineas.Split(';')[7];
                url = lineas.Split(';')[8];
                txtDireccion.Text = lineas.Split(';')[9];

                if (lineas.Split(';')[8] != "No")
                {
                    lblLink.Visible = true;
                    linkLblPagina.Visible = true;
                }
                else
                {
                    lblLink.Visible = false;
                    linkLblPagina.Visible = false;
                }
                lector.Close();

                btnExportar.Visible = true;
                btnImprimir.Visible = true;
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }
       
        private void comboSeleccionarEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CargarEvento() == false)
            {
                MessageBox.Show("Error al acceder a la información", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInformacion_FormClosed(object sender, FormClosedEventArgs e)
        {         
            formMenu.Show();       
        }

        /// <summary>
        /// Se exportan los datos del evento seleccionado
        /// del comboBox en un archivo .csv a la ubicación seleccionada por 
        /// el usuario en el explorador de archivos
        /// </summary>

        public bool ExportarEvento(SaveFileDialog saveFileDialog)
        {
            bool exito = true;

            try
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                writer.Write(txtEvento.Text);
                writer.Write(";" + txtLugar.Text);
                writer.Write(";" + txtTema.Text);
                writer.Write(";" + txtPrecio.Text);
                writer.Write(";" + txtFecha.Text);
                writer.Write(";" + txtHoraInicio.Text);
                writer.Write(";" + txtHoraFinal.Text);
                writer.Write(";" + Path.GetFileName(imgIcono.Tag.ToString()));
               
                if (linkLblPagina.Visible == true)
                {
                    writer.Write(";" + url);
                }
                else
                {
                    writer.Write(";" + "No");
                }
                writer.Write(";" + txtDireccion.Text);
                writer.Close();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }
            
        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboSeleccionarEvento.SelectedIndex != -1)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Title = "Exportar como";
                    saveFileDialog.Filter = "Archivo|*.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (ExportarEvento(saveFileDialog) == true)
                        {
                            MessageBox.Show("Exportación exitosa", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Error al exportar", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un evento", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se  genera una captura de formulario
        /// para mostrar una vista previa y posteriormente permitir una
        /// impresión de la captura del formulario con los datos del evento.
        /// </summary>
     
        public bool ImprimirEvento()
        {
            bool exito = true;
            try
            {
                CapturaFormulario();
                VistaPrevia.Document = DocumentoParaImprimir;
                VistaPrevia.ShowDialog();
                Impresora.Document = DocumentoParaImprimir;
                DialogResult Result = Impresora.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    DocumentoParaImprimir.DefaultPageSettings.Landscape = false;
                    DocumentoParaImprimir.Print();
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        /// <summary>
        /// Se ocultan los controles innecesarios para realizar
        /// una adecuada impresión.
        /// </summary>

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Visible = false;
            }
            comboSeleccionarEvento.Visible = false;
            lblSeleccionar.Visible = false;
            lblLink.Visible = false;
            linkLblPagina.Visible = false;

            foreach (TextBox item in Controls.OfType<TextBox>())
            {
                item.DeselectAll();
            }

            if (ImprimirEvento() == false)
            {
                MessageBox.Show("Error!, porfavor intenta de nuevo.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Button button in Controls.OfType<Button>())
            {
                button.Visible = true;
            } 

            comboSeleccionarEvento.Visible = true;
            lblSeleccionar.Visible = true;

            if (url != "No")
            {
                lblLink.Visible = true;
                linkLblPagina.Visible = true; 
            }
        }

        /// <summary>
        /// Se accede al sitio web del evento cuando el usuario
        /// hace click en el LinkLabel.
        /// </summary>

        private void linklblPagina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al acceder al sitio web", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
