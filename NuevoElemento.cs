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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Virtual_Manager
{
    public partial class NuevoElemento : Form
    {
        /// <summary>
        /// Indina el tipo de elemento, Usuario, Campo o Tarea
        /// </summary>
        private string _Elemento;

        /// <summary>
        /// Indica si se pulsa Aceptar o Cancelar
        /// </summary>
        public bool Aceptado = false;

        /// <summary>
        /// Indica la ruta completa, directorio y si es Tarea, tambien nombre del archivo
        /// </summary>
        private string _Ruta;

        /// <summary>
        /// Indica si el Elemento es un directorio o un archivo
        /// </summary>
        private bool _EsDirectorio;

        /// <summary>
        /// Constructor de elementos
        /// </summary>
        /// <param name="Ruta">Indica la ruta completa, directorio y si es Tarea, tambien nombre del archivo</param>
        /// <param name="EsDirectorio">Indica si el Elemento es un directorio o un archivo</param>
        public NuevoElemento(string Ruta, bool EsDirectorio)
        {
            InitializeComponent();
            _Ruta = Ruta;
            _EsDirectorio = EsDirectorio;
        }

        /// <summary>
        /// Tipo de nuevo elemento a crear
        /// </summary>
        /// <param name="Elemento">Nombre del tipo</param>
        public void setElemento(string Elemento)
        {
            L_NElemento_Nombre.Text += Elemento;
            _Elemento = Elemento;
        }

        /// <summary>
        /// Devuelve lo introducido por el usuario
        /// </summary>
        /// <returns>String</returns>
        public string getItem()
        {
            return TB_NElemento_Introducido.Text;
        }

        private void B_NElemento_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al pulsar Aceptar para crear el elemento
        /// </summary>
        private void B_NElemento_Aceptar_Click(object sender, EventArgs e)
        {
            // Comprueba que los nombres son validos
            Globl.RutaCorrecta(_Ruta + TB_NElemento_Introducido.Text, TB_NElemento_Introducido.Text, _Elemento, _EsDirectorio);
            if (Globl.ResultadoOp)
            {
                Aceptado = true;
                this.Close();
            }
        }

        private void TB_NElemento_Introducido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                B_NElemento_Aceptar_Click(sender, e);
        }
    }
}
