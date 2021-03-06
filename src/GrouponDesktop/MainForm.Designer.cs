﻿namespace GrouponDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.estadistica = new System.Windows.Forms.Button();
            this.facturar = new System.Windows.Forms.Button();
            this.Publicar_Cupon = new System.Windows.Forms.Button();
            this.registrarConsumo = new System.Windows.Forms.Button();
            this.Armar_Cupon = new System.Windows.Forms.Button();
            this.historial = new System.Windows.Forms.Button();
            this.Devolver_cupon = new System.Windows.Forms.Button();
            this.comprar_cupon = new System.Windows.Forms.Button();
            this.Comprar_GiftCard = new System.Windows.Forms.Button();
            this.cargarCred = new System.Windows.Forms.Button();
            this.abms = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblWelcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWelcome.Location = new System.Drawing.Point(71, 41);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(155, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Menu Principal";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // estadistica
            // 
            this.estadistica.Location = new System.Drawing.Point(120, 86);
            this.estadistica.Name = "estadistica";
            this.estadistica.Size = new System.Drawing.Size(75, 37);
            this.estadistica.TabIndex = 10;
            this.estadistica.Text = "Listado Estadistico";
            this.estadistica.UseVisualStyleBackColor = true;
            this.estadistica.Visible = false;
            this.estadistica.Click += new System.EventHandler(this.estadistica_Click);
            // 
            // facturar
            // 
            this.facturar.Location = new System.Drawing.Point(3, 86);
            this.facturar.Name = "facturar";
            this.facturar.Size = new System.Drawing.Size(111, 37);
            this.facturar.TabIndex = 9;
            this.facturar.Text = "Facturar a un Proveedor";
            this.facturar.UseVisualStyleBackColor = true;
            this.facturar.Visible = false;
            this.facturar.Click += new System.EventHandler(this.facturar_Click);
            // 
            // Publicar_Cupon
            // 
            this.Publicar_Cupon.Location = new System.Drawing.Point(282, 46);
            this.Publicar_Cupon.Name = "Publicar_Cupon";
            this.Publicar_Cupon.Size = new System.Drawing.Size(75, 34);
            this.Publicar_Cupon.TabIndex = 8;
            this.Publicar_Cupon.Text = "Publicar Cupon";
            this.Publicar_Cupon.UseVisualStyleBackColor = true;
            this.Publicar_Cupon.Visible = false;
            this.Publicar_Cupon.Click += new System.EventHandler(this.Publicar_Cupon_Click);
            // 
            // registrarConsumo
            // 
            this.registrarConsumo.Location = new System.Drawing.Point(165, 46);
            this.registrarConsumo.Name = "registrarConsumo";
            this.registrarConsumo.Size = new System.Drawing.Size(111, 34);
            this.registrarConsumo.TabIndex = 7;
            this.registrarConsumo.Text = "Registrar Consumo de un Cupon";
            this.registrarConsumo.UseVisualStyleBackColor = true;
            this.registrarConsumo.Visible = false;
            this.registrarConsumo.Click += new System.EventHandler(this.registrarConsumo_Click);
            // 
            // Armar_Cupon
            // 
            this.Armar_Cupon.Location = new System.Drawing.Point(84, 46);
            this.Armar_Cupon.Name = "Armar_Cupon";
            this.Armar_Cupon.Size = new System.Drawing.Size(75, 34);
            this.Armar_Cupon.TabIndex = 6;
            this.Armar_Cupon.Text = "Armar Cupon";
            this.Armar_Cupon.UseVisualStyleBackColor = true;
            this.Armar_Cupon.Visible = false;
            this.Armar_Cupon.Click += new System.EventHandler(this.Armar_Cupon_Click);
            // 
            // historial
            // 
            this.historial.Location = new System.Drawing.Point(3, 46);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(75, 34);
            this.historial.TabIndex = 5;
            this.historial.Text = "Historial de Compras";
            this.historial.UseVisualStyleBackColor = true;
            this.historial.Visible = false;
            this.historial.Click += new System.EventHandler(this.historial_Click);
            // 
            // Devolver_cupon
            // 
            this.Devolver_cupon.Location = new System.Drawing.Point(3, 3);
            this.Devolver_cupon.Name = "Devolver_cupon";
            this.Devolver_cupon.Size = new System.Drawing.Size(75, 36);
            this.Devolver_cupon.TabIndex = 4;
            this.Devolver_cupon.Text = "Devolver Cupon";
            this.Devolver_cupon.UseVisualStyleBackColor = true;
            this.Devolver_cupon.Visible = false;
            this.Devolver_cupon.Click += new System.EventHandler(this.Devolver_cupon_Click);
            // 
            // comprar_cupon
            // 
            this.comprar_cupon.Location = new System.Drawing.Point(327, 3);
            this.comprar_cupon.Name = "comprar_cupon";
            this.comprar_cupon.Size = new System.Drawing.Size(75, 36);
            this.comprar_cupon.TabIndex = 3;
            this.comprar_cupon.Text = "Comprar Cupon";
            this.comprar_cupon.UseVisualStyleBackColor = true;
            this.comprar_cupon.Visible = false;
            this.comprar_cupon.Click += new System.EventHandler(this.comprar_cupon_Click);
            // 
            // Comprar_GiftCard
            // 
            this.Comprar_GiftCard.Location = new System.Drawing.Point(246, 3);
            this.Comprar_GiftCard.Name = "Comprar_GiftCard";
            this.Comprar_GiftCard.Size = new System.Drawing.Size(75, 35);
            this.Comprar_GiftCard.TabIndex = 2;
            this.Comprar_GiftCard.Text = "Comprar GiftCard";
            this.Comprar_GiftCard.UseVisualStyleBackColor = true;
            this.Comprar_GiftCard.Visible = false;
            this.Comprar_GiftCard.Click += new System.EventHandler(this.Comprar_GiftCard_Click);
            // 
            // cargarCred
            // 
            this.cargarCred.Location = new System.Drawing.Point(165, 3);
            this.cargarCred.Name = "cargarCred";
            this.cargarCred.Size = new System.Drawing.Size(75, 37);
            this.cargarCred.TabIndex = 1;
            this.cargarCred.Text = "Cargar Credito";
            this.cargarCred.UseVisualStyleBackColor = true;
            this.cargarCred.Visible = false;
            this.cargarCred.Click += new System.EventHandler(this.button2_Click);
            // 
            // abms
            // 
            this.abms.Location = new System.Drawing.Point(84, 3);
            this.abms.Name = "abms";
            this.abms.Size = new System.Drawing.Size(75, 37);
            this.abms.TabIndex = 0;
            this.abms.Text = "ABMs";
            this.abms.UseVisualStyleBackColor = true;
            this.abms.Visible = false;
            this.abms.Click += new System.EventHandler(this.abms_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(173, 275);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Devolver_cupon);
            this.flowLayoutPanel1.Controls.Add(this.abms);
            this.flowLayoutPanel1.Controls.Add(this.cargarCred);
            this.flowLayoutPanel1.Controls.Add(this.Comprar_GiftCard);
            this.flowLayoutPanel1.Controls.Add(this.comprar_cupon);
            this.flowLayoutPanel1.Controls.Add(this.historial);
            this.flowLayoutPanel1.Controls.Add(this.Armar_Cupon);
            this.flowLayoutPanel1.Controls.Add(this.registrarConsumo);
            this.flowLayoutPanel1.Controls.Add(this.Publicar_Cupon);
            this.flowLayoutPanel1.Controls.Add(this.facturar);
            this.flowLayoutPanel1.Controls.Add(this.estadistica);
            this.flowLayoutPanel1.Controls.Add(this.btnChangeRole);
            this.flowLayoutPanel1.Controls.Add(this.btnOpciones);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 141);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Location = new System.Drawing.Point(201, 86);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(89, 36);
            this.btnChangeRole.TabIndex = 12;
            this.btnChangeRole.Text = "Cambiar Rol de un Usuario";
            this.btnChangeRole.UseVisualStyleBackColor = true;
            this.btnChangeRole.Visible = false;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // btnOpciones
            // 
            this.btnOpciones.Location = new System.Drawing.Point(296, 86);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(75, 36);
            this.btnOpciones.TabIndex = 11;
            this.btnOpciones.Text = "Opciones de Usuario";
            this.btnOpciones.UseVisualStyleBackColor = true;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 302);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cuponete - Menu Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cargarCred;
        private System.Windows.Forms.Button abms;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Devolver_cupon;
        private System.Windows.Forms.Button comprar_cupon;
        private System.Windows.Forms.Button Comprar_GiftCard;
        private System.Windows.Forms.Button historial;
        private System.Windows.Forms.Button Armar_Cupon;
        private System.Windows.Forms.Button registrarConsumo;
        private System.Windows.Forms.Button Publicar_Cupon;
        private System.Windows.Forms.Button estadistica;
        private System.Windows.Forms.Button facturar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnChangeRole;
    }
}