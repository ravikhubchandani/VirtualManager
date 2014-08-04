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
using System.Security.Cryptography;

namespace Virtual_Manager
{
    class Globl
    {
        /// <summary>
        /// Referencia a las 4 labels del navegador de campos
        /// </summary>
        public static Label[] CamposNavegador = new Label[4];

        /// <summary>
        /// Caracteres no permitidos para nombres de carpetas ni archivos
        /// </summary>
        public const string CharsProhibidos = "\\/:*?\"<>|";

        /// <summary>
        /// Indica si ha introducido correctamene su usuario y contraseña, sirve para saber que hacer en Program.cs
        /// </summary>
        public static bool Auntentificado = false;

        /// <summary>
        /// Indica si se viene de haber iniciado (y cerrado) una sesion anterior o si se acaba de abrir el programa
        /// sirve para saber que hacer en Program.cs
        /// </summary>
        public static bool SesionCerrada = false;

        /// <summary>
        /// sirve para devolver como resultado del void RutaCorrecta(), no se hizo con return porque si ocurre una excepcion
        /// tras manejar hay que devolver un resultado y no siempre se debe devolver sino mantener la ejecucion para reintentar
        /// </summary>
        public static bool ResultadoOp = false;

        /// <summary>
        /// Estructura del fichero de configuracion
        /// </summary>
        public class Configuracion
        {
            public string Usuario { get; set; }
            public string Nick { get; set; }
            public string EMail { get; set; }
            public string PassMD5 { get; set; }
            public bool ReqPass { get; set; }

            public Configuracion() { }
        }

        public static Configuracion Config = new Configuracion();

        /// <summary>
        /// Devuelve una ristra codificada en MD5 de otra ristra parámetro
        /// </summary>
        /// <param name="Password">Ristra para codificar</param>
        /// <returns>String</returns>
        public static string getMD5(string Password)
        {
            MD5 Codigo = MD5CryptoServiceProvider.Create();
            ASCIIEncoding Codificador = new ASCIIEncoding();
            StringBuilder Codificado = new StringBuilder();
            byte[] stream = Codigo.ComputeHash(Codificador.GetBytes(Password));
            for (int i = 0; i < stream.Length; i++)
            {
                Codificado.AppendFormat("{0:x2}", stream[i]);
            }
            return Codificado.ToString();
        }

        /// <summary>
        /// Convierte una ristra en formato u en DateTime teniendo en cuenta solo año, mes y dia
        /// </summary>
        /// <param name="uFormat">Ristra que representa un DateTime en formato u</param>
        /// <returns>DateTime</returns>
        public static DateTime ToDateTime(string uFormat)
        {
            string AuxS = uFormat.Substring(0, uFormat.IndexOf(" "));

            DateTime AuxD = new DateTime(Convert.ToInt32(uFormat.Substring(0, 4)),
                Convert.ToInt32(uFormat.Substring(5, 2)),
                Convert.ToInt32(uFormat.Substring(8, 2)));
            return AuxD;
        }

        /// <summary>
        /// Convierte fecha de formato YYYY-MM-DD a DD-MM-YYYY
        /// </summary>
        /// <param name="YYYY_MM_DD">Fecha para convertir</param>
        /// <returns>string</returns>
        public static string SpanishDateFormat(string YYYY_MM_DD)
        {
            short PrimerGuion = (short) YYYY_MM_DD.IndexOf("-");
            short SegundoGuion = (short) YYYY_MM_DD.LastIndexOf("-");
            return YYYY_MM_DD.Substring(SegundoGuion + 1) + " / " + YYYY_MM_DD.Substring(PrimerGuion + 1, 2) + " / " + YYYY_MM_DD.Substring(0, PrimerGuion);
        }

        /// <summary>
        /// Devuelve la encriptacion tipo "Cesar" equivalente a una ristra dada
        /// </summary>
        /// <param name="Mensaje">Ristra para encriptar</param>
        /// <param name="NumMagico">Numero en que basa la encriptacion</param>
        /// <returns>string</returns>
        public static string Encriptar(string Mensaje, short NumMagico)
        {
            if (Mensaje == "")
                return "";
            else if (Mensaje.Length == 1)
                return (Convert.ToInt32(Convert.ToChar(Mensaje)) + NumMagico).ToString();
            else
                return Convert.ToInt32(Convert.ToChar(Mensaje.Substring(0, 1)) + NumMagico).ToString() + " " + Encriptar(Mensaje.Substring(1), NumMagico);
        }

        /// <summary>
        /// Devuelve el mensaje legible equivalente al mensaje encriptado de tipo "Cesar"
        /// </summary>
        /// <param name="Mensaje">Ristra para desencriptar</param>
        /// <param name="NumMagico">Numero en que basa la desencriptacion</param>
        /// <returns>string</returns>
        public static string DesEncriptar(string Mensaje, short NumMagico)
        {
            if (Mensaje == "")
                return "";
            else if (Mensaje.IndexOf(" ") == -1)
                return ((char)(Convert.ToInt32(Mensaje) - NumMagico)).ToString();
            else
            {
                //string CarActual = Mensaje.Substring(0, Mensaje.IndexOf(" "));
                //string Resto = Mensaje.Substring(Mensaje.IndexOf(" ") + 1);
                //return ((char)(Convert.ToInt32(CarActual) - NumMagico)).ToString() + DesEncriptar(Resto, NumMagico);
                return ((char)(Convert.ToInt32(Mensaje.Substring(0, Mensaje.IndexOf(" "))) -
                    NumMagico)).ToString() + DesEncriptar(Mensaje.Substring(Mensaje.IndexOf(" ") + 1), NumMagico);
            }
        }

        /// <summary>
        /// Verifica la validez de un nombre para un elemento introducido por el usuario
        /// </summary>
        /// <param name="Ruta">Ruta para verificar</param>
        /// <param name="NElemento">Nombre del archivo que se crea</param>
        /// <param name="Elemento">Tipo de elemento, Usuario, Campo o Tarea</param>
        /// <param name="Operacion">Operacion a realizar, Usuario, Campo o Tarea</param>
        public static void RutaCorrecta(string Ruta, string NElemento, string Elemento, bool EsDirectorio)
        {
            try
            {
                ResultadoOp = false;
                // Nombre cadena vacia
                if (NElemento != "")
                {
                    // El elemento ya existe, no puede haber dos iguales
                    if(EsDirectorio && Directory.Exists(Ruta))
                    {
                        if (Ruta == ".")
                            throw new ArgumentException();
                        MessageBox.Show("\"" + NElemento + "\" ya existe", "Elija otro nombre",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (File.Exists(Ruta))
                    {
                        MessageBox.Show("\"" + NElemento + "\" ya existe", "Elija otro nombre",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        for (int i = 0; i < NElemento.Length; i++)
                        {
                            if (Globl.CharsProhibidos.Contains(NElemento.Substring(i, 1)))
                                throw new ArgumentException();
                        }
                        ResultadoOp = true;
                    }

                }
                else
                    MessageBox.Show("El nombre no puede estar vacío", "Nombre no válido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tiene permiso para crear el elemento", "No puede crear un nuevo elemento",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("El nombre introducido no es válido", "Nombre no válido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
