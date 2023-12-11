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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
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
            dataGridCategorias.BackgroundColor = formMenu.colorFondo;

            if (formMenu.actualizarLetra == true)
            {
                for (int i = 0; i < Controls.Count; i++)
                {
                    Controls[i].ForeColor = formMenu.colorLetra;
                }
                dataGridCategorias.ColumnHeadersDefaultCellStyle.BackColor = formMenu.colorLetra;
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

        // Lista para almacenar todas las categorias y borrar las que sean repetidas.
        List<string> ListaNombresNoRepetidos;

        /// <summary>
        /// Se añaden todos los temas existentes del archivo "Evento.csv"
        /// en el comboCategorias.
        /// </summary>

        public void AñadirNombres()
        {
            try
            {
                comboCategorias.Items.Clear();              
                string[] strAllLines = File.ReadAllLines("Evento.csv");
                File.WriteAllLines(Application.StartupPath + @"\Evento.csv", strAllLines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
                
                StreamReader LectorDeNombres = File.OpenText("Evento.csv");
                string titulo = LectorDeNombres.ReadLine();
                while (titulo != null)
                {                  
                    if (titulo.Replace(" ", "") != "")
                    {
                        comboCategorias.Items.Add(titulo.Split(';')[2]);
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
                comboCategorias.Items.Add("Todas");

                ListaNombresNoRepetidos = new List<string>();

                for (int i = 0; i < comboCategorias.Items.Count; i++)
                {
                    ListaNombresNoRepetidos.Add(comboCategorias.Items[i].ToString());
                }

                ListaNombresNoRepetidos = ListaNombresNoRepetidos.Distinct().ToList();
                comboCategorias.Items.Clear();

                for (int i = 0; i < ListaNombresNoRepetidos.Count; i++)
                {
                    comboCategorias.Items.Add(ListaNombresNoRepetidos[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar categorías de eventos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se cargan los datos de los eventos que contengan el tema
        /// seleccionado en el comboCategorias en el dataGridCategorias
        /// a partir del archivo "Evento.csv".
        /// </summary>

        public bool AñadirEventos()
        {
            bool exito = true;
            try
            {
                StreamReader reader = File.OpenText("Evento.csv");
                string lineas = reader.ReadLine();

                while (lineas != null)
                {
                    if (comboCategorias.SelectedItem.ToString() != "Todas")
                    {
                        if (lineas.Split(';')[2] == comboCategorias.SelectedItem.ToString())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridCategorias);
                            row.Cells[0].Value = lineas.Split(';')[0];
                            row.Cells[1].Value = lineas.Split(';')[1];
                            row.Cells[2].Value = lineas.Split(';')[9];
                            row.Cells[3].Value = lineas.Split(';')[3];
                            row.Cells[4].Value = lineas.Split(';')[4];
                            row.Cells[5].Value = lineas.Split(';')[5];
                            row.Cells[6].Value = lineas.Split(';')[6];
                            dataGridCategorias.Rows.Add(row);
                        }
                        lineas = reader.ReadLine();
                    }
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dataGridCategorias);
                        row.Cells[0].Value = lineas.Split(';')[0];
                        row.Cells[1].Value = lineas.Split(';')[1];
                        row.Cells[2].Value = lineas.Split(';')[9];
                        row.Cells[3].Value = lineas.Split(';')[3];
                        row.Cells[4].Value = lineas.Split(';')[4];
                        row.Cells[5].Value = lineas.Split(';')[5];
                        row.Cells[6].Value = lineas.Split(';')[6];
                        dataGridCategorias.Rows.Add(row);
                        lineas = reader.ReadLine();
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            AñadirNombres();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            formMenu.Show();           
        }

        private void FormCategorias_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMenu.Show();
        }

        /// <summary>
        /// Se limpia el dataGridCategorias y se llama al método Añadir eventos().
        /// </summary>

        private void comboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridCategorias.Rows.Clear();

            if (AñadirEventos() == false)
            {
                MessageBox.Show("Error al cargar eventos de la categoría seleccionada", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
