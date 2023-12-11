using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBucavent
{
    public class Rol
    {
        public Rol(string identificacion, string contraseña, int nivelAcceso)
        {
            Identificacion = identificacion;
            Contraseña = contraseña;
            NivelAcceso = nivelAcceso;
        }

        public string Identificacion { get; set; }
        public string Contraseña { get; set; }
        public int NivelAcceso { get; set; }

        public bool IniciarSesion()
        {
            bool exito = true;

            try
            {

                if (NivelAcceso == 2)
                {
                    StreamReader lector = File.OpenText("Administradores.config");                  

                    string lineas = lector.ReadLine();

                    while (lineas != null)
                    {
                        string identificacionGuardada = lineas.Split(';')[0];
                        string contraseñaGuardada = lineas.Split(';')[1];

                        if (Identificacion == identificacionGuardada && Contraseña == contraseñaGuardada)
                        {
                            exito = true;
                        }
                        else
                        {
                            exito = false;
                        }


                        if (exito == true)
                        {
                            break;
                        }

                        lineas = lector.ReadLine();


                    }
                    lector.Close();

                }

                if (NivelAcceso == 1)
                {
                    StreamReader lector = File.OpenText("Editores.config");

                    string lineas = lector.ReadLine();

                    while (lineas != null)
                    {
                        string identificacionGuardada = lineas.Split(';')[0];
                        string contraseñaGuardada = lineas.Split(';')[1];

                        if (Identificacion == identificacionGuardada && Contraseña == contraseñaGuardada)
                        {
                            exito = true;
                        }
                        else
                        {
                            exito = false;
                        }


                        if (exito == true)
                        {
                            break;
                        }

                        lineas = lector.ReadLine();


                    }
                    lector.Close();
                }
            
            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }


        public bool Registrar()
        {

            bool exito = true;

            try
            {

                if (NivelAcceso == 2)
                {
                    StreamWriter escritor = File.AppendText("Administradores.config");
                    escritor.Write(Identificacion);
                    escritor.Write(";" + Contraseña);
                    escritor.WriteLine();
                    escritor.Close(); 
                }
                else if (NivelAcceso == 1)
                {
                    StreamWriter escritor = File.AppendText("Editores.config");
                    escritor.Write(Identificacion);
                    escritor.Write(";" + Contraseña);
                    escritor.WriteLine();
                    escritor.Close();
                }

            }
            catch (Exception)
            {
                exito = false;
            }
            return exito;

        }

    }
}
