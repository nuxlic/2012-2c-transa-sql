namespace GrouponDesktop.ListadoEstadistico
{
    partial class ListadoMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.semestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.ComboBox();
            this.top5dev = new System.Windows.Forms.Button();
            this.top5Gift = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un semestre y un tipo de listado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semestre";
            // 
            // semestre
            // 
            this.semestre.FormattingEnabled = true;
            this.semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.semestre.Location = new System.Drawing.Point(96, 74);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(121, 21);
            this.semestre.TabIndex = 2;
            this.semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.semestre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año";
            // 
            // anio
            // 
            this.anio.FormattingEnabled = true;
            this.anio.Location = new System.Drawing.Point(96, 106);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(121, 21);
            this.anio.TabIndex = 4;
            this.anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anio_KeyPress);
            // 
            // top5dev
            // 
            this.top5dev.Location = new System.Drawing.Point(13, 148);
            this.top5dev.Name = "top5dev";
            this.top5dev.Size = new System.Drawing.Size(98, 77);
            this.top5dev.TabIndex = 5;
            this.top5dev.Text = "Top 5 porcentaje de devolucion de cupones";
            this.top5dev.UseVisualStyleBackColor = true;
            this.top5dev.Click += new System.EventHandler(this.top5dev_Click);
            // 
            // top5Gift
            // 
            this.top5Gift.Location = new System.Drawing.Point(130, 148);
            this.top5Gift.Name = "top5Gift";
            this.top5Gift.Size = new System.Drawing.Size(97, 77);
            this.top5Gift.TabIndex = 6;
            this.top5Gift.Text = "Top 5 por usuario con acreditacion de Giftcards";
            this.top5Gift.UseVisualStyleBackColor = true;
            this.top5Gift.Click += new System.EventHandler(this.top5Gift_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(140, 267);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 7;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // ListadoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 305);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.top5Gift);
            this.Controls.Add(this.top5dev);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoMainForm";
            this.Text = "Listado Estadistico";
            this.Load += new System.EventHandler(this.ListadoMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox semestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox anio;
        private System.Windows.Forms.Button top5dev;
        private System.Windows.Forms.Button top5Gift;
        private System.Windows.Forms.Button cerrar;
    }
}