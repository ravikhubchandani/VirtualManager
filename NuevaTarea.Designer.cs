namespace Virtual_Manager
{
    partial class NuevaTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaTarea));
            this.DTP_VDetalles_FFin = new System.Windows.Forms.DateTimePicker();
            this.L_VDetalles_FFin = new System.Windows.Forms.Label();
            this.L_NTarea_Nombre = new System.Windows.Forms.Label();
            this.TB_NTarea_Nombre = new System.Windows.Forms.TextBox();
            this.TB_NTarea_Descripcion = new System.Windows.Forms.TextBox();
            this.L_VDetalles_Descripcion = new System.Windows.Forms.Label();
            this.B_NTarea_Aceptar = new System.Windows.Forms.Button();
            this.B_NTarea_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTP_VDetalles_FFin
            // 
            this.DTP_VDetalles_FFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_VDetalles_FFin.Location = new System.Drawing.Point(95, 41);
            this.DTP_VDetalles_FFin.Name = "DTP_VDetalles_FFin";
            this.DTP_VDetalles_FFin.Size = new System.Drawing.Size(233, 23);
            this.DTP_VDetalles_FFin.TabIndex = 7;
            // 
            // L_VDetalles_FFin
            // 
            this.L_VDetalles_FFin.AutoSize = true;
            this.L_VDetalles_FFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_VDetalles_FFin.Location = new System.Drawing.Point(9, 47);
            this.L_VDetalles_FFin.Name = "L_VDetalles_FFin";
            this.L_VDetalles_FFin.Size = new System.Drawing.Size(67, 15);
            this.L_VDetalles_FFin.TabIndex = 6;
            this.L_VDetalles_FFin.Text = "Finaliza el : ";
            // 
            // L_NTarea_Nombre
            // 
            this.L_NTarea_Nombre.AutoSize = true;
            this.L_NTarea_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NTarea_Nombre.Location = new System.Drawing.Point(9, 15);
            this.L_NTarea_Nombre.Name = "L_NTarea_Nombre";
            this.L_NTarea_Nombre.Size = new System.Drawing.Size(51, 15);
            this.L_NTarea_Nombre.TabIndex = 8;
            this.L_NTarea_Nombre.Text = "Nombre";
            // 
            // TB_NTarea_Nombre
            // 
            this.TB_NTarea_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NTarea_Nombre.Location = new System.Drawing.Point(95, 12);
            this.TB_NTarea_Nombre.MaxLength = 40;
            this.TB_NTarea_Nombre.Name = "TB_NTarea_Nombre";
            this.TB_NTarea_Nombre.Size = new System.Drawing.Size(233, 23);
            this.TB_NTarea_Nombre.TabIndex = 9;
            // 
            // TB_NTarea_Descripcion
            // 
            this.TB_NTarea_Descripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NTarea_Descripcion.Location = new System.Drawing.Point(12, 108);
            this.TB_NTarea_Descripcion.Multiline = true;
            this.TB_NTarea_Descripcion.Name = "TB_NTarea_Descripcion";
            this.TB_NTarea_Descripcion.Size = new System.Drawing.Size(560, 147);
            this.TB_NTarea_Descripcion.TabIndex = 11;
            // 
            // L_VDetalles_Descripcion
            // 
            this.L_VDetalles_Descripcion.AutoSize = true;
            this.L_VDetalles_Descripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_VDetalles_Descripcion.Location = new System.Drawing.Point(9, 81);
            this.L_VDetalles_Descripcion.Name = "L_VDetalles_Descripcion";
            this.L_VDetalles_Descripcion.Size = new System.Drawing.Size(69, 15);
            this.L_VDetalles_Descripcion.TabIndex = 10;
            this.L_VDetalles_Descripcion.Text = "Descripción";
            // 
            // B_NTarea_Aceptar
            // 
            this.B_NTarea_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_NTarea_Aceptar.Location = new System.Drawing.Point(416, 261);
            this.B_NTarea_Aceptar.Name = "B_NTarea_Aceptar";
            this.B_NTarea_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_NTarea_Aceptar.TabIndex = 12;
            this.B_NTarea_Aceptar.Text = "Aceptar";
            this.B_NTarea_Aceptar.UseVisualStyleBackColor = true;
            this.B_NTarea_Aceptar.Click += new System.EventHandler(this.B_NTarea_Aceptar_Click);
            // 
            // B_NTarea_Cancelar
            // 
            this.B_NTarea_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_NTarea_Cancelar.Location = new System.Drawing.Point(497, 261);
            this.B_NTarea_Cancelar.Name = "B_NTarea_Cancelar";
            this.B_NTarea_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_NTarea_Cancelar.TabIndex = 13;
            this.B_NTarea_Cancelar.Text = "Cancelar";
            this.B_NTarea_Cancelar.UseVisualStyleBackColor = true;
            this.B_NTarea_Cancelar.Click += new System.EventHandler(this.B_NTarea_Cancelar_Click);
            // 
            // NuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.B_NTarea_Cancelar);
            this.Controls.Add(this.B_NTarea_Aceptar);
            this.Controls.Add(this.TB_NTarea_Descripcion);
            this.Controls.Add(this.L_VDetalles_Descripcion);
            this.Controls.Add(this.TB_NTarea_Nombre);
            this.Controls.Add(this.L_NTarea_Nombre);
            this.Controls.Add(this.DTP_VDetalles_FFin);
            this.Controls.Add(this.L_VDetalles_FFin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevaTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_VDetalles_FFin;
        private System.Windows.Forms.Label L_VDetalles_FFin;
        private System.Windows.Forms.Label L_NTarea_Nombre;
        private System.Windows.Forms.TextBox TB_NTarea_Nombre;
        private System.Windows.Forms.TextBox TB_NTarea_Descripcion;
        private System.Windows.Forms.Label L_VDetalles_Descripcion;
        private System.Windows.Forms.Button B_NTarea_Aceptar;
        private System.Windows.Forms.Button B_NTarea_Cancelar;
    }
}