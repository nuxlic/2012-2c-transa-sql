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
            this.lblName = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.pictureCustomer = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkBoxListPreferences = new System.Windows.Forms.CheckedListBox();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dtpBirhtday = new System.Windows.Forms.DateTimePicker();
            this.gBoxCreateCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreateCustomer
            // 
            resources.ApplyResources(this.lblCreateCustomer, "lblCreateCustomer");
            this.lblCreateCustomer.Name = "lblCreateCustomer";
            // 
            // gBoxCreateCustomer
            // 
            this.gBoxCreateCustomer.Controls.Add(this.dtpBirhtday);
            this.gBoxCreateCustomer.Controls.Add(this.txtDepartment);
            this.gBoxCreateCustomer.Controls.Add(this.txtFloor);
            this.gBoxCreateCustomer.Controls.Add(this.txtStreetNumber);
            this.gBoxCreateCustomer.Controls.Add(this.txtCity);
            this.gBoxCreateCustomer.Controls.Add(this.txtStreetName);
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
            this.gBoxCreateCustomer.Controls.Add(this.lblCity);
            this.gBoxCreateCustomer.Controls.Add(this.lblDepartment);
            this.gBoxCreateCustomer.Controls.Add(this.lblFloor);
            this.gBoxCreateCustomer.Controls.Add(this.lblStreetNumber);
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
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // btnAccept
            // 
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.ImageList = this.imageListButtons;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.UseVisualStyleBackColor = true;
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
            // pictureCustomer
            // 
            resources.ApplyResources(this.pictureCustomer, "pictureCustomer");
            this.pictureCustomer.Name = "pictureCustomer";
            this.pictureCustomer.TabStop = false;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // lblStreetName
            // 
            resources.ApplyResources(this.lblStreetName, "lblStreetName");
            this.lblStreetName.Name = "lblStreetName";
            // 
            // lblStreetNumber
            // 
            resources.ApplyResources(this.lblStreetNumber, "lblStreetNumber");
            this.lblStreetNumber.Name = "lblStreetNumber";
            // 
            // lblFloor
            // 
            resources.ApplyResources(this.lblFloor, "lblFloor");
            this.lblFloor.Name = "lblFloor";
            // 
            // lblDepartment
            // 
            resources.ApplyResources(this.lblDepartment, "lblDepartment");
            this.lblDepartment.Name = "lblDepartment";
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // lblPostalCode
            // 
            resources.ApplyResources(this.lblPostalCode, "lblPostalCode");
            this.lblPostalCode.Name = "lblPostalCode";
            // 
            // lblBirthday
            // 
            resources.ApplyResources(this.lblBirthday, "lblBirthday");
            this.lblBirthday.Name = "lblBirthday";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // chkBoxListPreferences
            // 
            this.chkBoxListPreferences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chkBoxListPreferences.FormattingEnabled = true;
            resources.ApplyResources(this.chkBoxListPreferences, "chkBoxListPreferences");
            this.chkBoxListPreferences.MultiColumn = true;
            this.chkBoxListPreferences.Name = "chkBoxListPreferences";
            this.chkBoxListPreferences.SelectedIndexChanged += new System.EventHandler(this.chkBoxListPreferences_SelectedIndexChanged);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "Cuponete_Accept.png");
            this.imageListButtons.Images.SetKeyName(1, "Cuponete_Cancel.png");
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ImageList = this.imageListButtons;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDni, "txtDni");
            this.txtDni.Name = "txtDni";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPostalCode, "txtPostalCode");
            this.txtPostalCode.Name = "txtPostalCode";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // txtStreetName
            // 
            this.txtStreetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtStreetName, "txtStreetName");
            this.txtStreetName.Name = "txtStreetName";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtStreetNumber, "txtStreetNumber");
            this.txtStreetNumber.Name = "txtStreetNumber";
            // 
            // txtFloor
            // 
            this.txtFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtFloor, "txtFloor");
            this.txtFloor.Name = "txtFloor";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDepartment, "txtDepartment");
            this.txtDepartment.Name = "txtDepartment";
            // 
            // dtpBirhtday
            // 
            this.dtpBirhtday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dtpBirhtday, "dtpBirhtday");
            this.dtpBirhtday.Name = "dtpBirhtday";
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
            this.gBoxCreateCustomer.ResumeLayout(false);
            this.gBoxCreateCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).EndInit();
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
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.CheckedListBox chkBoxListPreferences;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.DateTimePicker dtpBirhtday;
    }
}