using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Login
{
    public partial class RegistroUsuarioForm : Form
    {
        public RegistroUsuarioForm(Form owner)
        {   
            InitializeComponent();
            this.Ownerw = owner;
            
        }

        private Form _ownerw;

        public Form Ownerw
        {
            get { return _ownerw; }
            set { _ownerw = value; }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Ownerw.Close();
            this.Close();
        }
    }
}
