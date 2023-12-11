using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bucavent;

namespace Bucavent.Controles_de_Usuario
{
    public partial class CasillaCalendario : UserControl
    {
        public CasillaCalendario()
        {
            InitializeComponent();
        }

        //Variables de personalización
        public Color colorLetra = Color.FromName("ControlText");
        public Color colorFondo = Color.FromName("LemonChiffon");
        public Font tipoLetra = null;
        public bool actualizarLetra = false;

        /// <summary>
        /// Se aplican las variables de personalización 
        /// al objeto FormHorario creado
        /// </summary>

        private void lblFecha_Click(object sender, EventArgs e)
        {
            FormHorario horario = new FormHorario();
            horario.casilla = this;
            horario.Actualizar();
            horario.fechaExacta = lblFechaExacta.Text;
            horario.TopLevel = true;
            horario.ShowDialog();
        }

        private void CasillaCalendario_Load(object sender, EventArgs e)
        {
            lblFecha.ForeColor = colorLetra;
            if (tipoLetra != null)
            {
                lblFecha.Font = tipoLetra;
                lblFecha.Font = new Font(lblFecha.Font.Name, lblFecha.Font.Size + 32); 
            }
        }
    }
}
