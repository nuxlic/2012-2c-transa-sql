using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Reflection;
using GrouponDesktop.Commons.Database;

namespace GrouponDesktop.Commons.Database
{
    class GenericDAO
    {
        private SqlCommand ObtenerOrdenSql(string sentenciaSQL, ArrayList Parametros)
	    {
            SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["gd"].ConnectionString);
            SqlCommand orden = new SqlCommand(sentenciaSQL, conexion);
            orden.CommandType = CommandType.Text;
            foreach (SqlParameter p in Parametros)
	        orden.Parameters.Add(p);
	        return orden;
	    }

        private Dictionary<string , object> ObtenerElementos(object objeto, MemberTypes TipoElemento)
	    {
            try
	        {
	            Dictionary<string , object> Elementos = new Dictionary<string , object>();
	            foreach (MemberInfo infoMiembro in objeto.GetType().GetMembers())
	            {
	                if (infoMiembro.MemberType == TipoElemento)
	                {
	                if ((PropertyInfo)infoMiembro != null)
	                    Elementos.Add(((PropertyInfo)infoMiembro).Name, ((PropertyInfo)infoMiembro).GetValue(objeto, null));
	                }
	            }
	            return Elementos;
	        }
            catch (Exception ex)
	        {
	            throw (ex);
	        }

	    }

        public DataSet select(Object genericDTO)
        {
            DataSet ds = new DataSet();
            StringBuilder SQLString = new StringBuilder();
            StringBuilder Wheres = new StringBuilder();
            StringBuilder fields = new StringBuilder();
            ArrayList Parametros = new ArrayList();
            if (genericDTO == null)
                throw new NullReferenceException("GenericDAO.select(datos)");
            Dictionary<string , object> coleccionDatos = new Dictionary<string , object>();
        	coleccionDatos = ObtenerElementos(genericDTO, MemberTypes.Property);
            if (coleccionDatos != null)
	        {
	            foreach (string key in coleccionDatos.Keys)
	            {
	                if (coleccionDatos[key] != null)
	                {
	                    Wheres.Append(key).Append(" = @").Append(key).Append(" AND ");
	                    Parametros.Add(new SqlParameter("@" + key, coleccionDatos[key]));
                        fields.Append(key).Append(", ");
	                }
	            }
	        }
            SQLString.Append("SELECT ").Append(Wheres.ToString().Substring(0, Wheres.ToString().Length - 2)); 
            SQLString.Append(" FROM ").Append((genericDTO.GetType()).Name.TrimStart("DTO".ToCharArray()));
            if (Wheres.Length > 0)
	        {
	            SQLString.Append(" WHERE ");
	            SQLString.Append(Wheres.ToString().Substring(0, Wheres.ToString().Length - 4));
	        }
	        SqlCommand orden = ObtenerOrdenSql(SQLString.ToString(), Parametros);
	        SqlDataAdapter da = new SqlDataAdapter(orden);
	        da.Fill(ds);
	        return ds;
        }

    }
}
