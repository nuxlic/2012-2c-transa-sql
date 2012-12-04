namespace GrouponDesktop
{
    partial class OpcionesUsuarioForm
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
            this.btnCambiarPassword = new System.Windows.Forms.Button();
            this.btnDarseDeBaja = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Location = new System.Drawing.Point(12, 58);
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(154, 36);
            this.btnCambiarPassword.TabIndex = 5;
            this.btnCambiarPassword.Text = "CambiarPassword";
            this.btnCambiarPassword.UseVisualStyleBackColor = true;
            this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // btnDarseDeBaja
            // 
            this.btnDarseDeBaja.Location = new System.Drawing.Point(12, 111);
            this.btnDarseDeBaja.Name = "btnDarseDeBaja";
            this.btnDarseDeBaja.Size = new System.Drawing.Size(154, 36);
            this.btnDarseDeBaja.TabIndex = 6;
            this.btnDarseDeBaja.Text = "Darse de Baja";
            this.btnDarseDeBaja.UseVisualStyleBackColor = true;
            this.btnDarseDeBaja.Click += new System.EventHandler(this.btnDarseDeBaja_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 226);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 24);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // OpcionesUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDarseDeBaja);
            this.Controls.Add(this.btnCambiarPassword);
            this.Name = "OpcionesUsuarioForm";
            this.Text = "OpcionesUsuarioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarPassword;
        private System.Windows.Forms.Button btnDarseDeBaja;
        private System.Windows.Forms.Button btnVolver;
    }
}