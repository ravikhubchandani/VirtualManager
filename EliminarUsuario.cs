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
    public partial class EliminarUsuario : Form
    {
        /// <summary>
        /// Indica si se ha pulsado el boton de Aceptar o Cancelar
        /// </summary>
        public bool Aceptado;

        public EliminarUsuario()
        {
            InitializeComponent();
            Aceptado = false;
        }

        /// <summary>
        /// Rellena el combobox para elegir usuario
        /// </summary>
        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (string RutaUsuario in Directory.GetDirectories(@"Usuarios"))
                {
                    // Se trata de ir añadiendo uno por uno solo el nombre, ej "Usuarios\Ravi" en "Ravi"
                    CB_EUsuario_Nombre.Items.Add(RutaUsuario.Substring(RutaUsuario.IndexOf("\\") + 1));
                }
            }

            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Al cambiar de usuario hay que cambiar los datos propios
        /// </summary>
        private void CB_EUsuario_Nombre_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FileStream stream = new FileStream(@"Usuarios\" + CB_EUsuario_Nombre.SelectedItem.ToString() + @"\config.dat", FileMode.Open);
                BinaryReader reader = new BinaryReader(stream);

                // Es importante mantener este orden, es el orden en que el fichero fue escrito
                Globl.Config.Usuario = CB_EUsuario_Nombre.SelectedItem.ToString();
                Globl.Config.Nick = reader.ReadString();
                Globl.Config.EMail = reader.ReadString();
                Globl.Config.PassMD5 = reader.ReadString();
                Globl.Config.ReqPass = reader.ReadBoolean();

                if (Globl.Config.PassMD5 == Globl.getMD5(""))
                {
                    TB_EUsuario_Pass.Text = "";
                    TB_EUsuario_Pass.Enabled = false;
                }

                else if (Globl.Config.ReqPass)
                {
                    TB_EUsuario_Pass.Text = Globl.Config.PassMD5;
                    TB_EUsuario_Pass.Enabled = false;
                }

                reader.Close();
            }
            catch (Exception)
            {
            }
        }

        private void B_EUsuario_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pulsa Aceptar para iniciar la sesion
        /// </summary>
        private void B_EUsuario_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Comprueba si los datos introducidos con correctos
                if ((Globl.Config.PassMD5 == Globl.getMD5(TB_EUsuario_Pass.Text)) || Globl.Config.ReqPass)
                {
                    // Elimina CADA tarea para CADA campo perteneciente al usuario
                    foreach (string Campos in Directory.EnumerateDirectories(@"Usuarios\" + Globl.Config.Usuario + @"\"))
                    {
                        foreach (string Tarea in Directory.EnumerateFiles(Campos))
                        {
                            File.Delete(Tarea);
                        }
                        Directory.Delete(Campos);
                    }
                    // Por ultimo elimina el fichero de configuracion su directorio y si tiene, su imagen de perfil
                    File.Delete(@"Usuarios\" + Globl.Config.Usuario + @"\config.dat");
                    Directory.Delete(@"Usuarios\" + Globl.Config.Usuario);
                    File.Delete(@"Perfiles\" + Globl.Config.Usuario + ".png");
                    Aceptado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Contraseña incorrecta",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }                
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.ToString());
            }
        }

        private void TB_EUsuario_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                B_EUsuario_Aceptar_Click(sender, e);
        }
    }
}
