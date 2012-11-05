using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop.Dialogos_de_Error
{
    public partial class UsuarioBloquead : Form
    {
        public UsuarioBloquead(Form owner)
        {
            this._Owner = owner;
            InitializeComponent();


        }

        private Form _owner;

        public Form _Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this._Owner.Close();
            this.Close();
        }

        private void UsuarioBloquead_Load(object sender, EventArgs e)
        {

        }
    }
}
