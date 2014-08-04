using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;

namespace Virtual_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(ReportError);

            // Creacion de carpetas necesarias para el programa
            if (Directory.Exists(@"Usuarios") == false)
                Directory.CreateDirectory(@"Usuarios");
            if (Directory.Exists(@"Perfiles") == false)
                Directory.CreateDirectory(@"Perfiles");            

            Inicio:
            Application.Run(new Inicio());
            // Solo debe ejecutar new Principal si se introduce correctamente el usuario y pass, si tiene
            if(Globl.Auntentificado)
                Application.Run(new Principal());
            // Si cierra sesion ya no esta auntenticado y se muestra la pantalla de inicio
            if (Globl.SesionCerrada)
                goto Inicio;
        }

        private static void ReportError(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Debe tener privilegios de lectura y escritura en el directorio de instalacion\n" +
                "Si tiene permiso para \"Ejecutar como administrador\", hágalo\n\n" +
                "El programa se va a cerrar ahora");
        }
    }
}
