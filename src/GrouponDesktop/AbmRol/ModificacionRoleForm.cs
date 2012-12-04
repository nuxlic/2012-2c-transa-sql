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
    public partial class ModificacionRoleForm : Form
    {
        public int RoleId { get; set; }
        public ModificacionRoleForm(int roleId)
        {
            InitializeComponent();
            this.RoleId = roleId;
        }

        private void ModificacionRoleForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.Name FROM TRANSA_SQL.Role R WHERE R.RoleId='{0}'", this.RoleId);
            this.txtNombre.Text = Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0].ToString();

            StringBuilder sentence2 = new StringBuilder().AppendFormat("SELECT P.Name FROM TRANSA_SQL.Permission P");
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence2.ToString());
            
            StringBuilder sentence3 = new StringBuilder().AppendFormat("SELECT P.Name FROM TRANSA_SQL.Role R JOIN TRANSA_SQL.RolePermission RP ON RP.RoleId=R.RoleId JOIN TRANSA_SQL.Permission P ON RP.PermissionId=P.PermissionId WHERE R.RoleId={0}", this.RoleId);
            DataTable tabla2 = Conexion.Instance.ejecutarQuery(sentence3.ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.lstBoxPermisos.Items.Add(tabla.Rows[i][0].ToString());
            }

            for (int i = 0; i < tabla2.Rows.Count; i++)
            {
                this.lstBoxPermisos.SetSelected(
            }
        }
    }
}
