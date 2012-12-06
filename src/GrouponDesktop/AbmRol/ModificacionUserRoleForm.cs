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
    public partial class ModificacionUserRoleForm : Form
    {        
        private string RoleName;
        private string PreviousRole;
        private int UserId;
        public ModificacionUserRoleForm(int userId, int roleId)
        {
            InitializeComponent();
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.Name FROM TRANSA_SQL.Role R WHERE R.RoleId='{0}'", roleId);
            this.RoleName = Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0].ToString();
            this.PreviousRole = this.RoleName;
            this.UserId = userId;
        }

        private void ModificacionUserRoleForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.Name FROM TRANSA_SQL.Role R");
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence.ToString());
            
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.cmbRole.Items.Add(tabla.Rows[i]["Name"].ToString());
                if (tabla.Rows[i]["Name"].ToString() == this.RoleName)
                {
                    this.cmbRole.SelectedIndex = i;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbRole.SelectedItem.ToString() == this.PreviousRole)
            {
                this.Close();
            }
            else
            {
                StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.RoleId FROM TRANSA_SQL.Role R WHERE R.Name='{0}'", this.cmbRole.SelectedItem.ToString());
                int selectedRoleId = (int)Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0]["RoleId"];

                StringBuilder sentence2 = new StringBuilder().AppendFormat("SELECT DISTINCT(P.UserTypeId) FROM TRANSA_SQL.Permission P JOIN TRANSA_SQL.RolePermission RP ON RP.PermissionId=P.PermissionId WHERE RoleId='{0}'", selectedRoleId);
                int userTypeId = (int)Conexion.Instance.ejecutarQuery(sentence2.ToString()).Rows[0]["UserTypeId"];

                StringBuilder sentence4 = new StringBuilder().AppendFormat("SELECT CU.UserTypeId FROM TRANSA_SQL.CuponeteUser CU WHERE UserId='{0}'", this.UserId);
                int previousUserTypeId = (int)Conexion.Instance.ejecutarQuery(sentence4.ToString()).Rows[0]["UserTypeId"];

                bool firstLoginValue = previousUserTypeId != userTypeId && userTypeId != 1;

                StringBuilder sentence3 = new StringBuilder().AppendFormat("UPDATE TRANSA_SQL.CuponeteUser SET FirstLogin='{3}', UserTypeId='{0}', RoleId='{1}' WHERE UserId='{2}'", userTypeId, selectedRoleId, this.UserId, firstLoginValue);
                Conexion.Instance.ejecutarQuery(sentence3.ToString());

                MessageBox.Show(this, "El usuario ha sido cambiado de role con exito", "Exito en cambio de rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
