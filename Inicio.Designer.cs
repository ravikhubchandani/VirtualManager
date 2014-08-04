namespace Virtual_Manager
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.P_Inicio = new System.Windows.Forms.Panel();
            this.L_Inicio_Nick = new System.Windows.Forms.Label();
            this.PB_Inicio_ImgPerfil = new System.Windows.Forms.PictureBox();
            this.MS_Inicio = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.L_Inicio_Nombre = new System.Windows.Forms.Label();
            this.L_Inicio_Pass = new System.Windows.Forms.Label();
            this.CB_Inicio_Nombre = new System.Windows.Forms.ComboBox();
            this.TB_Inicio_Pass = new System.Windows.Forms.TextBox();
            this.B_Inicio_Aceptar = new System.Windows.Forms.Button();
            this.CB_Inicio_Recordar = new System.Windows.Forms.CheckBox();
            this.B_Inicio_Nuevo = new System.Windows.Forms.Button();
            this.P_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Inicio_ImgPerfil)).BeginInit();
            this.MS_Inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Inicio
            // 
            this.P_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P_Inicio.Controls.Add(this.L_Inicio_Nick);
            this.P_Inicio.Controls.Add(this.PB_Inicio_ImgPerfil);
            this.P_Inicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_Inicio.Location = new System.Drawing.Point(0, 24);
            this.P_Inicio.Name = "P_Inicio";
            this.P_Inicio.Size = new System.Drawing.Size(275, 418);
            this.P_Inicio.TabIndex = 0;
            // 
            // L_Inicio_Nick
            // 
            this.L_Inicio_Nick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Inicio_Nick.AutoEllipsis = true;
            this.L_Inicio_Nick.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Inicio_Nick.ForeColor = System.Drawing.Color.Navy;
            this.L_Inicio_Nick.Location = new System.Drawing.Point(50, 237);
            this.L_Inicio_Nick.Name = "L_Inicio_Nick";
            this.L_Inicio_Nick.Size = new System.Drawing.Size(167, 37);
            this.L_Inicio_Nick.TabIndex = 1;
            this.L_Inicio_Nick.Text = "Nick";
            this.L_Inicio_Nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Inicio_ImgPerfil
            // 
            this.PB_Inicio_ImgPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_Inicio_ImgPerfil.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PB_Inicio_ImgPerfil.ErrorImage")));
            this.PB_Inicio_ImgPerfil.Image = ((System.Drawing.Image)(resources.GetObject("PB_Inicio_ImgPerfil.Image")));
            this.PB_Inicio_ImgPerfil.Location = new System.Drawing.Point(50, 81);
            this.PB_Inicio_ImgPerfil.Name = "PB_Inicio_ImgPerfil";
            this.PB_Inicio_ImgPerfil.Size = new System.Drawing.Size(167, 140);
            this.PB_Inicio_ImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Inicio_ImgPerfil.TabIndex = 0;
            this.PB_Inicio_ImgPerfil.TabStop = false;
            // 
            // MS_Inicio
            // 
            this.MS_Inicio.BackColor = System.Drawing.Color.White;
            this.MS_Inicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MS_Inicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.MS_Inicio.Location = new System.Drawing.Point(0, 0);
            this.MS_Inicio.Name = "MS_Inicio";
            this.MS_Inicio.Size = new System.Drawing.Size(584, 24);
            this.MS_Inicio.TabIndex = 1;
            this.MS_Inicio.Text = "Inicio";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // L_Inicio_Nombre
            // 
            this.L_Inicio_Nombre.AutoSize = true;
            this.L_Inicio_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Inicio_Nombre.Location = new System.Drawing.Point(319, 139);
            this.L_Inicio_Nombre.Name = "L_Inicio_Nombre";
            this.L_Inicio_Nombre.Size = new System.Drawing.Size(51, 15);
            this.L_Inicio_Nombre.TabIndex = 2;
            this.L_Inicio_Nombre.Text = "Nombre";
            // 
            // L_Inicio_Pass
            // 
            this.L_Inicio_Pass.AutoSize = true;
            this.L_Inicio_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Inicio_Pass.Location = new System.Drawing.Point(319, 181);
            this.L_Inicio_Pass.Name = "L_Inicio_Pass";
            this.L_Inicio_Pass.Size = new System.Drawing.Size(67, 15);
            this.L_Inicio_Pass.TabIndex = 3;
            this.L_Inicio_Pass.Text = "Contraseña";
            // 
            // CB_Inicio_Nombre
            // 
            this.CB_Inicio_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Inicio_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Inicio_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Inicio_Nombre.FormattingEnabled = true;
            this.CB_Inicio_Nombre.Location = new System.Drawing.Point(426, 136);
            this.CB_Inicio_Nombre.Name = "CB_Inicio_Nombre";
            this.CB_Inicio_Nombre.Size = new System.Drawing.Size(121, 23);
            this.CB_Inicio_Nombre.TabIndex = 4;
            this.CB_Inicio_Nombre.SelectedValueChanged += new System.EventHandler(this.CB_Inicio_Nombre_SelectedValueChanged);
            // 
            // TB_Inicio_Pass
            // 
            this.TB_Inicio_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Inicio_Pass.Location = new System.Drawing.Point(426, 178);
            this.TB_Inicio_Pass.Name = "TB_Inicio_Pass";
            this.TB_Inicio_Pass.PasswordChar = '*';
            this.TB_Inicio_Pass.Size = new System.Drawing.Size(121, 23);
            this.TB_Inicio_Pass.TabIndex = 5;
            this.TB_Inicio_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Inicio_Pass_KeyDown);
            // 
            // B_Inicio_Aceptar
            // 
            this.B_Inicio_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Inicio_Aceptar.Location = new System.Drawing.Point(472, 225);
            this.B_Inicio_Aceptar.Name = "B_Inicio_Aceptar";
            this.B_Inicio_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_Inicio_Aceptar.TabIndex = 7;
            this.B_Inicio_Aceptar.Text = "Aceptar";
            this.B_Inicio_Aceptar.UseVisualStyleBackColor = true;
            this.B_Inicio_Aceptar.Click += new System.EventHandler(this.B_Inicio_Aceptar_Click);
            // 
            // CB_Inicio_Recordar
            // 
            this.CB_Inicio_Recordar.AutoSize = true;
            this.CB_Inicio_Recordar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Inicio_Recordar.Location = new System.Drawing.Point(322, 229);
            this.CB_Inicio_Recordar.Name = "CB_Inicio_Recordar";
            this.CB_Inicio_Recordar.Size = new System.Drawing.Size(90, 19);
            this.CB_Inicio_Recordar.TabIndex = 6;
            this.CB_Inicio_Recordar.Text = "Recordarme";
            this.CB_Inicio_Recordar.UseVisualStyleBackColor = true;
            // 
            // B_Inicio_Nuevo
            // 
            this.B_Inicio_Nuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Inicio_Nuevo.Location = new System.Drawing.Point(447, 395);
            this.B_Inicio_Nuevo.Name = "B_Inicio_Nuevo";
            this.B_Inicio_Nuevo.Size = new System.Drawing.Size(100, 23);
            this.B_Inicio_Nuevo.TabIndex = 8;
            this.B_Inicio_Nuevo.Text = "Nuevo Usuario";
            this.B_Inicio_Nuevo.UseVisualStyleBackColor = true;
            this.B_Inicio_Nuevo.Click += new System.EventHandler(this.B_Inicio_Nuevo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.B_Inicio_Nuevo);
            this.Controls.Add(this.CB_Inicio_Recordar);
            this.Controls.Add(this.B_Inicio_Aceptar);
            this.Controls.Add(this.TB_Inicio_Pass);
            this.Controls.Add(this.CB_Inicio_Nombre);
            this.Controls.Add(this.L_Inicio_Pass);
            this.Controls.Add(this.L_Inicio_Nombre);
            this.Controls.Add(this.P_Inicio);
            this.Controls.Add(this.MS_Inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Inicio;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Manager";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.P_Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Inicio_ImgPerfil)).EndInit();
            this.MS_Inicio.ResumeLayout(false);
            this.MS_Inicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_Inicio;
        private System.Windows.Forms.PictureBox PB_Inicio_ImgPerfil;
        private System.Windows.Forms.MenuStrip MS_Inicio;
        private System.Windows.Forms.Label L_Inicio_Nombre;
        private System.Windows.Forms.Label L_Inicio_Pass;
        private System.Windows.Forms.ComboBox CB_Inicio_Nombre;
        private System.Windows.Forms.TextBox TB_Inicio_Pass;
        private System.Windows.Forms.Button B_Inicio_Aceptar;
        private System.Windows.Forms.CheckBox CB_Inicio_Recordar;
        private System.Windows.Forms.Button B_Inicio_Nuevo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label L_Inicio_Nick;
    }
}

