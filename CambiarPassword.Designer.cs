namespace Virtual_Manager
{
    partial class CambiarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPassword));
            this.L_CambiarPass_Pass = new System.Windows.Forms.Label();
            this.L_CambiarPass_NPass1 = new System.Windows.Forms.Label();
            this.L_CambiarPass_NPass2 = new System.Windows.Forms.Label();
            this.TB_CambiarPass_Pass = new System.Windows.Forms.TextBox();
            this.TB_CambiarPass_NPass1 = new System.Windows.Forms.TextBox();
            this.TB_CambiarPass_NPass2 = new System.Windows.Forms.TextBox();
            this.B_CambiarPass_Aceptar = new System.Windows.Forms.Button();
            this.C_CambiarPass_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_CambiarPass_Pass
            // 
            this.L_CambiarPass_Pass.AutoSize = true;
            this.L_CambiarPass_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CambiarPass_Pass.Location = new System.Drawing.Point(13, 13);
            this.L_CambiarPass_Pass.Name = "L_CambiarPass_Pass";
            this.L_CambiarPass_Pass.Size = new System.Drawing.Size(67, 15);
            this.L_CambiarPass_Pass.TabIndex = 0;
            this.L_CambiarPass_Pass.Text = "Contraseña";
            // 
            // L_CambiarPass_NPass1
            // 
            this.L_CambiarPass_NPass1.AutoSize = true;
            this.L_CambiarPass_NPass1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CambiarPass_NPass1.Location = new System.Drawing.Point(13, 47);
            this.L_CambiarPass_NPass1.Name = "L_CambiarPass_NPass1";
            this.L_CambiarPass_NPass1.Size = new System.Drawing.Size(104, 15);
            this.L_CambiarPass_NPass1.TabIndex = 1;
            this.L_CambiarPass_NPass1.Text = "Nueva Contraseña";
            // 
            // L_CambiarPass_NPass2
            // 
            this.L_CambiarPass_NPass2.AutoSize = true;
            this.L_CambiarPass_NPass2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_CambiarPass_NPass2.Location = new System.Drawing.Point(13, 80);
            this.L_CambiarPass_NPass2.Name = "L_CambiarPass_NPass2";
            this.L_CambiarPass_NPass2.Size = new System.Drawing.Size(103, 15);
            this.L_CambiarPass_NPass2.TabIndex = 2;
            this.L_CambiarPass_NPass2.Text = "Repita Contraseña";
            // 
            // TB_CambiarPass_Pass
            // 
            this.TB_CambiarPass_Pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CambiarPass_Pass.Location = new System.Drawing.Point(142, 10);
            this.TB_CambiarPass_Pass.Name = "TB_CambiarPass_Pass";
            this.TB_CambiarPass_Pass.PasswordChar = '*';
            this.TB_CambiarPass_Pass.Size = new System.Drawing.Size(173, 23);
            this.TB_CambiarPass_Pass.TabIndex = 3;
            // 
            // TB_CambiarPass_NPass1
            // 
            this.TB_CambiarPass_NPass1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CambiarPass_NPass1.Location = new System.Drawing.Point(142, 44);
            this.TB_CambiarPass_NPass1.Name = "TB_CambiarPass_NPass1";
            this.TB_CambiarPass_NPass1.PasswordChar = '*';
            this.TB_CambiarPass_NPass1.Size = new System.Drawing.Size(173, 23);
            this.TB_CambiarPass_NPass1.TabIndex = 4;
            // 
            // TB_CambiarPass_NPass2
            // 
            this.TB_CambiarPass_NPass2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CambiarPass_NPass2.Location = new System.Drawing.Point(142, 77);
            this.TB_CambiarPass_NPass2.Name = "TB_CambiarPass_NPass2";
            this.TB_CambiarPass_NPass2.PasswordChar = '*';
            this.TB_CambiarPass_NPass2.Size = new System.Drawing.Size(173, 23);
            this.TB_CambiarPass_NPass2.TabIndex = 5;
            this.TB_CambiarPass_NPass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_CambiarPass_NPass2_KeyDown);
            // 
            // B_CambiarPass_Aceptar
            // 
            this.B_CambiarPass_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_CambiarPass_Aceptar.Location = new System.Drawing.Point(159, 104);
            this.B_CambiarPass_Aceptar.Name = "B_CambiarPass_Aceptar";
            this.B_CambiarPass_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_CambiarPass_Aceptar.TabIndex = 6;
            this.B_CambiarPass_Aceptar.Text = "Aceptar";
            this.B_CambiarPass_Aceptar.UseVisualStyleBackColor = true;
            this.B_CambiarPass_Aceptar.Click += new System.EventHandler(this.B_CambiarPass_Aceptar_Click);
            // 
            // C_CambiarPass_Cancelar
            // 
            this.C_CambiarPass_Cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_CambiarPass_Cancelar.Location = new System.Drawing.Point(240, 104);
            this.C_CambiarPass_Cancelar.Name = "C_CambiarPass_Cancelar";
            this.C_CambiarPass_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.C_CambiarPass_Cancelar.TabIndex = 7;
            this.C_CambiarPass_Cancelar.Text = "Cancelar";
            this.C_CambiarPass_Cancelar.UseVisualStyleBackColor = true;
            this.C_CambiarPass_Cancelar.Click += new System.EventHandler(this.C_CambiarPass_Cancelar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(338, 139);
            this.Controls.Add(this.C_CambiarPass_Cancelar);
            this.Controls.Add(this.B_CambiarPass_Aceptar);
            this.Controls.Add(this.TB_CambiarPass_NPass2);
            this.Controls.Add(this.TB_CambiarPass_NPass1);
            this.Controls.Add(this.TB_CambiarPass_Pass);
            this.Controls.Add(this.L_CambiarPass_NPass2);
            this.Controls.Add(this.L_CambiarPass_NPass1);
            this.Controls.Add(this.L_CambiarPass_Pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_CambiarPass_Pass;
        private System.Windows.Forms.Label L_CambiarPass_NPass1;
        private System.Windows.Forms.Label L_CambiarPass_NPass2;
        private System.Windows.Forms.TextBox TB_CambiarPass_Pass;
        private System.Windows.Forms.TextBox TB_CambiarPass_NPass1;
        private System.Windows.Forms.TextBox TB_CambiarPass_NPass2;
        private System.Windows.Forms.Button B_CambiarPass_Aceptar;
        private System.Windows.Forms.Button C_CambiarPass_Cancelar;
    }
}