using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.ComprarGiftCard
{
    public partial class ComprarGiftForm : Form
    {
        private ComprarGiftApp _model = new ComprarGiftApp();

        public ComprarGiftApp Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public ComprarGiftForm(DataRow rowUser)
        {
            InitializeComponent();
            this.UserRow = rowUser;
        }

        private DataRow _userRow;

        public DataRow UserRow
        {
            get { return _userRow; }
            set { _userRow = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void ComprarGiftForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder();
            if ((int)this.UserRow["RoleId"] != 1)
            {
                


                sentence.Append("select c.PhoneNumber from TRANSA_SQL.Customer c where c.UserId<>").Append(this.UserRow["UserId"].ToString());
            }
            else
            {
                sentence.Append("select c.PhoneNumber from TRANSA_SQL.Customer c");

            }
            DataTable clientes = Conexion.Instance.ejecutarQuery(sentence.ToString());
            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                this.clienteDest.Items.Add(clientes.Rows[i]["PhoneNumber"].ToString());
                if ((int)this.UserRow["RoleId"] != 2)//es admin
                {
                    this.clienteOrig.Items.Add(clientes.Rows[i]["PhoneNumber"].ToString());
                }
            }
            if ((int)this.UserRow["RoleId"] == 2)
            {

                StringBuilder sent = new StringBuilder().AppendFormat("select * from TRANSA_SQL.Customer c where c.UserId={0}", this.UserRow["UserId"].ToString());   
                this.clienteOrig.Text=Conexion.Instance.ejecutarQuery(sent.ToString()).Rows[0]["PhoneNumber"].ToString();
                    this.clienteOrig.Hide();
                    this.label3.Hide();
                
            }
            StringBuilder sentenceMontos = new StringBuilder();
            sentenceMontos.Append("select distinct c.Amount from TRANSA_SQL.GiftCard c order by 1");
            DataTable Montos = Conexion.Instance.ejecutarQuery(sentenceMontos.ToString());
            for (int i = 0; i < Montos.Rows.Count; i++)
            {
                this.Monto.Items.Add(Montos.Rows[i][0].ToString());
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Model.ClienteDest = this.clienteDest.Text;
            this.Model.ClienteOrig = this.clienteOrig.Text;
            this.Model.Monto = this.Monto.Text;
            this.Model.comprar();
            this.Owner.Show();
            this.Close();
        }

        private void clienteOrig_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void clienteDest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
