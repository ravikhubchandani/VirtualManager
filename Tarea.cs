/*
 *****************************************************************
 * Autor: Ravi Khubchandani
 * Fecha de creacion: 2012-09-08
 * Ultima modificacion: 
 * Autor Ultima modificacion: 
 * Version 1.0
 *****************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace Virtual_Manager
{
    public class Tarea
    {
        /// <summary>
        /// Nombre de la tarea
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Desplazamiento de caracteres al codificar
        /// </summary>
        public short Desplazamiento { get; set; }

        /// <summary>
        /// Fecha de creacion de la tarea
        /// </summary>
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Fecha cuando expira la tarea
        /// </summary>
        public DateTime FechaFin { get; set; }

        /// <summary>
        /// La tarea ha sido completada
        /// </summary>
        public bool Completada { get; set; }

        /// <summary>
        /// Resumen de lo que trata de hacerse en la tarea
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Constructor vacio de una nueva tarea
        /// </summary>
        public Tarea() { }

        /// <summary>
        /// Constructor de una nueva tarea con todos sus parametros
        /// </summary>
        /// <param name="NombreTarea">Nombre de la tarea</param>
        /// <param name="FechaCreacion">Fecha de creacion de la tarea</param>
        /// <param name="FechaFin">Fecha cuando expira la tarea</param>
        /// <param name="Descripcion">Resumen de lo que trata de hacerse en la tarea</param>
        public Tarea(string NombreTarea, short Despl, DateTime Creacion, DateTime Fin, bool Completo, string Desc)
        {
            try
            {
                Nombre = NombreTarea;
                Desplazamiento = Despl;
                FechaCreacion = Creacion;
                FechaFin = Fin;
                Completada = Completo;
                Descripcion = Desc;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido crear la tarea por el siguiente motivo\n" + e.ToString(), "No se ha podido crear la tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Crea en disco un archivo para una tarea nueva
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado a tarea</param>
        /// <param name="Campo">Nombre del campo asociado a tarea</param>
        /// <returns>int</returns>
        public int Guardar(string Usuario, string Campo)
        {
            try
            {
                if (File.Exists(@"Usuarios\" + Usuario + @"\" + Campo + @"\" + Nombre + ".dat") == false)
                {
                    FileStream stream = new FileStream(@"Usuarios\" + Usuario + @"\" + Campo + @"\" + Nombre + ".dat", FileMode.Create);
                    BinaryWriter writer = new BinaryWriter(stream);                    
                    

                    writer.Write(Desplazamiento);
                    writer.Write(FechaCreacion.ToString("u"));
                    writer.Write(FechaFin.ToString("u"));
                    // El formato u devuelve YYYY-MM-DD HH:MM:SS

                    writer.Write(Completada);
                    writer.Write(Globl.Encriptar(Descripcion, Desplazamiento));
                    writer.Close();
                    return 0;
                }

                else return 1;
            }
            catch (Exception)
            {
                return 2;
            }
        }

        /// <summary>
        /// Elimina de disco el archivo relacionado a una tarea existente
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado a tarea</param>
        /// <param name="Campo">Nombre del campo asociado a tarea</param>
        /// <returns>bool</returns>
        public bool Eliminar(string Usuario, string Campo)
        {
            try
            {
                File.Delete(@"Usuarios\" + Usuario + @"\" + Campo + @"\" + Nombre + ".dat");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Actualiza en disco el archivo relacionado a una tarea existente
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado a tarea</param>
        /// <param name="Campo">Nombre del campo asociado a tarea</param>
        /// <returns>bool</returns>
        public bool Modificar(string Usuario, string Campo)
        {
            try
            {
                if (Eliminar(Usuario, Campo))
                {
                    if (Guardar(Usuario, Campo) == 0)
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
