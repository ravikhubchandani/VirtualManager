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
    public partial class CambiarPassword : Form
    {
        /// <summary>
        /// Indica si se pulsa Aceptar o Cancelar
        /// </summary>
        public bool Aceptado;

        /// <summary>
        /// Constructor, indicando si se quiere una contraseña nueva o cambiar la anterior
        /// </summary>
        /// <param name="PrimerPass">true si no se tenia contraseña antes</param>
        public CambiarPassword(bool PrimerPass)
        {
            InitializeComponent();
            Aceptado = false;

            if (PrimerPass)
            {
                TB_CambiarPass_Pass.Text = Globl.Config.PassMD5;
                TB_CambiarPass_Pass.Enabled = false;
            }
        }

        /// <summary>
        /// Realiza el cambio tras pulsar Aceptar
        /// </summary>
        private void B_CambiarPass_Aceptar_Click(object sender, EventArgs e)
        {
            // Comprueba la correctitud de los datos introducidos, primero verifica contraseña correcta y si no tiene
            // verifica que esta es vacio
            if ((Globl.getMD5(TB_CambiarPass_Pass.Text) == Globl.Config.PassMD5) || (Globl.getMD5("") == Globl.Config.PassMD5))
            {
                // Verifica que la nueva y su repeticion son iguales
                if (TB_CambiarPass_NPass1.Text == TB_CambiarPass_NPass2.Text)
                {
                    Globl.Config.PassMD5 = Globl.getMD5(TB_CambiarPass_NPass1.Text);
                    Aceptado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña repetida debe ser igual que la nueva contraseña", "Contraseñas no coincidentes",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_CambiarPass_NPass2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                B_CambiarPass_Aceptar_Click(sender, e);
        }

        private void C_CambiarPass_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
