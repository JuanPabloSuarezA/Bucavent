using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBucavent
{
    public class Evento
    {
        
        public Evento()
        {

        }

        public Evento(string nombre, string lugar, string tema, int precio, DateTime fecha, DateTime horaInicio, DateTime horaFin, string nombreImagen, string urlEvento, string direccion, string creador)
        {
            Nombre = nombre;
            Lugar = lugar;
            Tema = tema;
            Precio = precio;
            Fecha = fecha;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
            NombreImagen = nombreImagen;
            UrlEvento = urlEvento;
            Direccion = direccion;
            Creador = creador;
        }

        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string Tema { get; set; }
        public int Precio { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string NombreImagen { get; set; }
        public string UrlEvento { get; set; }
        public string Direccion { get; set; }
        public string Creador { get; set; }

        public bool Guardar()
        {
            bool exito = true;

            try
            {
                StreamWriter escritor = File.AppendText("Evento.csv");
                escritor.Write(Nombre);
                escritor.Write(";" + Lugar);
                escritor.Write(";" + Tema);         
                escritor.Write(";" + Precio);         
                if (Fecha.ToShortDateString().Substring(0) == "0")
                {
                    escritor.Write(";" + Fecha.ToShortDateString().Substring(1)); 
                }
                else
                {
                    escritor.Write(";" + Fecha.ToShortDateString());
                }
                escritor.Write(";" + HoraInicio.ToShortTimeString());
                escritor.Write(";" + HoraFin.ToShortTimeString());
                escritor.Write(";" + NombreImagen);
                escritor.Write(";" + UrlEvento);
                escritor.Write(";" + Direccion);
                escritor.Write(";" + Creador);
                escritor.WriteLine();
                escritor.Close();

            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;
        }
    }
}
