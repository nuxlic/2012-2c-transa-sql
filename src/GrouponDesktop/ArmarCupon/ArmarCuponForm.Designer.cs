namespace GrouponDesktop.ArmarCupon
{
    partial class ArmarCuponForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmarCuponForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.fecpub = new System.Windows.Forms.DateTimePicker();
            this.fecvencof = new System.Windows.Forms.DateTimePicker();
            this.fecvenccons = new System.Windows.Forms.DateTimePicker();
            this.pReal = new System.Windows.Forms.TextBox();
            this.pFic = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.maxallow = new System.Windows.Forms.TextBox();
            this.zonas = new System.Windows.Forms.CheckedListBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos de la promocion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de vencimiento de la oferta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de vencimiento para el consumo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio real";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio ficticio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad Disponible";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cantidad maxima a comprar por cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Zonas de adquisicion";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(227, 113);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(249, 20);
            this.desc.TabIndex = 10;
            this.desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desc_KeyPress);
            // 
            // fecpub
            // 
            this.fecpub.Location = new System.Drawing.Point(227, 144);
            this.fecpub.Name = "fecpub";
            this.fecpub.Size = new System.Drawing.Size(249, 20);
            this.fecpub.TabIndex = 11;
            // 
            // fecvencof
            // 
            this.fecvencof.Location = new System.Drawing.Point(227, 178);
            this.fecvencof.Name = "fecvencof";
            this.fecvencof.Size = new System.Drawing.Size(249, 20);
            this.fecvencof.TabIndex = 12;
            // 
            // fecvenccons
            // 
            this.fecvenccons.Location = new System.Drawing.Point(227, 213);
            this.fecvenccons.Name = "fecvenccons";
            this.fecvenccons.Size = new System.Drawing.Size(249, 20);
            this.fecvenccons.TabIndex = 13;
            // 
            // pReal
            // 
            this.pReal.Location = new System.Drawing.Point(227, 242);
            this.pReal.Name = "pReal";
            this.pReal.Size = new System.Drawing.Size(249, 20);
            this.pReal.TabIndex = 14;
            this.pReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pReal_KeyPress);
            // 
            // pFic
            // 
            this.pFic.Location = new System.Drawing.Point(227, 274);
            this.pFic.Name = "pFic";
            this.pFic.Size = new System.Drawing.Size(249, 20);
            this.pFic.TabIndex = 15;
            this.pFic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFic_KeyPress);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(227, 309);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(249, 20);
            this.stock.TabIndex = 16;
            this.stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_KeyPress);
            // 
            // maxallow
            // 
            this.maxallow.Location = new System.Drawing.Point(227, 343);
            this.maxallow.Name = "maxallow";
            this.maxallow.Size = new System.Drawing.Size(249, 20);
            this.maxallow.TabIndex = 17;
            this.maxallow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxallow_KeyPress);
            // 
            // zonas
            // 
            this.zonas.FormattingEnabled = true;
            this.zonas.Location = new System.Drawing.Point(227, 375);
            this.zonas.Name = "zonas";
            this.zonas.Size = new System.Drawing.Size(249, 169);
            this.zonas.TabIndex = 18;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(18, 549);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 19;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(401, 550);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 20;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Sobre proveedor";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // ArmarCuponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 584);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.zonas);
            this.Controls.Add(this.maxallow);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.pFic);
            this.Controls.Add(this.pReal);
            this.Controls.Add(this.fecvenccons);
            this.Controls.Add(this.fecvencof);
            this.Controls.Add(this.fecpub);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArmarCuponForm";
            this.Text = "Armar Cupon";
            this.Load += new System.EventHandler(this.ArmarCuponForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.DateTimePicker fecpub;
        private System.Windows.Forms.DateTimePicker fecvencof;
        private System.Windows.Forms.DateTimePicker fecvenccons;
        private System.Windows.Forms.TextBox pReal;
        private System.Windows.Forms.TextBox pFic;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox maxallow;
        private System.Windows.Forms.CheckedListBox zonas;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}