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
    public partial class Inicio : Form
    {
        /// <summary>
        /// Imagen que guarda la imagen de perfil por defecto, que es derp
        /// </summary>
        private Image _PerfilInicial;

        /// <summary>
        /// Constructor, asigna los datos iniciales vacios
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            _PerfilInicial = PB_Inicio_ImgPerfil.Image;
            L_Inicio_Nick.Text = "";
        }

        /// <summary>
        /// Al pulsar el boton para crear un nuevo usuario
        /// </summary>
        private void B_Inicio_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // En NuevoElemento.cs ya se encarga de mirar si los datos son correctos
                NuevoElemento NuevoUsuario = new NuevoElemento(@"Usuarios\", true);
                // Forma "Nuevo Usuario"
                NuevoUsuario.Text += "Usuario";
                // Forma "Nombre de usuario"
                NuevoUsuario.setElemento("de usuario");

                NuevoUsuario.ShowDialog();

                if (NuevoUsuario.Aceptado)
                {
                    Directory.CreateDirectory(@"Usuarios\" + NuevoUsuario.getItem());

                    // Hay que crear un fichero de configuracion
                    FileStream stream = new FileStream(@"Usuarios\" + NuevoUsuario.getItem() + @"\config.dat", FileMode.Create);
                    BinaryWriter writer = new BinaryWriter(stream);

                    writer.Write("");
                    writer.Write("");
                    writer.Write(Globl.getMD5(""));
                    writer.Write(true);

                    writer.Close();

                    // Al crear un nuevo usuario hay que añadir a la lista de usuarios
                    CB_Inicio_Nombre.Items.Add(NuevoUsuario.getItem());

                    if (CB_Inicio_Nombre.Items.Count == 1)
                    {
                        CB_Inicio_Nombre.SelectedIndex = 0;
                        CargarInfoUsuario();
                    }
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

        /// <summary>
        /// Al pulsar Aceptar para iniciar sesion
        /// </summary>
        private void B_Inicio_Aceptar_Click(object sender, EventArgs e)
        {
            if (CB_Inicio_Nombre.Items.Count != 0)
            {
                // Comprobar usuario y contraseña
                if ((Globl.Config.PassMD5 == Globl.getMD5(TB_Inicio_Pass.Text)) || Globl.Config.ReqPass)
                {
                    if ((Globl.Config.ReqPass && CB_Inicio_Recordar.Checked == false) || (Globl.Config.ReqPass == false && CB_Inicio_Recordar.Checked))
                    {
                        // Hay que crear un fichero de configuracion nuevo porque ha cambiado la configuracion
                        FileStream stream = new FileStream(@"Usuarios\" + CB_Inicio_Nombre.SelectedItem.ToString() + @"\config.dat", FileMode.Create);
                        BinaryWriter writer = new BinaryWriter(stream);

                        writer.Write(Globl.Config.Nick);
                        writer.Write(Globl.Config.EMail);
                        writer.Write(Globl.Config.PassMD5);
                        writer.Write(CB_Inicio_Recordar.Checked);

                        writer.Close();
                    }

                    Globl.Auntentificado = true;
                    PB_Inicio_ImgPerfil.Image.Dispose();
                    PB_Inicio_ImgPerfil.Dispose();
                    this.Close();
                }
                else if (CB_Inicio_Nombre.SelectedIndex < 0)
                {
                    MessageBox.Show("Debe elegir un usuario", "Elija usuario",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta", "Contraseña incorrecta",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        /// <summary>
        /// Cosas basicas para empezar a funcionar, lo mas basico es cargar la lista de usuarios en combobox con CargarUsuarios()
        /// </summary>
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Importante ponerlo por si se viene de cerrar una sesion anterior
            Globl.Auntentificado = false;
            CargarUsuarios();

            // Cuando solo hay un usuario su informacion se carga automaticamente porque al cambiar el selectedindex
            // ocurre el evento selectedvaluechanged
            if (CB_Inicio_Nombre.Items.Count == 1)
            {   
                CB_Inicio_Nombre.SelectedIndex = 0;
                CargarInfoUsuario();

                if (((Globl.Config.PassMD5 == Globl.getMD5("")) || (Globl.Config.ReqPass)) && (Globl.SesionCerrada != true))
                {
                    Globl.Auntentificado = true;
                    this.Close();
                }                
            }
            Globl.SesionCerrada = false;
        }

        /// <summary>
        /// Carga lista de usuarios en el combobox, coge todos los directorios de usuarios
        /// </summary>
        private void CargarUsuarios()
        {
            try
            {
                foreach (string RutaUsuario in Directory.GetDirectories(@"Usuarios"))
                {
                    // Se trata de ir añadiendo uno por uno solo el nombre, ej "Usuarios\Ravi" en "Ravi"
                    CB_Inicio_Nombre.Items.Add(RutaUsuario.Substring(RutaUsuario.IndexOf("\\") + 1));
                }
            }

            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Al cambiar de usuario del combobox
        /// </summary>
        private void CB_Inicio_Nombre_SelectedValueChanged(object sender, EventArgs e)
        {
            // No necesario si hay mas de uno, ademas de que antes se realizan algunas comprobaciones
            if (CB_Inicio_Nombre.Items.Count > 1)
            {
                CargarInfoUsuario();
                if (File.Exists(@"Perfiles\" + Globl.Config.Usuario + ".png"))
                    PB_Inicio_ImgPerfil.Load(@"Perfiles\" + Globl.Config.Usuario + ".png");

                else if (PB_Inicio_ImgPerfil.Image != _PerfilInicial)
                    // La comprobacion permite no volver a recargar la imagen de perfil por defecto que ya esta cargada
                    PB_Inicio_ImgPerfil.Image = _PerfilInicial;
            }
        }

        private void TB_Inicio_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) B_Inicio_Aceptar_Click(sender, e);
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B_Inicio_Nuevo_Click(sender, e);
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarUsuario Eliminar = new EliminarUsuario();                
                Eliminar.ShowDialog();                

                if(Eliminar.Aceptado)
                {
                    CB_Inicio_Nombre.Items.Clear();
                    CargarUsuarios();
                    if (CB_Inicio_Nombre.Items.Count == 1)
                    {
                        CB_Inicio_Nombre.SelectedIndex = 0;
                        CargarInfoUsuario();
                    }
                    else if (CB_Inicio_Nombre.Items.Count == 0)
                    {
                        L_Inicio_Nick.Text = "";
                        PB_Inicio_ImgPerfil.Image = _PerfilInicial;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Carga en memoria los datos del usuario seleccionado en el combobox
        /// </summary>
        private void CargarInfoUsuario()
        {
            FileStream stream = new FileStream(@"Usuarios\" + CB_Inicio_Nombre.SelectedItem.ToString() + @"\config.dat", FileMode.Open);
            BinaryReader reader = new BinaryReader(stream);

            // Es importante mantener este orden, es el orden en que el fichero fue escrito
            Globl.Config.Usuario = CB_Inicio_Nombre.SelectedItem.ToString();
            Globl.Config.Nick = reader.ReadString();
            Globl.Config.EMail = reader.ReadString();
            Globl.Config.PassMD5 = reader.ReadString();
            CB_Inicio_Recordar.Checked = Globl.Config.ReqPass = reader.ReadBoolean();

            if (File.Exists(@"Perfiles\" + CB_Inicio_Nombre.SelectedItem.ToString() + ".png"))
                PB_Inicio_ImgPerfil.Load(@"Perfiles\" + CB_Inicio_Nombre.SelectedItem.ToString() + ".png");
            else
                PB_Inicio_ImgPerfil.Image = _PerfilInicial;

            if (Globl.Config.Nick != "")
                L_Inicio_Nick.Text = Globl.Config.Nick;
            else
                L_Inicio_Nick.Text = Globl.Config.Usuario;

            if (Globl.Config.PassMD5 == Globl.getMD5(""))
            {
                TB_Inicio_Pass.Text = "";
                TB_Inicio_Pass.Enabled = false;
                CB_Inicio_Recordar.Enabled = false;
            }

            else if (Globl.Config.ReqPass)
            {
                TB_Inicio_Pass.Text = Globl.Config.PassMD5;
                TB_Inicio_Pass.Enabled = false;
            }

            reader.Close();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PB_Inicio_ImgPerfil.Image.Dispose();
            PB_Inicio_ImgPerfil.Dispose();
            this.Close();
        }
    }
}
