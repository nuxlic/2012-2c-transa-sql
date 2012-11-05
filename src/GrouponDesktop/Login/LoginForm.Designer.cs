using System.Resources;

namespace GrouponDesktop
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.imageButtonList = new System.Windows.Forms.ImageList(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // gBoxLogin
            // 
            this.gBoxLogin.Controls.Add(this.btnSignIn);
            this.gBoxLogin.Controls.Add(this.btnAccept);
            this.gBoxLogin.Controls.Add(this.txtPassword);
            this.gBoxLogin.Controls.Add(this.txtUserName);
            this.gBoxLogin.Controls.Add(this.lblPassword);
            this.gBoxLogin.Controls.Add(this.lblUserName);
            this.gBoxLogin.Controls.Add(this.pictureLogin);
            this.gBoxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.gBoxLogin, "gBoxLogin");
            this.gBoxLogin.Name = "gBoxLogin";
            this.gBoxLogin.TabStop = false;
            this.gBoxLogin.Enter += new System.EventHandler(this.gBoxLogin_Enter);
            // 
            // btnSignIn
            // 
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.ImageList = this.imageButtonList;
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // imageButtonList
            // 
            this.imageButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageButtonList.ImageStream")));
            this.imageButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageButtonList.Images.SetKeyName(0, "Cuponete_Accept.png");
            this.imageButtonList.Images.SetKeyName(1, "Cuponete_Cancel.png");
            this.imageButtonList.Images.SetKeyName(2, "Cuponete_passwordRecovery.png");
            this.imageButtonList.Images.SetKeyName(3, "Cuponete_Signin.ico");
            // 
            // btnAccept
            // 
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.ImageList = this.imageButtonList;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // pictureLogin
            // 
            resources.ApplyResources(this.pictureLogin, "pictureLogin");
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.TabStop = false;
            this.pictureLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFooter
            // 
            resources.ApplyResources(this.lblFooter, "lblFooter");
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnAccept;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.gBoxLogin);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gBoxLogin.ResumeLayout(false);
            this.gBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox gBoxLogin;
        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ImageList imageButtonList;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

