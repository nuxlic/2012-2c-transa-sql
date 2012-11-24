using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Linq.SqlClient;

namespace GrouponDesktop.AbmProveedor
{
    public class BusquedaApp
    {
        private string _razonSoc = null;
        
        public string RazonSoc
        {
            get { return _razonSoc; }
            set { _razonSoc = value; }
        }
        private string _cuit = null;

        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        private string _Mail = null;

        public string Mail
        {
            get { return _Mail; }
            set { _Mail = value; }
        }

        private DataTable _tabla;

        public DataTable Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }

        public void loadForm()
        {
            StringBuilder sentence = new StringBuilder().Append("select s.CorporateName,p.Email,s.PhoneNumber,p.Address,p.PostalCode,c.Name,s.Cuit,e.Name,s.ContactName from TRANSA_SQL.Supplier s join TRANSA_SQL.PersonalData p on p.PersonalDataId=s.PersonalDataId join TRANSA_SQL.City c on c.CityId=s.CityId join TRANSA_SQL.Entry e on e.EntryId=s.EntryId");
            this.Tabla = GrouponDesktop.Commons.Database.Conexion.Instance.ejecutarQuery(sentence.ToString());
        }

        public List<DataRow> buscar()
        {   List<DataRow> ret = new List<DataRow>();
        List<DataRow> toret = new List<DataRow>();
            if ((this.RazonSoc == null || this.RazonSoc == "") && (this.Mail == null || this.Mail == "") && (this.Cuit == null || this.Cuit == ""))
            {
                MessageBox.Show("Error: Debe al menos completar un filtro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                for (int i = 0; i < this.Tabla.Rows.Count; i++)
                {
                    ret.Add(this.Tabla.Rows[i]);
                }
                toret=ret.FindAll(unProveedor => unProveedor["Cuit"].ToString() == this.Cuit);
                
                //TODO implementar estos filtros.. por ahora no andan
                /*if(this.RazonSoc!=null && this.RazonSoc!="")
                {
                    toret.AddRange((ret.FindAll(unProveedor => SqlMethods.Like(unProveedor[0].ToString(),this.RazonSoc))));
                }
                if (this.Mail != null && this.Mail !="")
                {
                    toret.AddRange(ret.FindAll((unProveedor => Regex.IsMatch(unProveedor["Email"].ToString(), new StringBuilder().Append("*[").Append(this.Mail).Append("]").ToString()))));
                }*/
            }
            return ret;
        }
    }
}
