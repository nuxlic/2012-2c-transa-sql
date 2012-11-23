using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.AbmProveedor
{
    public class AltaProvApp
    {

        private string _cityId;

        public string CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }
        private string _entryId;

        public string EntryId
        {
            get { return _entryId; }
            set { _entryId = value; }
        }
        
        private string _userId;
        private string _personalDataId;

        public string PersonalDataId
        {
            get { return _personalDataId; }
            set { _personalDataId = value; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private string _razonSocial;

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }
        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _codigoPostal;

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
        private string _ciudad;

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
        private string _cuit;

        public string Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        private string _rubro;

        public string Rubro
        {
            get { return _rubro; }
            set { _rubro = value; }
        }
        private string _numeroContac;

        public string NumeroContac
        {
            get { return _numeroContac; }
            set { _numeroContac = value; }
        }

        internal bool existeProveedor()
        {
            StringBuilder sentence = new StringBuilder().Append("select * from TRANSA_SQL.Supplier s where s.CorporateName='").Append(this.RazonSocial).Append("' and s.Cuit='").Append(this.Cuit).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            return table.Rows.Count > 0;
        }


        internal string dameMiRoleId()
        {
            StringBuilder sentence = new StringBuilder().Append("select * from TRANSA_SQL.Role r where r.Name='Supplier'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            return table.Rows[0]["RoleId"].ToString();
        }

        internal void crearUsuario()
        {
            StringBuilder sentence = new StringBuilder().Append("insert into TRANSA_SQL.CuponeteUser values ('").Append(this.Cuit).Append("',").Append("'47f5390d283f8cbcc8272dbc288b2cae42ec57d13cb8abea14cd7754f2be57dd',").Append("0,").Append(this.dameMiRoleId()).Append(",1,0)");
            Conexion.Instance.ejecutarQuery(sentence.ToString());
            sentence = new StringBuilder().Append("select * from TRANSA_SQL.CuponeteUser cu where cu.Username='").Append(this.Cuit).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            
            this.UserId= table.Rows[0]["UserId"].ToString();
        }

        internal void crearPersonalData()
        {
            StringBuilder sentence = new StringBuilder().Append("insert into TRANSA_SQL.PersonalData values (").Append(this.UserId).Append(", '").Append(this.Mail).Append("','").Append(this.CodigoPostal).Append("','").Append(this.Direccion).Append("')");
            Conexion.Instance.ejecutarQuery(sentence.ToString());
            sentence = new StringBuilder().Append("select * from TRANSA_SQL.PersonalData pd where pd.UserId='").Append(this.UserId).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            
            this.PersonalDataId = table.Rows[0]["PersonalDataId"].ToString();
        }

        internal string getOrSetCityId()
        {
            string toReturn=null;
            StringBuilder sentence = new StringBuilder().Append("select * from TRANSA_SQL.City c where c.Name='").Append(this.Ciudad).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["CityId"].ToString();
            }
            else
            {
                StringBuilder sentce = new StringBuilder().Append("insert into TRANSA_SQL.City values ('").Append(this.Ciudad).Append("')");
                Conexion.Instance.ejecutarQuery(sentce.ToString());
                sentence = new StringBuilder().Append("select * from TRANSA_SQL.City c where c.Name='").Append(this.Ciudad).Append("'");
                DataTable tab = Conexion.Instance.ejecutarQuery(sentence.ToString());
                
                toReturn = tab.Rows[0]["CityId"].ToString();
            }
            return toReturn;
        }

        internal string getOrSetEntryId()
        {
            string toReturn = null;
            StringBuilder sentence = new StringBuilder().Append("select * from TRANSA_SQL.Entry e where e.Name='").Append(this.Rubro).Append("'");
            DataTable table = Conexion.Instance.ejecutarQuery(sentence.ToString());
            if (table.Rows.Count > 0)
            {
                return table.Rows[0]["EntryId"].ToString();
            }
            else
            {
                StringBuilder sentce = new StringBuilder().Append("insert into TRANSA_SQL.Entry values ('").Append(this.Rubro).Append("')");
                Conexion.Instance.ejecutarQuery(sentce.ToString());
                sentence = new StringBuilder().Append("select * from TRANSA_SQL.Entry r where r.Name='").Append(this.Rubro).Append("'");
                DataTable tab = Conexion.Instance.ejecutarQuery(sentence.ToString());
                
                toReturn = tab.Rows[0]["EntryId"].ToString();
            }
            return toReturn;
        }

        public void crearSupplier()
        {
            this.EntryId = getOrSetEntryId();
            this.CityId = getOrSetCityId();
            if (!existeProveedor())
            {
                this.crearUsuario();
                this.crearPersonalData();
                StringBuilder sentence = new StringBuilder().Append("insert into TRANSA_SQL.Supplier values ('").Append(this.RazonSocial).Append("', '").Append(this.Cuit).Append("',").Append(this.UserId).Append(",").Append(this.Telefono).Append(",1, ").Append(this.CityId).Append(", ").Append(this.EntryId).Append(", '").Append(this.NumeroContac).Append("', ").Append(this.PersonalDataId).Append(")");
                Conexion.Instance.ejecutarQuery(sentence.ToString());
                MessageBox.Show("El Proveedor ha sido de alta con exito", "Informacion:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Proveedor ya existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
