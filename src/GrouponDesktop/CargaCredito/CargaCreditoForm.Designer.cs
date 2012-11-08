namespace GrouponDesktop.CargaCredito
{
    partial class CargaCreditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargaCreditoForm));
            this.CargaCreditoLb = new System.Windows.Forms.Label();
            this.MontoACargarLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormaPagoLb = new System.Windows.Forms.Label();
            this.MontoACargarTxtBox = new System.Windows.Forms.TextBox();
            this.FormaPagoComBox = new System.Windows.Forms.ComboBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargaCreditoLb
            // 
            this.CargaCreditoLb.AutoSize = true;
            this.CargaCreditoLb.Location = new System.Drawing.Point(13, 13);
            this.CargaCreditoLb.Name = "CargaCreditoLb";
            this.CargaCreditoLb.Size = new System.Drawing.Size(319, 13);
            this.CargaCreditoLb.TabIndex = 0;
            this.CargaCreditoLb.Text = "Si desea cargar crédito en su cuenta, ingrese los siguientes datos:";
            // 
            // MontoACargarLb
            // 
            this.MontoACargarLb.AutoSize = true;
            this.MontoACargarLb.Location = new System.Drawing.Point(13, 47);
            this.MontoACargarLb.Name = "MontoACargarLb";
            this.MontoACargarLb.Size = new System.Drawing.Size(80, 13);
            this.MontoACargarLb.TabIndex = 1;
            this.MontoACargarLb.Text = "Monto a Cargar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // FormaPagoLb
            // 
            this.FormaPagoLb.AutoSize = true;
            this.FormaPagoLb.Location = new System.Drawing.Point(13, 77);
            this.FormaPagoLb.Name = "FormaPagoLb";
            this.FormaPagoLb.Size = new System.Drawing.Size(79, 13);
            this.FormaPagoLb.TabIndex = 3;
            this.FormaPagoLb.Text = "Forma de Pago";
            // 
            // MontoACargarTxtBox
            // 
            this.MontoACargarTxtBox.Location = new System.Drawing.Point(99, 44);
            this.MontoACargarTxtBox.Name = "MontoACargarTxtBox";
            this.MontoACargarTxtBox.Size = new System.Drawing.Size(130, 20);
            this.MontoACargarTxtBox.TabIndex = 5;
            this.MontoACargarTxtBox.TextChanged += new System.EventHandler(this.MontoACargarTxtBox_TextChanged);
            // 
            // FormaPagoComBox
            // 
            this.FormaPagoComBox.FormattingEnabled = true;
            this.FormaPagoComBox.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta Debito",
            "Tarjeta Credito"});
            this.FormaPagoComBox.Location = new System.Drawing.Point(99, 77);
            this.FormaPagoComBox.Name = "FormaPagoComBox";
            this.FormaPagoComBox.Size = new System.Drawing.Size(130, 21);
            this.FormaPagoComBox.TabIndex = 6;
            this.FormaPagoComBox.SelectedIndexChanged += new System.EventHandler(this.FormaPagoComBox_SelectedIndexChanged);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(317, 117);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(236, 117);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 8;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CargaCreditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 152);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FormaPagoComBox);
            this.Controls.Add(this.MontoACargarTxtBox);
            this.Controls.Add(this.FormaPagoLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MontoACargarLb);
            this.Controls.Add(this.CargaCreditoLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CargaCreditoForm";
            this.Text = "Carga de Crédito";
            this.Load += new System.EventHandler(this.CargaCreditoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CargaCreditoLb;
        private System.Windows.Forms.Label MontoACargarLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FormaPagoLb;
        private System.Windows.Forms.TextBox MontoACargarTxtBox;
        private System.Windows.Forms.ComboBox FormaPagoComBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
    }
}