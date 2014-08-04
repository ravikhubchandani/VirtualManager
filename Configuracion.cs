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
    public partial class Configuracion : Form
    {
        /// <summary>
        /// Indica si se ha modificado algun campo de configuracion
        /// </summary>
        private bool _CModificada;

        /// <summary>
        /// Indica si se ha cambiado la imagen de perfil, hay que actualizarla
        /// </summary>
        private bool _ImgCambiada;

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Configuracion()
        {
            InitializeComponent();
            // Hay dos indicadores porque si cambia una cosa no hace falta cambiar la otra
            _CModificada = false;
            _ImgCambiada = false;
        }

        private void BConfig_Cancelar_Click(object sender, EventArgs e)
        {
            // Es necesario hacer dispose porque aunque salgamos el archivo se queda como abierto
            PBConfig_Perfil.Image.Dispose();
            PBConfig_Perfil.Dispose();
            this.Close();
        }

        /// <summary>
        /// Al pulsar el boton de Aceptar, para guardar cambios de configuracion
        /// </summary>
        private void BConfig_Aceptar_Click(object sender, EventArgs e)
        {
            // Solo hace falta guardar cambios si se ha modificado un dato
            if(_CModificada)
            {
                Globl.Config.Nick = TB_Config_Nick.Text;
                Globl.Config.EMail = TB_Config_EMail.Text;
                Globl.Config.ReqPass = CBConfig_Recordar.Checked;

                FileStream stream = new FileStream(@"Usuarios\" + Globl.Config.Usuario + @"\config.dat", FileMode.Create);
                BinaryWriter writer = new BinaryWriter(stream);

                writer.Write(Globl.Config.Nick);
                writer.Write(Globl.Config.EMail);
                writer.Write(Globl.Config.PassMD5);
                writer.Write(Globl.Config.ReqPass);

                writer.Close();
            }
            if(_ImgCambiada)
            {
                File.Delete(@"Perfiles\" + Globl.Config.Usuario + ".png");
                File.Copy(OPFConfig_CambiarImg.FileName, @"Perfiles\" + Globl.Config.Usuario + ".png");
            }

            PBConfig_Perfil.Image.Dispose();
            PBConfig_Perfil.Dispose();
            this.Close();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            TB_Config_Nick.Text = Globl.Config.Nick;
            TB_Config_EMail.Text = Globl.Config.EMail;
            CBConfig_Recordar.Checked = Globl.Config.ReqPass;

            if (Globl.getMD5("") == Globl.Config.PassMD5)
                BConfig_CambiarPass.Text = "Proteger mediante contraseña";

            // Si no tiene cambiada la imagen de perfil se muestra la de por defecto
            if(File.Exists(@"Perfiles\" + Globl.Config.Usuario + ".png"))
                PBConfig_Perfil.Load(@"Perfiles\" + Globl.Config.Usuario + ".png");
        }

        private void BConfig_CambiarImg_Click(object sender, EventArgs e)
        {
            OPFConfig_CambiarImg = new OpenFileDialog();
            OPFConfig_CambiarImg.Filter = "Images (*.BMP;*.JPG;*.JPEG;*.PNG;*.TIFF;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.TIFF;*.GIF|All files (*.*)|*.*";
            OPFConfig_CambiarImg.Multiselect = false;
            OPFConfig_CambiarImg.RestoreDirectory = true;

            if (OPFConfig_CambiarImg.ShowDialog() == DialogResult.OK)
            {
                PBConfig_Perfil.Image.Dispose();
                PBConfig_Perfil.Image = new Bitmap(OPFConfig_CambiarImg.FileName);
                _ImgCambiada = true;
            }

            OPFConfig_CambiarImg.Dispose();
        }

        private void ConfigChanged(object sender, EventArgs e)
        {
            _CModificada = true;
        }

        private void BConfig_CambiarPass_Click(object sender, EventArgs e)
        {
            CambiarPassword CambioPass;
            if (Globl.getMD5("") == Globl.Config.PassMD5)
                CambioPass = new CambiarPassword(true);                
            else
                CambioPass = new CambiarPassword(false);
            CambioPass.ShowDialog();

            if (CambioPass.Aceptado)
            {
                BConfig_CambiarPass.Text = "Cambiar contraseña";
            }
        }
    }
}
