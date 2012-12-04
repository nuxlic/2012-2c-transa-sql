using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GrouponDesktop.Commons.Database;
using System.Windows.Forms;

namespace GrouponDesktop.Login
{
    class RegistrarProveedorApp
    {
        public string Ciudad{ get; set; }
        public string CodigoPostal { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string NumeroContac { get; set; }
        public string RazonSocial { get; set; }
        public string Rubro { get; set; }
        public string Telefono { get; set; }
        public int UserId { get; set; }

        public RegistrarProveedorApp(int userId)
        {
            this.UserId = userId;
        }

        internal bool existeProveedor()
        {
            bool hayError = false;
            StringBuilder msjerror = new StringBuilder();
            msjerror.AppendLine("Los siguientes campos ya estan registrados:");
            StringBuilder sentence1 = new StringBuilder().AppendFormat("SELECT * FROM TRANSA_SQL.Supplier S WHERE S.CorporateName='{0}'",this.RazonSocial);
            DataTable table = Conexion.Instance.ejecutarQuery(sentence1.ToString());
            if (table.Rows.Count > 0)
            {
                msjerror.AppendLine("Razon Social");
                hayError = true;
            }

            StringBuilder sentence2 = new StringBuilder().AppendFormat("SELECT * FROM TRANSA_SQL.Supplier S WHERE S.Cuit='{0}'", this.Cuit);
            table = Conexion.Instance.ejecutarQuery(sentence2.ToString());
            if (table.Rows.Count > 0)
            {
                msjerror.AppendLine("Cuit");
                hayError = true;
            }

            if (hayError)
            {
                MessageBox.Show(msjerror.ToString(), "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool registrarProveedor()
        {
            if (this.Ciudad == "" || this.CodigoPostal == "" || this.Cuit == "" || this.Direccion == "" || this.Mail == "" || this.NumeroContac == "" || this.RazonSocial == "" || this.Rubro == "" || this.Telefono == "")
            {
                MessageBox.Show("Error: No debe dejar campos en blanco", "Error en Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {

                if (!existeProveedor())
                {
                    System.Data.SqlClient.SqlCommand comando1 = new System.Data.SqlClient.SqlCommand();
                    comando1.CommandType = CommandType.StoredProcedure;

                    comando1.Parameters.Add("@UserId", SqlDbType.Int);
                    comando1.Parameters.Add("@RazonSoc", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@Mail", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@Phone", SqlDbType.BigInt);
                    comando1.Parameters.Add("@Addr", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@PostalCode", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@City", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@Entry", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@Cuit", SqlDbType.NVarChar);
                    comando1.Parameters.Add("@Contact", SqlDbType.NVarChar);

                    comando1.Parameters[0].Value = this.UserId;
                    comando1.Parameters[1].Value = this.RazonSocial;
                    comando1.Parameters[2].Value = this.Mail;
                    comando1.Parameters[3].Value = this.Telefono;
                    comando1.Parameters[4].Value = this.Direccion;
                    comando1.Parameters[5].Value = this.CodigoPostal;
                    comando1.Parameters[6].Value = this.Ciudad;
                    comando1.Parameters[7].Value = this.Rubro;
                    comando1.Parameters[8].Value = this.Cuit;
                    comando1.Parameters[9].Value = this.NumeroContac;

                    comando1.CommandText = "TRANSA_SQL.registrarProveedor";
                    Conexion.Instance.ejecutarQueryConSP(comando1);
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public void validarSoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarSoloLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarSoloLetrasYnumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarCuit(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void validarMail(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '@')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
