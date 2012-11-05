using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrouponDesktop
{
    public partial class MainForm : Form
    {
        public MainForm(Form owner)
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
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this._Owner.Close();
            this.Close();
        }
    }
}
