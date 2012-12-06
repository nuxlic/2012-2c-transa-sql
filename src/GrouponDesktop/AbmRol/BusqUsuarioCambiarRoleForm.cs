using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmRol
{
    public partial class BusqUsuarioCambiarRoleForm : Form
    {
        private BusqModifUserRole model = new BusqModifUserRole();

        public BusqUsuarioCambiarRoleForm()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtUserName.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.model.Username = this.txtUserName.Text;
            this.dataGridView2.DataSource = this.model.buscar();
            this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void BusqUsuarioCambiarRoleForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT CU.UserName, R.Name FROM TRANSA_SQL.CuponeteUser CU JOIN TRANSA_SQL.Role R ON R.RoleId=CU.RoleId");
            this.dataGridView2.DataSource = Conexion.Instance.ejecutarQuery(sentence.ToString());
            this.dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("SELECT CU.UserId, CU.RoleId FROM TRANSA_SQL.CuponeteUser CU WHERE CU.Username='{0}'", this.dataGridView2.CurrentRow.Cells[1].Value);
                int roleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0]["RoleId"];
                int userId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0]["UserId"];
                ModificacionUserRoleForm modif = new ModificacionUserRoleForm(userId, roleId);
                this.Hide();
                modif.ShowDialog();
                this.Show();
            }
        }

    }
}
