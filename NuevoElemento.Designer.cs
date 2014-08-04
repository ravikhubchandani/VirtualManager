namespace Virtual_Manager
{
    partial class NuevoElemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoElemento));
            this.L_NElemento_Nombre = new System.Windows.Forms.Label();
            this.TB_NElemento_Introducido = new System.Windows.Forms.TextBox();
            this.B_NElemento_Aceptar = new System.Windows.Forms.Button();
            this.B_NElemento_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_NElemento_Nombre
            // 
            this.L_NElemento_Nombre.AutoSize = true;
            this.L_NElemento_Nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NElemento_Nombre.Location = new System.Drawing.Point(12, 18);
            this.L_NElemento_Nombre.Name = "L_NElemento_Nombre";
            this.L_NElemento_Nombre.Size = new System.Drawing.Size(54, 15);
            this.L_NElemento_Nombre.TabIndex = 0;
            this.L_NElemento_Nombre.Text = "Nombre ";
            // 
            // TB_NElemento_Introducido
            // 
            this.TB_NElemento_Introducido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NElemento_Introducido.Location = new System.Drawing.Point(134, 15);
            this.TB_NElemento_Introducido.Name = "TB_NElemento_Introducido";
            this.TB_NElemento_Introducido.Size = new System.Drawing.Size(180, 23);
            this.TB_NElemento_Introducido.TabIndex = 1;
            this.TB_NElemento_Introducido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_NElemento_Introducido_KeyDown);
            // 
            // B_NElemento_Aceptar
            // 
            this.B_NElemento_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_NElemento_Aceptar.Location = new System.Drawing.Point(158, 50);
            this.B_NElemento_Aceptar.Name = "B_NElemento_Aceptar";
            this.B_NElemento_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_NElemento_Aceptar.TabIndex = 2;
            this.B_NElemento_Aceptar.Text = "Aceptar";
            this.B_NElemento_Aceptar.UseVisualStyleBackColor = true;
            this.B_NElemento_Aceptar.Click += new System.EventHandler(this.B_NElemento_Aceptar_Click);
            // 
            // B_NElemento_Cancelar
            // 
            this.B_NElemento_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_NElemento_Cancelar.Location = new System.Drawing.Point(239, 50);
            this.B_NElemento_Cancelar.Name = "B_NElemento_Cancelar";
            this.B_NElemento_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_NElemento_Cancelar.TabIndex = 3;
            this.B_NElemento_Cancelar.Text = "Cancelar";
            this.B_NElemento_Cancelar.UseVisualStyleBackColor = true;
            this.B_NElemento_Cancelar.Click += new System.EventHandler(this.B_NElemento_Cancelar_Click);
            // 
            // NuevoElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(332, 85);
            this.Controls.Add(this.B_NElemento_Cancelar);
            this.Controls.Add(this.B_NElemento_Aceptar);
            this.Controls.Add(this.TB_NElemento_Introducido);
            this.Controls.Add(this.L_NElemento_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoElemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_NElemento_Nombre;
        private System.Windows.Forms.TextBox TB_NElemento_Introducido;
        private System.Windows.Forms.Button B_NElemento_Aceptar;
        private System.Windows.Forms.Button B_NElemento_Cancelar;
    }
}