using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.AbmCliente;
using GrouponDesktop.Commons.Database;

using GrouponDesktop.AbmProveedor;

namespace GrouponDesktop.AbmRol
{
    public partial class BusqModifRole : Form
    {
        private BusquedaApp model = new BusquedaApp();
        public BusqModifRole()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            new AbmProveedor.AltaProvApp().validarSoloLetrasYnumeros(e);
        }

        protected virtual void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='{0}'", this.dataGridView2.CurrentRow.Cells[1].Value);
                int roleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0];
                ModificacionRoleForm modif = new ModificacionRoleForm(roleId);
                this.Hide();
                modif.ShowDialog();
                this.Show();
            }
        }

        private void BusqModifRole_Load(object sender, EventArgs e)
        {
            this.dataGridView2.DataSource = this.model.buscar();
            this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
