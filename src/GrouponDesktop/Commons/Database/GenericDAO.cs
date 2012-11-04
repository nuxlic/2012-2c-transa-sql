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
            conexion.Open();
            SqlCommand orden = new SqlCommand(sentenciaSQL, conexion);
            orden.CommandType = CommandType.Text;
            if (Parametros!=null){
            foreach (SqlParameter p in Parametros)
	        orden.Parameters.Add(p);
            }
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
        
        
        public StringBuilder armarSelect(Object genericDTO,String campos,String from,ArrayList Parametros)
        {
           StringBuilder sentenciaSql = new StringBuilder();
            StringBuilder where = new StringBuilder().Append("");
            Dictionary<String, Object> datosBindeados = ObtenerElementos(genericDTO, MemberTypes.Property);
            
            if (campos != null)
            {
                sentenciaSql.Append(campos);
            }
            else
            {
                sentenciaSql.Append("*");
            }
             sentenciaSql.Append(" FROM ").Append("TRANSA_SQL.").Append((genericDTO.GetType()).Name.TrimStart("DTO".ToCharArray()));
             if (from != null)
             {
                 sentenciaSql.Append(from);
             }
            
                
            if (datosBindeados != null)
            {
                bool todosEnNull = true;
                where.Append(" WHERE ");
                foreach (String key in datosBindeados.Keys)
                {
                    if (datosBindeados[key] != null)
                    {
                        todosEnNull = false;
                        where.Append(key).Append(" = @").Append(key).Append(" AND ");
                        Parametros.Add(new SqlParameter("@" + key, datosBindeados[key]));
                    }
                }
                if (!todosEnNull)
                {
                    sentenciaSql.Append(where.ToString().Substring(0, where.ToString().Length - 4));
                }
            }
            return sentenciaSql;
        }
        
        
        ///////////////////////////////////////////---OPERACIONES SQL----/////////////////////////////////
        
        /*
         * campos = lista de columnas que quiero filtrar
         * from = en caso de join o de querer sacar de 2 o mas tablas
         * */
        public DataSet select(Object genericDTO,string campos,String from)
        {
            ArrayList Parametros= new ArrayList();
            StringBuilder sentenciaSql=new StringBuilder().Append("use GD2C2012 select ").Append(this.armarSelect(genericDTO,campos,from,Parametros).ToString());
            DataSet Tabla = new DataSet();
            SqlCommand orden = ObtenerOrdenSql(sentenciaSql.ToString(), Parametros);
            SqlDataAdapter dataAdapt = new SqlDataAdapter(orden);
            dataAdapt.Fill(Tabla);
            return Tabla;

        }

        public void insertSelect(Object genericDTO, StringBuilder select)
        {
            StringBuilder insertSelect = new StringBuilder();
            insertSelect.Append("use GD2C2012 INSERT INTO ").Append("TRANSA_SQL.").Append((genericDTO.GetType()).Name.TrimStart("DTO".ToCharArray())).Append(" ").Append(select.ToString());
            SqlCommand orden =ObtenerOrdenSql(insertSelect.ToString(),null);
            SqlDataReader dr= orden.ExecuteReader();
            dr.Close();
        }

        public void insertValues(Object genericDTO)
        {
            //todo implementar
        }


       
    }
}
