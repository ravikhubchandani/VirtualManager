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

namespace Virtual_Manager
{
    public partial class VerDetalles : Form
    {
        /// <summary>
        /// Referencia a tarea de la que se quieren ver detalles
        /// </summary>
        private Tarea _Tarea;

        /// <summary>
        /// Nombre del campo al que pertenece la tarea
        /// </summary>
        private string _Campo;

        /// <summary>
        /// Indica si se ha cambiado o no algun dato, saber si modificar en disco o no es necesario
        /// </summary>
        public bool TModificada;

        /// <summary>
        /// Constructor para ver detalles de tareas
        /// </summary>
        /// <param name="T">Tarea de la que se quieren ver detalles</param>
        /// <param name="C">Campo al que pertenece la tarea</param>
        public VerDetalles(Tarea T, string C)
        {
            InitializeComponent();
            _Tarea = T;
            _Campo = C;
            TModificada = false;
        }

        private void B_VDetalles_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Se pulsa el boton de Aceptar para guardar
        /// </summary>
        private void B_VDetalles_Guardar_Click(object sender, EventArgs e)
        {
            // Solo es necesario guardar en disco si algo ha sido modificado
            if(TModificada)
            {
                _Tarea.FechaFin = DTP_VDetalles_FFin.Value;
                _Tarea.Completada = CB_VDetalles_TareaCompleta.Checked;                

                Random DivisorAleatorio = new Random();
                short Desplazamiento = (short)DivisorAleatorio.Next(0, 65535);

                _Tarea.Desplazamiento = Desplazamiento;
                _Tarea.Descripcion = TB_VDetalles_Descripcion.Text;

                // Modificar solo porque el nombre de archivo es igual
                if (_Tarea.Nombre == TB_VDetalles_Nombre.Text)
                {
                    _Tarea.Modificar(Globl.Config.Usuario, _Campo);
                }
                else
                {
                // El nombre de archivo cambia, borrar el antiguo y crear uno nuevo
                    _Tarea.Eliminar(Globl.Config.Usuario, _Campo);
                    _Tarea.Nombre = TB_VDetalles_Nombre.Text;
                    _Tarea.Guardar(Globl.Config.Usuario, _Campo);
                }
            }
            this.Close();
        }

        private void DTP_VDetalles_FFin_ValueChanged(object sender, EventArgs e)
        {
            TModificada = true;
        }

        private void CB_VDetalles_TareaCompleta_CheckedChanged(object sender, EventArgs e)
        {
            TModificada = true;
        }

        /// <summary>
        /// Carga la informacion para mostrar de la tarea
        /// </summary>
        private void VerDetalles_Load(object sender, EventArgs e)
        {
            string AuxFecha = _Tarea.FechaCreacion.ToString("u");
            L_VDetalles_FCreacion.Text = Globl.SpanishDateFormat(AuxFecha.Substring(0, AuxFecha.IndexOf(" ")));
            DTP_VDetalles_FFin.Value = _Tarea.FechaFin;
            CB_VDetalles_TareaCompleta.Checked = _Tarea.Completada;
            TB_VDetalles_Nombre.Text = _Tarea.Nombre;
            TB_VDetalles_Descripcion.Text = _Tarea.Descripcion;
        }

        private void TB_VDetalles_Nombre_TextChanged(object sender, EventArgs e)
        {
            TModificada = true;
        }

        private void TB_VDetalles_Descripcion_TextChanged(object sender, EventArgs e)
        {
            TModificada = true; 
        }
    }
}
