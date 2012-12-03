namespace GrouponDesktop.PedirDevolucion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selec = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.publicar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pub = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 57);
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
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtrar por proveedor (opcional)";
            // 
            // selec
            // 
            this.selec.Location = new System.Drawing.Point(172, 86);
            this.selec.Name = "selec";
            this.selec.Size = new System.Drawing.Size(148, 23);
            this.selec.TabIndex = 2;
            this.selec.Text = "Seleccionar";
            this.selec.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(172, 116);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(148, 23);
            this.buscar.TabIndex = 3;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publicar});
            this.dataGridView1.Location = new System.Drawing.Point(13, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(876, 278);
            this.dataGridView1.TabIndex = 4;
            // 
            // publicar
            // 
            this.publicar.HeaderText = "Publicar";
            this.publicar.Name = "publicar";
            this.publicar.ReadOnly = true;
            // 
            // pub
            // 
            this.pub.Location = new System.Drawing.Point(13, 433);
            this.pub.Name = "pub";
            this.pub.Size = new System.Drawing.Size(75, 23);
            this.pub.TabIndex = 5;
            this.pub.Text = "Publicar";
            this.pub.UseVisualStyleBackColor = true;
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(813, 432);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 6;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 468);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.pub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.selec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Publicar Cupon";
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn publicar;
        private System.Windows.Forms.Button pub;
        private System.Windows.Forms.Button cerrar;
    }
}