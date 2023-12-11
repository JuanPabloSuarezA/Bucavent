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
using System.IO;

namespace Bucavent
{
    public partial class FormIconos : Form
    {
        public FormIconos()
        {
            InitializeComponent();
        }

        public FormAgregar formAgregar { get; set; }

        //Variables de personalización enviadas desde FormAgregarEvento
        public Color colorLetra = Color.FromName("ControlText");
        public Color colorFondo = Color.FromName("LemonChiffon");
        public Font tipoLetra = null;

        /// <summary>
        /// Se cambia la configuración de los controles de este form
        /// en base a las configuración de aspecto seleccionada por el usuario en el
        /// FormPersonalizacionAplicacion.      
        /// </summary> 

        public void Actualizar()
        {
            BackColor = colorFondo;

            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].ForeColor = colorLetra;
            }
            if (tipoLetra != null)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].Font = tipoLetra;
                }
            }
        }

        /// <summary>
        /// Se obtiene el nombre del archivo de la imagen, se envia al formAgregar y se
        /// llama al método Imagen() del formAgregar para actualizar el PictureBox con 
        /// esta imagen seleccionada.
        /// </summary>

        public void AsignarImagen(string img)
        {
            formAgregar.imagen = img;
            formAgregar.Show();
            formAgregar.Imagen();
            Close();
        }    
      
        private void picTrabajo_Click(object sender, EventArgs e)
        {
            AsignarImagen("trabajo.png");               
        }

        private void picCelebracion_Click(object sender, EventArgs e)
        {
            AsignarImagen("celebracion.jpg");
        }

        private void picOcio_Click(object sender, EventArgs e)
        {
            AsignarImagen("ocio.jpg");
        }

        private void picEstudio_Click(object sender, EventArgs e)
        {
            AsignarImagen("estudio.jpg");
        }

        private void picSocial_Click(object sender, EventArgs e)
        {
            AsignarImagen("social.png");
        }

        private void picArte_Click(object sender, EventArgs e)
        {
            AsignarImagen("arte.jpg");
        }

        private void picTecnologia_Click(object sender, EventArgs e)
        {
            AsignarImagen("tecnologia.jpg");
        }

        private void picMusica_Click(object sender, EventArgs e)
        {
            AsignarImagen("musica.png");
        }

        private void picDeporte_Click(object sender, EventArgs e)
        {
            AsignarImagen("deportes.jpg");
        }

        private void picCine_Click(object sender, EventArgs e)
        {
            AsignarImagen("cine.jpg");
        }

        /// <summary>
        /// Se permite al usuario seleccionar una imagen en su
        /// explorador de archivos y esta se agrega a la carpeta 
        /// de este proyecto para cargarla en el formAgregar.
        /// </summary>
       
        public bool AñadirImagen()
        {
            bool exito = true;

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Imagenes|*.png;*.jpg";
                openFileDialog1.Title = "Selecciona una imagen";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string img = @openFileDialog1.FileName;
                    DirectoryInfo directoryInfo = new DirectoryInfo(img);
                    string nombreImg = directoryInfo.Name;

                    try
                    {
                        File.Copy(img, Path.Combine(Application.StartupPath, @"iconos\" + nombreImg));
                        formAgregar.imagen = nombreImg;
                    }
                    catch (Exception)
                    {
                        formAgregar.imagen = nombreImg;
                    }

                    formAgregar.Show();
                    formAgregar.Imagen();
                    Close();
                }
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        private void btnIcono_Click(object sender, EventArgs e)
        {
            if (AñadirImagen() == false)
            {
                MessageBox.Show("Error al agregar imagen", "Mensaje indicativo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void FormIconos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAgregar.Show();
        }
    }
}
