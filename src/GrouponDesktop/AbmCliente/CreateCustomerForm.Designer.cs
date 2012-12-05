namespace GrouponDesktop.AbmCliente
{
    partial class CreateCustomerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCustomerForm));
            this.lblCreateCustomer = new System.Windows.Forms.Label();
            this.gBoxCreateCustomer = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.pictureCustomer = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxCreateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateCustomer
            // 
            resources.ApplyResources(this.lblCreateCustomer, "lblCreateCustomer");
            this.lblCreateCustomer.Name = "lblCreateCustomer";
            // 
            // gBoxCreateCustomer
            // 
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
            resources.ApplyResources(this.gBoxCreateCustomer, "gBoxCreateCustomer");
            this.gBoxCreateCustomer.Name = "gBoxCreateCustomer";
            this.gBoxCreateCustomer.TabStop = false;
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.ImageList = this.imageListButtons;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "Cuponete_Accept.png");
            this.imageListButtons.Images.SetKeyName(1, "Cuponete_Cancel.png");
            // 
            // dtpBirhtday
            // 
            this.dtpBirhtday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dtpBirhtday, "dtpBirhtday");
            this.dtpBirhtday.Name = "dtpBirhtday";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // chkBoxListPreferences
            // 
            this.chkBoxListPreferences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkBoxListPreferences.FormattingEnabled = true;
            resources.ApplyResources(this.chkBoxListPreferences, "chkBoxListPreferences");
            this.chkBoxListPreferences.MultiColumn = true;
            this.chkBoxListPreferences.Name = "chkBoxListPreferences";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPostalCode, "txtPostalCode");
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDni, "txtDni");
            this.txtDni.Name = "txtDni";
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // lblBirthday
            // 
            resources.ApplyResources(this.lblBirthday, "lblBirthday");
            this.lblBirthday.Name = "lblBirthday";
            // 
            // lblPostalCode
            // 
            resources.ApplyResources(this.lblPostalCode, "lblPostalCode");
            this.lblPostalCode.Name = "lblPostalCode";
            // 
            // lblStreetName
            // 
            resources.ApplyResources(this.lblStreetName, "lblStreetName");
            this.lblStreetName.Name = "lblStreetName";
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblDni
            // 
            resources.ApplyResources(this.lblDni, "lblDni");
            this.lblDni.Name = "lblDni";
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.lblSurname.Name = "lblSurname";
            // 
            // btnAccept
            // 
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.ImageList = this.imageListButtons;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // pictureCustomer
            // 
            resources.ApplyResources(this.pictureCustomer, "pictureCustomer");
            this.pictureCustomer.Name = "pictureCustomer";
            this.pictureCustomer.TabStop = false;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ImageList = this.imageListButtons;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateCustomerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gBoxCreateCustomer);
            this.Controls.Add(this.lblCreateCustomer);
            this.Controls.Add(this.pictureCustomer);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateCustomerForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.CreateCustomerForm_Load);
            this.gBoxCreateCustomer.ResumeLayout(false);
            this.gBoxCreateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateCustomer;
        private System.Windows.Forms.GroupBox gBoxCreateCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.PictureBox pictureCustomer;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.CheckedListBox chkBoxListPreferences;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirhtday;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}