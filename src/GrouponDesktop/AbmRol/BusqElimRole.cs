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
    public partial class BusqElimRole : BusqModifRole
    {
        private ElimRole model = new ElimRole();
        public BusqElimRole()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.Name = "Borrar";
            this.dataGridView2.Columns.RemoveAt(0);
            this.dataGridView2.Columns.Add(btnModificar);
        }

        protected override void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='{0}'", this.dataGridView2.CurrentRow.Cells[1].Value);
                int roleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0];
                StringBuilder sentence2 = new StringBuilder().AppendFormat("SELECT R.Enabled FROM TRANSA_SQL.Role R WHERE R.RoleId='{0}'", roleId);
                if (!(bool)Conexion.Instance.ejecutarQuery(sentence2.ToString()).Rows[0][0])
                {
                    MessageBox.Show(this, "El rol ya se encuentra dado de baja", "Error al dar de baja un Rol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.model.eliminar(roleId);
                    MessageBox.Show(this, "El rol se ha dado de baja con exito", "Baja de Rol Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
