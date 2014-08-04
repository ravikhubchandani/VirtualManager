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

using System.IO;

using System.Windows.Forms;

namespace Virtual_Manager
{
    public class Campo
    {
        /// <summary>
        /// Nombre del campo
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Lista de instancias de tareas
        /// </summary>
        public List<Tarea> ListaTareas;

        /// <summary>
        /// Constructor vacío de un nuevo campo
        /// </summary>
        public Campo() { }

        /// <summary>
        /// Constructor de un nuevo campo, especificando el usuario y nombre de campo
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado</param>
        /// <param name="Campo">Nombre del campo asociado al usuario</param>
        public Campo(string Usuario, string Campo)
        {
            Nombre = Campo;
            ListaTareas = new List<Tarea>();

            FileStream stream;
            BinaryReader reader;
            string FCreacion;
            string FFin;
            string NTarea;
            string Descripcion;
            short Desplazamiento = 4;
            bool Completa;

            foreach (string NombreTarea in Directory.EnumerateFiles(@"Usuarios\" + Usuario + @"\" + Campo))
            {
                try
                {
                    stream = new FileStream(NombreTarea, FileMode.Open);
                    reader = new BinaryReader(stream);
                    Desplazamiento = reader.ReadInt16();
                    FCreacion = reader.ReadString();
                    FFin = reader.ReadString();
                    Completa = reader.ReadBoolean();
                    Descripcion = reader.ReadString();
                    Descripcion = Globl.DesEncriptar(Descripcion, Desplazamiento);

                    NTarea = NombreTarea.Substring(NombreTarea.LastIndexOf("\\") + 1);
                    NTarea = NTarea.Substring(0, NTarea.IndexOf("."));
                    ListaTareas.Add(new Tarea(NTarea, Desplazamiento, Globl.ToDateTime(FCreacion),
                        Globl.ToDateTime(FFin), Completa, Descripcion));

                    reader.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        /// <summary>
        /// Crea un nuevo directorio asociado a un nuevo campo
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado</param>
        /// <returns>bool</returns>
        public static bool Guardar(string Usuario, string Campo)
        {
            try
            {
                Directory.CreateDirectory(@"Usuarios\" + Usuario + @"\" + Campo);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Elimina todas las tareas de un campo y luego elimina el mismo
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado</param>
        /// <returns>bool</returns>
        public bool Eliminar(string Usuario)
        {
            try
            {
                foreach (Tarea T in ListaTareas)
                {
                    T.Eliminar(Globl.Config.Usuario, Nombre);
                }
                ListaTareas = null;
                Directory.Delete(@"Usuarios\" + Usuario + @"\" + Nombre);

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Cambia el nombre a un campo especificando el usuario y el nuevo nombre
        /// </summary>
        /// <param name="Usuario">Nombre del usuario asociado</param>
        /// <param name="Nuevo">Nuevo nombre para el campo</param>
        /// <returns>bool</returns>
        public bool Modificar(string Usuario, string Nuevo)
        {
            try
            {
                Directory.Move(@"Usuarios\" + Usuario + @"\" + Nombre, @"Usuarios\" + Usuario + @"\" + Nuevo);
                Nombre = Nuevo;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int getNumTareas()
        {
            return ListaTareas.Count;
        }
    }
}
