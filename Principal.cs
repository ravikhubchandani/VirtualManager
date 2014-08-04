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
using System.Net;
using System.Net.Mail;
using System.Media;

namespace Virtual_Manager
{
    public partial class Principal : Form
    {
        /// <summary>
        /// Indica en que pagina del navegador se encuentra, empieza en 0
        /// </summary>
        private int _NumPagina;

        /// <summary>
        /// Indica numero de paginas que tiene el navegador
        /// </summary>
        private int _TotalPaginas;

        /// <summary>
        /// Indica el campo al que se quiere acceder en la pagina actual
        /// </summary>
        private int _Desplazamiento;

        /// <summary>
        /// Guarda informacion de configuracion de usuario, todos los campos con todas sus tareas
        /// </summary>
        private Cuenta Sesion;

        /// <summary>
        /// Constructor que carga la informacion para empezar a trabajar
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            // Haciendo un new de Cuenta estamos cargando toda la informacion sobre campos y sus tareas
            Sesion = new Cuenta(Globl.Config.Usuario);
            if (Globl.Config.Nick != "")
                this.Text = Globl.Config.Nick + this.Text;
            else
                this.Text = Globl.Config.Usuario + this.Text;
            _Desplazamiento = _NumPagina = 0;
            _TotalPaginas = ((int) Math.Ceiling(Sesion.getNumCampos() / 4.0) - 1);
        }

        /// <summary>
        /// Inicia los datos mostrados en el navegador
        /// </summary>
        private void Principal_Load(object sender, EventArgs e)
        {
            Globl.CamposNavegador[0] = L_Principal_Campo1;
            Globl.CamposNavegador[1] = L_Principal_Campo2;
            Globl.CamposNavegador[2] = L_Principal_Campo3;
            Globl.CamposNavegador[3] = L_Principal_Campo4;

            ReiniciarNombreCampos();
            L_Principal_NombreCampo.Text = "";
            DGV_Principal_Tareas.Tag = null;
            MostrarCampos();
            ActualizarContextualTarea();
        }

        /// <summary>
        /// Resta en uno la pagina actual del navegador y muestra los campos en esta
        /// </summary>
        private void PB_Principal_Prev_Click(object sender, EventArgs e)
        {
            if (_NumPagina > 0)
            {
                _NumPagina--;
                MostrarCampos();
            }
        }

        /// <summary>
        /// Aumenta en uno la pagina actual del navegador y muestra los campos en esta
        /// </summary>
        private void PB_Principal_Next_Click(object sender, EventArgs e)
        {
            if (_NumPagina < _TotalPaginas)
            {
                _NumPagina++;
                MostrarCampos();
            }
        }

        /// <summary>
        /// Muestra los campos de la pagina actual en el navegador
        /// </summary>
        private void MostrarCampos()
        {
            ReiniciarNombreCampos();

            // Solo hace falta hacer algo si hay campos
            if (Sesion.ListaCampos != null)
            {                
                int i = 0;
                // Es importante multiplicar por 4 porque en cada pagina hay 4 campos, para sincronizar el desplazamiento
                // en la lista de tareas
                while ((Sesion.ListaCampos.Count > (_NumPagina*4 + i)) && (i < 4))
                {                    
                    Globl.CamposNavegador[i].Text = Sesion.ListaCampos.ElementAt(_NumPagina*4 + i).Nombre;
                    if (Globl.CamposNavegador[i].Text.Length > 15)
                        Globl.CamposNavegador[i].Text = Globl.CamposNavegador[i].Text.Substring(0, 15);
                    Globl.CamposNavegador[i].Visible = true;
                    i++;
                };
            }
        }

        /// <summary>
        /// Deja vacios e invisibles los campos no usados o al recargar una pagina, para no mostrar cosas que momentaneamente
        /// no son ciertas
        /// </summary>
        private void ReiniciarNombreCampos()
        {
            // Aqui no poner a "" el L_Principal_NombreCampo porque al hacer MostrarCampos() al crear nuevo campo o desplazar el navegador
            // quita el nombre del campo que se esta viendo y no hay que hacer eso
            for (int i = 0; i < 4; i++)
            {
                Globl.CamposNavegador[i].Text = "";
                Globl.CamposNavegador[i].Visible = false;
            }
        }

        /// <summary>
        /// Rellena la DataGridView con la lista de tareas del campo seleccionado
        /// </summary>
        private void RellenarTablaTareas()
        {
            int i = 0;
            string AuxFecha;
            int TareasCompletadas = 0;

            DGV_Principal_Tareas.Rows.Clear();
            foreach (Tarea T in Sesion.ListaCampos.ElementAt(_NumPagina*4 + _Desplazamiento).ListaTareas)
            {
                DGV_Principal_Tareas.Rows.Add();
                DGV_Principal_Tareas[0, i].Value = T.Nombre;

                AuxFecha = T.FechaFin.ToString("u");
                DGV_Principal_Tareas[1, i].Value = Globl.SpanishDateFormat(AuxFecha.Substring(0, AuxFecha.IndexOf(" ")));

                DGV_Principal_Tareas[2, i].Value = T.Completada;
                if (T.Completada)
                    TareasCompletadas++;

                i++;
            }

            L_Principal_TTotal.Text = "Total tareas: " + i.ToString();
            L_Principal_TareasCompletadas.Text = "Tareas completadas: " + TareasCompletadas.ToString();
            if(TareasCompletadas != 0)
                L_Principal_Productividad.Text = "Productividad: " + (((float)TareasCompletadas / (float)i * 100.0)).ToString("F2") + " %";
            else L_Principal_Productividad.Text = "Productividad: 0 %";
        }

        private void L_Principal_Campo1_Click(object sender, EventArgs e)
        {
            _Desplazamiento = 0;
            L_Principal_NombreCampo.Text = Sesion.ListaCampos.ElementAt(_NumPagina * 4).Nombre;
            CambiarCampoMostrado();
        }

        private void L_Principal_Campo2_Click(object sender, EventArgs e)
        {
            _Desplazamiento = 1;
            L_Principal_NombreCampo.Text = Sesion.ListaCampos.ElementAt(_NumPagina * 4 + 1).Nombre;
            CambiarCampoMostrado();
        }

        private void L_Principal_Campo3_Click(object sender, EventArgs e)
        {
            _Desplazamiento = 2;
            L_Principal_NombreCampo.Text = Sesion.ListaCampos.ElementAt(_NumPagina * 4 + 2).Nombre;
            CambiarCampoMostrado();
        }

        private void L_Principal_Campo4_Click(object sender, EventArgs e)
        {
            _Desplazamiento = 3;
            L_Principal_NombreCampo.Text = Sesion.ListaCampos.ElementAt(_NumPagina * 4 + 3).Nombre;
            CambiarCampoMostrado();
        }

        private void CambiarCampoMostrado()
        {
            RellenarTablaTareas();
            DGV_Principal_Tareas.Tag = Sesion.ListaCampos.ElementAt(_NumPagina * 4 + _Desplazamiento);
        }

        /// <summary>
        /// Al pulsar sobre el boton para crear una nueva tarea
        /// </summary>
        private void PB_Principal_NTarea_Click(object sender, EventArgs e)
        {
            if (DGV_Principal_Tareas.Tag == null)
            {
                MessageBox.Show("Selecciona primero un campo", "Campo no seleccionado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    // En NuevaTarea.cs se encarga de comprobar si el nombre es valido
                    NuevaTarea CrearTarea = new NuevaTarea((Campo)DGV_Principal_Tareas.Tag);
                    CrearTarea.ShowDialog();
                    if (CrearTarea.Aceptado)
                    {
                        RellenarTablaTareas();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// Al pulsar sobre el boton de crear un nuevo campo
        /// </summary>
        private void PB_Principal_Campo_Click(object sender, EventArgs e)
        {
            NuevoElemento CrearCampo = new NuevoElemento(@"Usuarios\" + Globl.Config.Usuario + @"\", true);
            CrearCampo.Text += "Campo";
            CrearCampo.setElemento("de campo");
            CrearCampo.ShowDialog();

            if (CrearCampo.Aceptado)
            {
                // En Campo.cs se encarga de comprobar si el nombre es valido
                if (Campo.Guardar(Globl.Config.Usuario, CrearCampo.getItem()))
                {
                    Sesion.ListaCampos.Add(new Campo(Globl.Config.Usuario, CrearCampo.getItem()));
                    // Hay que comprobar si es necesario añadir una pagina nueva al navegador
                    _TotalPaginas = ((int)Math.Ceiling(Sesion.getNumCampos() / 4.0) - 1);
                    MostrarCampos();
                    ActualizarContextualTarea();
                }       
            }
        }

        private void L_Principal_NTarea_Click(object sender, EventArgs e)
        {
            PB_Principal_NTarea_Click(sender, e);
        }

        private void L_Principal_NCampo_Click(object sender, EventArgs e)
        {
            PB_Principal_Campo_Click(sender, e);
        }

        /// <summary>
        /// Al pulsar sobre el boton para ver detalles de una tarea
        /// </summary>
        private void L_Principal_VDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                int FilaSeleccionada = DGV_Principal_Tareas.CurrentCell.RowIndex;

                // Se le pasa directamente el enlace en la lista, para poder guardar cambios en fichero y en la lista
                //con el mismo objeto, si fuera necesario
                VerDetalles DetallesTarea = new VerDetalles(((Campo)DGV_Principal_Tareas.Tag).ListaTareas.ElementAt(FilaSeleccionada),
                    ((Campo)DGV_Principal_Tareas.Tag).Nombre);
                DetallesTarea.ShowDialog();

                // Recarga datos si estos han sido modificados
                if (DetallesTarea.TModificada)
                {
                    RellenarTablaTareas();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Al pulsar sobre el boton de Eliminar una tarea
        /// </summary>
        private void L_Principal_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int FilaSeleccionada = DGV_Principal_Tareas.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Eliminar \"" + ((Campo)DGV_Principal_Tareas.Tag).ListaTareas.ElementAt(FilaSeleccionada).Nombre + "\"?",
                    "Eliminar tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // En Tarea.Eliminar se elimina de disco
                    if (((Campo)DGV_Principal_Tareas.Tag).ListaTareas.ElementAt(FilaSeleccionada).Eliminar(Globl.Config.Usuario,
                        ((Campo)DGV_Principal_Tareas.Tag).Nombre))
                    {
                        // Se elimina de memoria
                        ((Campo)DGV_Principal_Tareas.Tag).ListaTareas.RemoveAt(FilaSeleccionada);
                        // Y se recargan datos de memoria en la tabla
                        RellenarTablaTareas();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void DGV_Principal_Tareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                // Editar
                case 3:
                    {
                        L_Principal_VDetalles_Click(sender, e);
                        break;
                    }
                // Eliminar
                case 4:
                    {
                        L_Principal_Eliminar_Click(sender, e);
                        break;
                    }
            }
        }

        private void DGV_Principal_Tareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            L_Principal_VDetalles_Click(sender, e);
        }

        private void DGV_Principal_Tareas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Editar
                case Keys.Enter:
                    {
                        L_Principal_VDetalles_Click(sender, e);
                        break;
                    }
                // Eliminar
                case Keys.Delete:
                    {
                        L_Principal_Eliminar_Click(sender, e);
                        break;
                    }
            }
        }

        private void L_Principal_VerTodo_Click(object sender, EventArgs e)
        {
            // Hay que comprobar porque se puede clickar en todo momento, no se ejecuta solo cuando hay campos en el navegador
            if(DGV_Principal_Tareas.Tag != null)
                RellenarTablaTareas();
        }

        /// <summary>
        /// Al pulsar sobre algun boton de ver con opciones de dias
        /// </summary>
        /// <param name="DiasPasados">Ver informacion de tareas con maximo de dias</param>
        private void RellenarConTiempo(int DiasPasados)
        {
            int i = 0;
            string AuxFecha;
            int TareasCompletadas = 0;
            DateTime LimiteAntiguo = DateTime.Now.Subtract(new TimeSpan(DiasPasados, 0, 0, 0));

            
            DGV_Principal_Tareas.Rows.Clear();
            foreach (Tarea T in Sesion.ListaCampos.ElementAt(_NumPagina * 4 + _Desplazamiento).ListaTareas)
            {
                // Solo se incluye si lo creado hace DiasPasados dias es mas reciente
                if (T.FechaCreacion > LimiteAntiguo)
                {
                    DGV_Principal_Tareas.Rows.Add();
                    DGV_Principal_Tareas[0, i].Value = T.Nombre;

                    AuxFecha = T.FechaFin.ToString("u");
                    DGV_Principal_Tareas[1, i].Value = Globl.SpanishDateFormat(AuxFecha.Substring(0, AuxFecha.IndexOf(" ")));

                    DGV_Principal_Tareas[2, i].Value = T.Completada;
                    if (T.Completada)
                        TareasCompletadas++;

                    i++;
                }
            }

            L_Principal_TTotal.Text = "Total tareas: " + i.ToString();
            L_Principal_TareasCompletadas.Text = "Tareas completadas: " + TareasCompletadas.ToString();
            if (TareasCompletadas != 0)
                L_Principal_Productividad.Text = "Productividad: " + (((float)TareasCompletadas / (float)i * 100.0)).ToString("F2") + " %";
            else L_Principal_Productividad.Text = "Productividad: 0 %";
        }

        private void L_Principal_Semana_Click(object sender, EventArgs e)
        {
            // Hay que comprobar porque se puede clickar en todo momento, no se ejecuta solo cuando hay campos en el navegador
            if(DGV_Principal_Tareas.Tag != null)
                RellenarConTiempo(7);
        }

        private void L_Principal_Mes_Click(object sender, EventArgs e)
        {
            // Hay que comprobar porque se puede clickar en todo momento, no se ejecuta solo cuando hay campos en el navegador
            if(DGV_Principal_Tareas.Tag != null)
                RellenarConTiempo(30);
        }

        /// <summary>
        /// Al pulsar sobre el boton para enviar recordatorio via email
        /// </summary>
        private void L_Principal_Recordatorio_Click(object sender, EventArgs e)
        {
            try
            {
                int FilaSeleccionada = DGV_Principal_Tareas.CurrentCell.RowIndex;

                if (MessageBox.Show("¿Enviar recordatorio para \"" + ((Campo)DGV_Principal_Tareas.Tag).ListaTareas.ElementAt(FilaSeleccionada).Nombre + "\"?",
                    "Enviar recordatorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Globl.Config.EMail == "")
                        MessageBox.Show("Debe proporcionar una dirección de correo electrónico", "No hay dirección de e-mail",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        Tarea TSel = ((Campo)DGV_Principal_Tareas.Tag).ListaTareas.ElementAt(FilaSeleccionada);
                        string FAux = TSel.FechaFin.ToString("u");

                        FAux = Globl.SpanishDateFormat(FAux.Substring(0, FAux.IndexOf(" ")));
                        MailMessage EMail = new MailMessage("recordatoriosvirtual@gmail.com", Globl.Config.EMail,
                            "Recuerda: " + TSel.Nombre + ", el dia " + FAux, TSel.Descripcion);

                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Credentials = new NetworkCredential("recordatoriosvirtual@gmail.com", "asidedurosoyyo");
                        smtp.Send(EMail);

                        SystemSounds.Asterisk.Play();
                    }
                }
            }
            catch (SmtpException)
            {
                MessageBox.Show("No se pudo enviar el recordatorio\nRevise la conexión a Internet", "Error de conexión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("La dirección de correo debe ser válida", "Dirección no válida",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                if(DGV_Principal_Tareas.Tag != null)
                MessageBox.Show("No se pudo enviar debido a un error desconocido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Al pulsar el boton para crear un nuevo usuario, en el menu Archivo
        /// </summary>
        private void nuevoUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // En NuevoElemento se encarga de verificar si el nombre de usuario introducido es correcto
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
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

        /// <summary>
        /// Al cerrar sesion
        /// </summary>
        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Necesario para saber que hacer en Program.cs
            Globl.Auntentificado = false;
            Globl.SesionCerrada = true;
            this.Close();
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuracion Preferencias = new Configuracion();
            Preferencias.ShowDialog();

            // El usuario puede que haya insertado un nick
            if (Globl.Config.Nick != "")
                this.Text = Globl.Config.Nick + " - Virtual Manager";
            else
                this.Text = Globl.Config.Usuario + " - Virtual Manager";

            Preferencias.Dispose();
        }

        private void nuevoCampoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PB_Principal_Campo_Click(sender, e);
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch(_Desplazamiento)
            {
                case 0:
                    {
                        L_Principal_Campo1_Click(sender, e);
                        break;
                    }
                case 1:
                    {
                        L_Principal_Campo2_Click(sender, e);
                        break;
                    }
                case 2:
                    {
                        L_Principal_Campo3_Click(sender, e);
                        break;
                    }
                case 3:
                    {
                        L_Principal_Campo4_Click(sender, e);
                        break;
                    }
            }
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Principal_VDetalles_Click(sender, e);
        }

        private void eliminarTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Principal_Eliminar_Click(sender, e);
        }

        private void recibirRecordatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Principal_Recordatorio_Click(sender, e);
        }

        private void nuevaTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PB_Principal_NTarea_Click(sender, e);
        }

        private void L_Principal_Campo1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _Desplazamiento = 0;
        }

        private void L_Principal_Campo2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _Desplazamiento = 1;
        }

        private void L_Principal_Campo3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _Desplazamiento = 2;
        }

        private void L_Principal_Campo4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _Desplazamiento = 3;
        }

        private void nuevoCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PB_Principal_Campo_Click(sender, e);
        }

        /// <summary>
        /// Cambia el nombre de un campo
        /// </summary>
        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoElemento CambioNombreCampo = new NuevoElemento(@"Usuarios\" + Globl.Config.Usuario + @"\", true);
                CambioNombreCampo.Text = "Cambiar nombre";
                CambioNombreCampo.setElemento(" nuevo");
                CambioNombreCampo.ShowDialog();

                if (CambioNombreCampo.Aceptado)
                {
                    Sesion.ListaCampos.ElementAt(_NumPagina * 4 + _Desplazamiento).Modificar(Globl.Config.Usuario, CambioNombreCampo.getItem());

                    if (CambioNombreCampo.getItem().Length > 15)
                        Globl.CamposNavegador[_Desplazamiento].Text = CambioNombreCampo.getItem().Substring(0, 15);
                    else
                        Globl.CamposNavegador[_Desplazamiento].Text = CambioNombreCampo.getItem();

                    ActualizarContextualTarea();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Elimina un campo, elimina antes todas las tareas
        /// </summary>
        private void eliminarCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Eliminar \"" + Globl.CamposNavegador[_Desplazamiento].Text + "\"?", "Eliminar campo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sesion.ListaCampos.ElementAt(_NumPagina * 4 + _Desplazamiento).Eliminar(Globl.Config.Usuario);                    
                    _TotalPaginas = ((int)Math.Ceiling(Sesion.getNumCampos() / 4.0) - 1);

                    // Si coincide que el campo eliminado es el que se ve actualmente
                    if (L_Principal_NombreCampo.Text == (Sesion.ListaCampos.ElementAt(_NumPagina * 4 + _Desplazamiento).Nombre))
                    {
                        L_Principal_NombreCampo.Text = "";
                        DGV_Principal_Tareas.Rows.Clear();
                        DGV_Principal_Tareas.Tag = null;
                    }
                    Sesion.ListaCampos.RemoveAt(_NumPagina * 4 + _Desplazamiento);

                    MostrarCampos();
                    ActualizarContextualTarea();

                    L_Principal_TTotal.Text = "Total tareas: ";
                    L_Principal_TareasCompletadas.Text = "Tareas completas: ";
                    L_Principal_Productividad.Text = "Productividad: ";
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informacion info = new Informacion();
            info.ShowDialog();
        }

        private void nuevaTareaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            L_Principal_NombreCampo.Text = Globl.CamposNavegador[_Desplazamiento].Text;
            CambiarCampoMostrado();
            PB_Principal_NTarea_Click(sender, e);
        }

        /// <summary>
        /// Actualiza la lista de campos "Mover a" del menu contextual CMS_Principal_Tarea
        /// </summary>
        private void ActualizarContextualTarea()
        {
            moverAToolStripMenuItem.DropDownItems.Clear();
            if (Sesion.ListaCampos.Count > 0)
            {
                ToolStripItem[] ListaC = new ToolStripItem[Sesion.ListaCampos.Count];
                for (int i = 0; i < Sesion.ListaCampos.Count; i++)
                {
                    ListaC[i] = new ToolStripMenuItem(Sesion.ListaCampos.ElementAt(i).Nombre);
                    ListaC[i].Tag = Sesion.ListaCampos.ElementAt(i);
                }
                moverAToolStripMenuItem.DropDownItems.AddRange(ListaC);
            }
        }

        /// <summary>
        /// Evento que ocurre al seleccionar el campo al que se quiere mover una tarea
        /// </summary>
        private void moverAToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Campo CampoNuevo = ((Campo)e.ClickedItem.Tag);
                Campo CampoViejo = ((Campo)DGV_Principal_Tareas.Tag);

                if (CampoNuevo != CampoViejo)
                {
                    int FilaSel = DGV_Principal_Tareas.CurrentCell.RowIndex;
                    int UltimoElem = CampoNuevo.ListaTareas.Count;

                    // Copiar en memoria del viejo al nuevo
                    CampoNuevo.ListaTareas.Add(CampoViejo.ListaTareas.ElementAt(FilaSel));

                    int CodigoOP = CampoNuevo.ListaTareas.ElementAt(UltimoElem).Guardar(Globl.Config.Usuario, CampoNuevo.Nombre);
                    // Guardar en disco en el nuevo            
                    if (CodigoOP == 0)
                    {
                        // Ya esta en disco, ahora del viejo, borrar de disco y LUEGO memoria porque si borramos de memoria luego no se
                        // puede hacer Eliminar de la tarea para borrar de disco
                        CampoViejo.ListaTareas.ElementAt(FilaSel).Eliminar(Globl.Config.Usuario, CampoViejo.Nombre);
                        CampoViejo.ListaTareas.RemoveAt(FilaSel);

                        RellenarTablaTareas();
                    }
                    else
                    {
                        // Como no se ha podido guardar en disco, hay que borrarlo de memoria
                        CampoNuevo.ListaTareas.RemoveAt(UltimoElem);
                        CMS_Principal_Tarea.Close();

                        if (CodigoOP == 1)
                            MessageBox.Show("Ya existe una tarea con el mismo nombre, cambielo y " +
                                "vuelva a intentar", "No se puede mover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        else
                            MessageBox.Show("No se pudo mover la tarea", "No se puede mover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
            }
            catch(Exception)
            {
                //TODO
            }
        }
    }
}
