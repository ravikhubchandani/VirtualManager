namespace Virtual_Manager
{
    partial class EliminarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.L_EUsuario_Nombre = new System.Windows.Forms.Label();
            this.L_EUsuario_Pass = new System.Windows.Forms.Label();
            this.CB_EUsuario_Nombre = new System.Windows.Forms.ComboBox();
            this.TB_EUsuario_Pass = new System.Windows.Forms.TextBox();
            this.B_EUsuario_Aceptar = new System.Windows.Forms.Button();
            this.B_EUsuario_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_EUsuario_Nombre
            // 
            this.L_EUsuario_Nombre.AutoSize = true;
            this.L_EUsuario_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EUsuario_Nombre.Location = new System.Drawing.Point(13, 24);
            this.L_EUsuario_Nombre.Name = "L_EUsuario_Nombre";
            this.L_EUsuario_Nombre.Size = new System.Drawing.Size(51, 15);
            this.L_EUsuario_Nombre.TabIndex = 0;
            this.L_EUsuario_Nombre.Text = "Nombre";
            // 
            // L_EUsuario_Pass
            // 
            this.L_EUsuario_Pass.AutoSize = true;
            this.L_EUsuario_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EUsuario_Pass.Location = new System.Drawing.Point(12, 50);
            this.L_EUsuario_Pass.Name = "L_EUsuario_Pass";
            this.L_EUsuario_Pass.Size = new System.Drawing.Size(67, 15);
            this.L_EUsuario_Pass.TabIndex = 1;
            this.L_EUsuario_Pass.Text = "Contraseña";
            // 
            // CB_EUsuario_Nombre
            // 
            this.CB_EUsuario_Nombre.BackColor = System.Drawing.SystemColors.Window;
            this.CB_EUsuario_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_EUsuario_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_EUsuario_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_EUsuario_Nombre.FormattingEnabled = true;
            this.CB_EUsuario_Nombre.Location = new System.Drawing.Point(94, 16);
            this.CB_EUsuario_Nombre.Name = "CB_EUsuario_Nombre";
            this.CB_EUsuario_Nombre.Size = new System.Drawing.Size(178, 23);
            this.CB_EUsuario_Nombre.TabIndex = 2;
            this.CB_EUsuario_Nombre.SelectedValueChanged += new System.EventHandler(this.CB_EUsuario_Nombre_SelectedValueChanged);
            // 
            // TB_EUsuario_Pass
            // 
            this.TB_EUsuario_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_EUsuario_Pass.Location = new System.Drawing.Point(94, 52);
            this.TB_EUsuario_Pass.Name = "TB_EUsuario_Pass";
            this.TB_EUsuario_Pass.PasswordChar = '*';
            this.TB_EUsuario_Pass.Size = new System.Drawing.Size(178, 23);
            this.TB_EUsuario_Pass.TabIndex = 3;
            this.TB_EUsuario_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_EUsuario_Pass_KeyDown);
            // 
            // B_EUsuario_Aceptar
            // 
            this.B_EUsuario_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_EUsuario_Aceptar.Location = new System.Drawing.Point(116, 89);
            this.B_EUsuario_Aceptar.Name = "B_EUsuario_Aceptar";
            this.B_EUsuario_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_EUsuario_Aceptar.TabIndex = 4;
            this.B_EUsuario_Aceptar.Text = "Aceptar";
            this.B_EUsuario_Aceptar.UseVisualStyleBackColor = true;
            this.B_EUsuario_Aceptar.Click += new System.EventHandler(this.B_EUsuario_Aceptar_Click);
            // 
            // B_EUsuario_Cancelar
            // 
            this.B_EUsuario_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_EUsuario_Cancelar.Location = new System.Drawing.Point(197, 89);
            this.B_EUsuario_Cancelar.Name = "B_EUsuario_Cancelar";
            this.B_EUsuario_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_EUsuario_Cancelar.TabIndex = 5;
            this.B_EUsuario_Cancelar.Text = "Cancelar";
            this.B_EUsuario_Cancelar.UseVisualStyleBackColor = true;
            this.B_EUsuario_Cancelar.Click += new System.EventHandler(this.B_EUsuario_Cancelar_Click);
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.B_EUsuario_Cancelar);
            this.Controls.Add(this.B_EUsuario_Aceptar);
            this.Controls.Add(this.TB_EUsuario_Pass);
            this.Controls.Add(this.CB_EUsuario_Nombre);
            this.Controls.Add(this.L_EUsuario_Pass);
            this.Controls.Add(this.L_EUsuario_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Usuario";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_EUsuario_Nombre;
        private System.Windows.Forms.Label L_EUsuario_Pass;
        private System.Windows.Forms.ComboBox CB_EUsuario_Nombre;
        private System.Windows.Forms.TextBox TB_EUsuario_Pass;
        private System.Windows.Forms.Button B_EUsuario_Aceptar;
        private System.Windows.Forms.Button B_EUsuario_Cancelar;
    }
}