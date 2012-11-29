namespace GrouponDesktop.ComprarCupon
{
    partial class CompraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.Confirmar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(152, 55);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 20);
            this.cantidad.TabIndex = 1;
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(16, 142);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 2;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(196, 141);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 3;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompraForm";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button Cerrar;
    }
}