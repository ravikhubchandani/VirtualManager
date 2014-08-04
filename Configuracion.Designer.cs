namespace Virtual_Manager
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.LConfig_Nick = new System.Windows.Forms.Label();
            this.TB_Config_Nick = new System.Windows.Forms.TextBox();
            this.LConfig_Email = new System.Windows.Forms.Label();
            this.TB_Config_EMail = new System.Windows.Forms.TextBox();
            this.BConfig_CambiarPass = new System.Windows.Forms.Button();
            this.BConfig_CambiarImg = new System.Windows.Forms.Button();
            this.CBConfig_Recordar = new System.Windows.Forms.CheckBox();
            this.BConfig_Aceptar = new System.Windows.Forms.Button();
            this.BConfig_Cancelar = new System.Windows.Forms.Button();
            this.OPFConfig_CambiarImg = new System.Windows.Forms.OpenFileDialog();
            this.PBConfig_Perfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfig_Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // LConfig_Nick
            // 
            this.LConfig_Nick.AutoSize = true;
            this.LConfig_Nick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfig_Nick.Location = new System.Drawing.Point(205, 20);
            this.LConfig_Nick.Name = "LConfig_Nick";
            this.LConfig_Nick.Size = new System.Drawing.Size(89, 15);
            this.LConfig_Nick.TabIndex = 1;
            this.LConfig_Nick.Text = "Nick de usuario";
            // 
            // TB_Config_Nick
            // 
            this.TB_Config_Nick.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Config_Nick.Location = new System.Drawing.Point(307, 17);
            this.TB_Config_Nick.Name = "TB_Config_Nick";
            this.TB_Config_Nick.Size = new System.Drawing.Size(169, 23);
            this.TB_Config_Nick.TabIndex = 1;
            this.TB_Config_Nick.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // LConfig_Email
            // 
            this.LConfig_Email.AutoSize = true;
            this.LConfig_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfig_Email.Location = new System.Drawing.Point(205, 46);
            this.LConfig_Email.Name = "LConfig_Email";
            this.LConfig_Email.Size = new System.Drawing.Size(41, 15);
            this.LConfig_Email.TabIndex = 4;
            this.LConfig_Email.Text = "E-Mail";
            // 
            // TB_Config_EMail
            // 
            this.TB_Config_EMail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Config_EMail.Location = new System.Drawing.Point(307, 43);
            this.TB_Config_EMail.Name = "TB_Config_EMail";
            this.TB_Config_EMail.Size = new System.Drawing.Size(169, 23);
            this.TB_Config_EMail.TabIndex = 2;
            this.TB_Config_EMail.TextChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // BConfig_CambiarPass
            // 
            this.BConfig_CambiarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfig_CambiarPass.Location = new System.Drawing.Point(208, 99);
            this.BConfig_CambiarPass.Name = "BConfig_CambiarPass";
            this.BConfig_CambiarPass.Size = new System.Drawing.Size(268, 23);
            this.BConfig_CambiarPass.TabIndex = 4;
            this.BConfig_CambiarPass.Text = "Cambiar Contraseña";
            this.BConfig_CambiarPass.UseVisualStyleBackColor = true;
            this.BConfig_CambiarPass.Click += new System.EventHandler(this.BConfig_CambiarPass_Click);
            // 
            // BConfig_CambiarImg
            // 
            this.BConfig_CambiarImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfig_CambiarImg.Location = new System.Drawing.Point(208, 70);
            this.BConfig_CambiarImg.Name = "BConfig_CambiarImg";
            this.BConfig_CambiarImg.Size = new System.Drawing.Size(268, 23);
            this.BConfig_CambiarImg.TabIndex = 3;
            this.BConfig_CambiarImg.Text = "Cambiar Imagen";
            this.BConfig_CambiarImg.UseVisualStyleBackColor = true;
            this.BConfig_CambiarImg.Click += new System.EventHandler(this.BConfig_CambiarImg_Click);
            // 
            // CBConfig_Recordar
            // 
            this.CBConfig_Recordar.AutoSize = true;
            this.CBConfig_Recordar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBConfig_Recordar.Location = new System.Drawing.Point(208, 129);
            this.CBConfig_Recordar.Name = "CBConfig_Recordar";
            this.CBConfig_Recordar.Size = new System.Drawing.Size(134, 19);
            this.CBConfig_Recordar.TabIndex = 5;
            this.CBConfig_Recordar.Text = "Recordar contraseña";
            this.CBConfig_Recordar.UseVisualStyleBackColor = true;
            this.CBConfig_Recordar.CheckedChanged += new System.EventHandler(this.ConfigChanged);
            // 
            // BConfig_Aceptar
            // 
            this.BConfig_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfig_Aceptar.Location = new System.Drawing.Point(320, 170);
            this.BConfig_Aceptar.Name = "BConfig_Aceptar";
            this.BConfig_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BConfig_Aceptar.TabIndex = 7;
            this.BConfig_Aceptar.Text = "Aceptar";
            this.BConfig_Aceptar.UseVisualStyleBackColor = true;
            this.BConfig_Aceptar.Click += new System.EventHandler(this.BConfig_Aceptar_Click);
            // 
            // BConfig_Cancelar
            // 
            this.BConfig_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BConfig_Cancelar.Location = new System.Drawing.Point(401, 170);
            this.BConfig_Cancelar.Name = "BConfig_Cancelar";
            this.BConfig_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BConfig_Cancelar.TabIndex = 6;
            this.BConfig_Cancelar.Text = "Cancelar";
            this.BConfig_Cancelar.UseVisualStyleBackColor = true;
            this.BConfig_Cancelar.Click += new System.EventHandler(this.BConfig_Cancelar_Click);
            // 
            // OPFConfig_CambiarImg
            // 
            this.OPFConfig_CambiarImg.FileName = "openFileDialog1";
            // 
            // PBConfig_Perfil
            // 
            this.PBConfig_Perfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBConfig_Perfil.ErrorImage = global::Virtual_Manager.Properties.Resources.derp;
            this.PBConfig_Perfil.Image = ((System.Drawing.Image)(resources.GetObject("PBConfig_Perfil.Image")));
            this.PBConfig_Perfil.Location = new System.Drawing.Point(13, 13);
            this.PBConfig_Perfil.Name = "PBConfig_Perfil";
            this.PBConfig_Perfil.Size = new System.Drawing.Size(167, 140);
            this.PBConfig_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBConfig_Perfil.TabIndex = 0;
            this.PBConfig_Perfil.TabStop = false;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(488, 205);
            this.Controls.Add(this.BConfig_Cancelar);
            this.Controls.Add(this.BConfig_Aceptar);
            this.Controls.Add(this.CBConfig_Recordar);
            this.Controls.Add(this.BConfig_CambiarImg);
            this.Controls.Add(this.BConfig_CambiarPass);
            this.Controls.Add(this.TB_Config_EMail);
            this.Controls.Add(this.LConfig_Email);
            this.Controls.Add(this.TB_Config_Nick);
            this.Controls.Add(this.LConfig_Nick);
            this.Controls.Add(this.PBConfig_Perfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBConfig_Perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBConfig_Perfil;
        private System.Windows.Forms.Label LConfig_Nick;
        private System.Windows.Forms.TextBox TB_Config_Nick;
        private System.Windows.Forms.Label LConfig_Email;
        private System.Windows.Forms.TextBox TB_Config_EMail;
        private System.Windows.Forms.Button BConfig_CambiarPass;
        private System.Windows.Forms.Button BConfig_CambiarImg;
        private System.Windows.Forms.CheckBox CBConfig_Recordar;
        private System.Windows.Forms.Button BConfig_Aceptar;
        private System.Windows.Forms.Button BConfig_Cancelar;
        private System.Windows.Forms.OpenFileDialog OPFConfig_CambiarImg;
    }
}