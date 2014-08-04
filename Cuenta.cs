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

namespace Virtual_Manager
{
   public  class Cuenta
    {
        /// <summary>
        /// Lista de listas, Lista de campos con listas de tareas
        /// </summary>
        public List<Campo> ListaCampos;

        //Tenemos la informacion sobre la configuracion del usuario en Globl.Config

       /// <summary>
       /// Constructor, crea una lista de listas de tareas
       /// </summary>
       /// <param name="Usuario">Nombre del usuario del que se quiere cargar la informacion</param>
        public Cuenta(string Usuario)
        {
            try
            {
                ListaCampos = new List<Campo>();
                foreach(string NombreCampo in Directory.EnumerateDirectories(@"Usuarios\" + Globl.Config.Usuario + @"\"))
                {
                    ListaCampos.Add(new Campo(Globl.Config.Usuario, NombreCampo.Substring(NombreCampo.LastIndexOf("\\") + 1)));
                }
            }
            catch (Exception)
            {
            }
        }

       /// <summary>
       /// Elimina todos los campos, antes elimina todas las tareas del campo
       /// </summary>
       /// <returns></returns>
        public bool Eliminar()
        {
            try
            {
                foreach (Campo C in ListaCampos)
                {
                    C.Eliminar(Globl.Config.Usuario);
                }
                ListaCampos = null;
                // Elimina su archivo de configuracion, directorio personal y si tiene, su imagen de perfil
                File.Delete(@"Usuarios\" + Globl.Config.Usuario + @"\config.dat");
                Directory.Delete(@"Usuarios\" + Globl.Config.Usuario + @"\");
                File.Delete(@"\Perfiles\" + Globl.Config.Usuario + ".png");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int getNumCampos()
        {
            if (ListaCampos == null)
                return 0;
            else return ListaCampos.Count;
        }
    }
}
