namespace GrouponDesktop.AbmCliente
{
    partial class ModifCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifCliente));
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBoxCreateCustomer = new System.Windows.Forms.GroupBox();
            this.dtpBirhtday = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkBoxListPreferences = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pictureCustomer = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblCreateCustomer = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.gBoxCreateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.ImageKey = "Cuponete_Cancel.png";
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(262, 578);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gBoxCreateCustomer
            // 
            this.gBoxCreateCustomer.Controls.Add(this.btnDesbloquear);
            this.gBoxCreateCustomer.Controls.Add(this.btnHabilitar);
            this.gBoxCreateCustomer.Controls.Add(this.btnLimpiar);
            this.gBoxCreateCustomer.Controls.Add(this.dtpBirhtday);
            this.gBoxCreateCustomer.Controls.Add(this.txtAddress);
            this.gBoxCreateCustomer.Controls.Add(this.txtPhone);
            this.gBoxCreateCustomer.Controls.Add(this.txtEmail);
            this.gBoxCreateCustomer.Controls.Add(this.chkBoxListPreferences);
            this.gBoxCreateCustomer.Controls.Add(this.label6);
            this.gBoxCreateCustomer.Controls.Add(this.txtPostalCode);
            this.gBoxCreateCustomer.Controls.Add(this.txtDni);
            this.gBoxCreateCustomer.Controls.Add(this.txtSurname);
            this.gBoxCreateCustomer.Controls.Add(this.txtName);
            this.gBoxCreateCustomer.Controls.Add(this.lblBirthday);
            this.gBoxCreateCustomer.Controls.Add(this.lblPostalCode);
            this.gBoxCreateCustomer.Controls.Add(this.lblStreetName);
            this.gBoxCreateCustomer.Controls.Add(this.lblPhone);
            this.gBoxCreateCustomer.Controls.Add(this.lblEmail);
            this.gBoxCreateCustomer.Controls.Add(this.lblName);
            this.gBoxCreateCustomer.Controls.Add(this.lblDni);
            this.gBoxCreateCustomer.Controls.Add(this.lblSurname);
            this.gBoxCreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBoxCreateCustomer.Location = new System.Drawing.Point(6, 144);
            this.gBoxCreateCustomer.Name = "gBoxCreateCustomer";
            this.gBoxCreateCustomer.Size = new System.Drawing.Size(570, 428);
            this.gBoxCreateCustomer.TabIndex = 8;
            this.gBoxCreateCustomer.TabStop = false;
            this.gBoxCreateCustomer.Text = "Datos Personales";
            // 
            // dtpBirhtday
            // 
            this.dtpBirhtday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirhtday.Location = new System.Drawing.Point(122, 205);
            this.dtpBirhtday.Name = "dtpBirhtday";
            this.dtpBirhtday.Size = new System.Drawing.Size(128, 20);
            this.dtpBirhtday.TabIndex = 30;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(122, 149);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(128, 20);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(122, 123);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(128, 20);
            this.txtPhone.TabIndex = 23;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(122, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // chkBoxListPreferences
            // 
            this.chkBoxListPreferences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkBoxListPreferences.FormattingEnabled = true;
            this.chkBoxListPreferences.Location = new System.Drawing.Point(21, 264);
            this.chkBoxListPreferences.MultiColumn = true;
            this.chkBoxListPreferences.Name = "chkBoxListPreferences";
            this.chkBoxListPreferences.Size = new System.Drawing.Size(529, 152);
            this.chkBoxListPreferences.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(119, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seleccione las ciudades que prefiere que Cuponete le ofresca descuentos";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Location = new System.Drawing.Point(122, 178);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(128, 20);
            this.txtPostalCode.TabIndex = 21;
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Location = new System.Drawing.Point(122, 71);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(128, 20);
            this.txtDni.TabIndex = 20;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Location = new System.Drawing.Point(122, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(128, 20);
            this.txtSurname.TabIndex = 19;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(122, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 18;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBirthday.Location = new System.Drawing.Point(8, 211);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(108, 13);
            this.lblBirthday.TabIndex = 15;
            this.lblBirthday.Text = "Fecha de Nacimiento";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPostalCode.Location = new System.Drawing.Point(8, 185);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(72, 13);
            this.lblPostalCode.TabIndex = 14;
            this.lblPostalCode.Text = "Código Postal";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStreetName.Location = new System.Drawing.Point(8, 156);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(52, 13);
            this.lblStreetName.TabIndex = 9;
            this.lblStreetName.Text = "Direccion";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhone.Location = new System.Drawing.Point(8, 130);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(8, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo Electronico";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(8, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDni.Location = new System.Drawing.Point(8, 78);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSurname.Location = new System.Drawing.Point(8, 52);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(44, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Apellido";
            // 
            // pictureCustomer
            // 
            this.pictureCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pictureCustomer.Image")));
            this.pictureCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCustomer.Location = new System.Drawing.Point(12, 10);
            this.pictureCustomer.Name = "pictureCustomer";
            this.pictureCustomer.Size = new System.Drawing.Size(128, 128);
            this.pictureCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureCustomer.TabIndex = 7;
            this.pictureCustomer.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.ImageKey = "Cuponete_Accept.png";
            this.btnAccept.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAccept.Location = new System.Drawing.Point(181, 578);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblCreateCustomer
            // 
            this.lblCreateCustomer.AutoSize = true;
            this.lblCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCreateCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCreateCustomer.Location = new System.Drawing.Point(220, 27);
            this.lblCreateCustomer.Name = "lblCreateCustomer";
            this.lblCreateCustomer.Size = new System.Drawing.Size(173, 25);
            this.lblCreateCustomer.TabIndex = 11;
            this.lblCreateCustomer.Text = "Modificar Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.ImageKey = "Cuponete_Accept.png";
            this.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiar.Location = new System.Drawing.Point(324, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 46);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHabilitar.ImageKey = "Cuponete_Accept.png";
            this.btnHabilitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHabilitar.Location = new System.Drawing.Point(324, 82);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(200, 46);
            this.btnHabilitar.TabIndex = 31;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = true;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesbloquear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesbloquear.ImageKey = "Cuponete_Accept.png";
            this.btnDesbloquear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesbloquear.Location = new System.Drawing.Point(324, 139);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(200, 46);
            this.btnDesbloquear.TabIndex = 32;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // ModifCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 613);
            this.Controls.Add(this.lblCreateCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBoxCreateCustomer);
            this.Controls.Add(this.pictureCustomer);
            this.Controls.Add(this.btnAccept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifCliente";
            this.Text = "Modifcar Cliente";
            this.Load += new System.EventHandler(this.ModifCliente_Load);
            this.gBoxCreateCustomer.ResumeLayout(false);
            this.gBoxCreateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gBoxCreateCustomer;
        private System.Windows.Forms.DateTimePicker dtpBirhtday;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckedListBox chkBoxListPreferences;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.PictureBox pictureCustomer;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblCreateCustomer;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnDesbloquear;
    }
}