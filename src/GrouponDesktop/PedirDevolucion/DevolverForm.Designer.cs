namespace GrouponDesktop.PedirDevolucion
{
    partial class DevolverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.venc = new System.Windows.Forms.TextBox();
            this.pfict = new System.Windows.Forms.TextBox();
            this.preal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Razon = new System.Windows.Forms.TextBox();
            this.No = new System.Windows.Forms.Button();
            this.si = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del cupon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vencimiento de Canje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio sin Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Oferta";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(150, 83);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(690, 20);
            this.desc.TabIndex = 5;
            // 
            // venc
            // 
            this.venc.Location = new System.Drawing.Point(150, 108);
            this.venc.Name = "venc";
            this.venc.Size = new System.Drawing.Size(690, 20);
            this.venc.TabIndex = 6;
            // 
            // pfict
            // 
            this.pfict.Location = new System.Drawing.Point(150, 138);
            this.pfict.Name = "pfict";
            this.pfict.Size = new System.Drawing.Size(690, 20);
            this.pfict.TabIndex = 7;
            // 
            // preal
            // 
            this.preal.Location = new System.Drawing.Point(150, 166);
            this.preal.Name = "preal";
            this.preal.Size = new System.Drawing.Size(690, 20);
            this.preal.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Razon);
            this.panel2.Controls.Add(this.No);
            this.panel2.Controls.Add(this.si);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(54, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 100);
            this.panel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Razon";
            // 
            // Razon
            // 
            this.Razon.Location = new System.Drawing.Point(243, 16);
            this.Razon.MaxLength = 255;
            this.Razon.Multiline = true;
            this.Razon.Name = "Razon";
            this.Razon.Size = new System.Drawing.Size(218, 52);
            this.Razon.TabIndex = 3;
            this.Razon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Razon_KeyPress);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(386, 74);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 23);
            this.No.TabIndex = 2;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // si
            // 
            this.si.Location = new System.Drawing.Point(243, 74);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(75, 23);
            this.si.TabIndex = 1;
            this.si.Text = "Si";
            this.si.UseVisualStyleBackColor = true;
            this.si.Click += new System.EventHandler(this.si_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "¿Esta Usted seguro de devolver este cupon?";
            // 
            // DevolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 332);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.preal);
            this.Controls.Add(this.pfict);
            this.Controls.Add(this.venc);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevolverForm";
            this.Text = "Devolver";
            this.Load += new System.EventHandler(this.DevolverForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox venc;
        private System.Windows.Forms.TextBox pfict;
        private System.Windows.Forms.TextBox preal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button si;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Razon;
    }
}