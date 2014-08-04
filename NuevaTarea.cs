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
    public partial class NuevaTarea : Form
    {
        /// <summary>
        /// Referencia al campo sobre el que se crea la tarea
        /// </summary>
        private Campo _Obj;

        public bool Aceptado;

        public NuevaTarea(Campo TagCampo)
        {
            InitializeComponent();
            _Obj = TagCampo;
            Aceptado = false;
        }

        private void B_NTarea_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al pulsar Aceptar para crear la nueva tarea
        /// </summary>
        private void B_NTarea_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mira si la ruta y el nombre son validos
                Globl.RutaCorrecta(@"Usuarios\" + Globl.Config.Usuario + @"\" + _Obj.Nombre + @"\" + TB_NTarea_Nombre.Text + ".dat",
                    TB_NTarea_Nombre.Text, "La tarea", false);

                if (Globl.ResultadoOp)
                {
                    Random DivisorAleatorio = new Random();
                    short Desplazamiento = (short) DivisorAleatorio.Next(0, 65535);

                    // La tarea se guarda en disco
                    Tarea AuxT = new Tarea(TB_NTarea_Nombre.Text, Desplazamiento, DateTime.Now, DTP_VDetalles_FFin.Value, false, TB_NTarea_Descripcion.Text);
                    AuxT.Guardar(Globl.Config.Usuario, _Obj.Nombre);
                    // y tambien se guarda en memoria
                    _Obj.ListaTareas.Add(AuxT);

                    Aceptado = true;
                    this.Close();
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }        
    }
}
