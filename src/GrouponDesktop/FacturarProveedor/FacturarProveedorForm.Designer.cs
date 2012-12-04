namespace GrouponDesktop.FacturarProveedor
{
    partial class FacturarProveedorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturarProveedorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selec = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fact = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Provselecc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.fNro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.importe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los cupones a publicar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobre proveedor";
            // 
            // selec
            // 
            this.selec.Location = new System.Drawing.Point(121, 86);
            this.selec.Name = "selec";
            this.selec.Size = new System.Drawing.Size(148, 23);
            this.selec.TabIndex = 2;
            this.selec.Text = "Seleccionar";
            this.selec.UseVisualStyleBackColor = true;
            this.selec.Click += new System.EventHandler(this.selec_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(121, 115);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(148, 23);
            this.buscar.TabIndex = 3;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(887, 247);
            this.dataGridView1.TabIndex = 4;
            // 
            // fact
            // 
            this.fact.Location = new System.Drawing.Point(13, 433);
            this.fact.Name = "fact";
            this.fact.Size = new System.Drawing.Size(75, 23);
            this.fact.TabIndex = 5;
            this.fact.Text = "Facturar";
            this.fact.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(813, 432);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 6;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usted a seleccionado a";
            // 
            // Provselecc
            // 
            this.Provselecc.Enabled = false;
            this.Provselecc.Location = new System.Drawing.Point(436, 88);
            this.Provselecc.Name = "Provselecc";
            this.Provselecc.Size = new System.Drawing.Size(209, 20);
            this.Provselecc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(705, 121);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Factura Nro";
            // 
            // fNro
            // 
            this.fNro.Enabled = false;
            this.fNro.Location = new System.Drawing.Point(83, 401);
            this.fNro.Name = "fNro";
            this.fNro.Size = new System.Drawing.Size(130, 20);
            this.fNro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Importe a pagar con Bonificacion 50%";
            // 
            // importe
            // 
            this.importe.Enabled = false;
            this.importe.Location = new System.Drawing.Point(431, 432);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(137, 20);
            this.importe.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total sin Bonificacion";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(431, 407);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(137, 20);
            this.total.TabIndex = 18;
            // 
            // FacturarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 468);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.importe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fNro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Provselecc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.fact);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.selec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturarProveedorForm";
            this.Text = "Facturar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selec;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button fact;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Provselecc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fNro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox importe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total;
    }
}