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
        public string previousName { get; set; }
        public ModificacionRoleForm(int roleId)
        {
            InitializeComponent();
            this.RoleId = roleId;
        }

        private void ModificacionRoleForm_Load(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("SELECT R.Name FROM TRANSA_SQL.Role R WHERE R.RoleId='{0}'", this.RoleId);
            this.txtNombre.Text = Conexion.Instance.ejecutarQuery(sentence.ToString()).Rows[0][0].ToString();
            this.previousName = this.txtNombre.Text;

            StringBuilder getEnabled = new StringBuilder().AppendFormat("SELECT R.Enabled FROM TRANSA_SQL.Role R WHERE R.RoleId='{0}'", this.RoleId);
            if ((bool)Conexion.Instance.ejecutarQuery(getEnabled.ToString()).Rows[0][0])
            {
                this.btnHabilitar.Visible = false;
            }
            else
            {
                this.btnHabilitar.Visible = true;
            }

            StringBuilder getUserTypeId = new StringBuilder().AppendFormat("SELECT DISTINCT(P.UserTypeId) FROM TRANSA_SQL.Permission P JOIN TRANSA_SQL.RolePermission RP ON RP.PermissionId=P.PermissionId WHERE RoleId='{0}'",this.RoleId);
            int userTypeId = (int)Conexion.Instance.ejecutarQuery(getUserTypeId.ToString()).Rows[0][0];

            StringBuilder sentence2 = new StringBuilder().AppendFormat("SELECT P.Name FROM TRANSA_SQL.Permission P WHERE P.UserTypeId='{0}'", userTypeId);
            DataTable tabla = Conexion.Instance.ejecutarQuery(sentence2.ToString());
            
            StringBuilder sentence3 = new StringBuilder().AppendFormat("SELECT P.Name FROM TRANSA_SQL.Role R JOIN TRANSA_SQL.RolePermission RP ON RP.RoleId=R.RoleId JOIN TRANSA_SQL.Permission P ON RP.PermissionId=P.PermissionId WHERE R.RoleId={0}", this.RoleId);
            DataTable tabla2 = Conexion.Instance.ejecutarQuery(sentence3.ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.lstBoxPermisos.Items.Add(tabla.Rows[i][0].ToString());
                for (int j = 0; j < tabla2.Rows.Count; j++)
                {
                    if (tabla.Rows[i][0].ToString() == tabla2.Rows[j][0].ToString())
                    {
                        this.lstBoxPermisos.SetSelected(i, true);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "" || this.lstBoxPermisos.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "No pueden haber campos vacios", "Error en modificacion de Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(this.previousName != this.txtNombre.Text)
                {
                    StringBuilder updateName = new StringBuilder().AppendFormat("UPDATE TRANSA_SQL.Role SET Name='{0}' WHERE RoleId={1}", this.txtNombre.Text, this.RoleId);
                    Conexion.Instance.ejecutarQuery(updateName.ToString());
                }

                StringBuilder sentence = new StringBuilder().AppendFormat("DELETE FROM TRANSA_SQL.RolePermission WHERE RoleId='{0}'", this.RoleId);
                Conexion.Instance.ejecutarQuery(sentence.ToString());

                System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
                comando1.CommandType = CommandType.StoredProcedure;

                comando1.Parameters.Add("@RoleId", SqlDbType.Int);
                comando1.Parameters.Add("@PermissionId", SqlDbType.Int);

                comando1.Parameters[0].Value = this.RoleId;

                StringBuilder sentence4;
                comando1.CommandText = "TRANSA_SQL.agregarRolePermission";

                List<string> permisos = new List<string>();

                for (int i = 0; i < this.lstBoxPermisos.SelectedItems.Count; i++)
			    {
			        permisos.Add(this.lstBoxPermisos.SelectedItems[i].ToString());
			    }

                foreach (string permiso in permisos)
                {
                    sentence4 = new StringBuilder().AppendFormat("SELECT P.PermissionId FROM TRANSA_SQL.Permission P WHERE P.Name='{0}'", permiso);
                    comando1.Parameters[1].Value = (int)Conexion.Instance.ejecutarQuery(sentence4.ToString()).Rows[0][0];
                    Conexion.Instance.ejecutarQueryConSP(comando1);
                }
                MessageBox.Show(this, "Se ha modificado el rol con exito", "Exito en modificacion de Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.lstBoxPermisos.ClearSelected();
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            StringBuilder sentence = new StringBuilder().AppendFormat("UPDATE TRANSA_SQL.Role SET Enabled=1 WHERE RoleId='{0}'", this.RoleId);
            Conexion.Instance.ejecutarQuery(sentence.ToString());
            MessageBox.Show(this, "El rol ha sido habilitado con exito", "Exito al habilitar Rol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.btnHabilitar.Visible = false;
        }
    }
}
