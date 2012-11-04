using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlTypes;

namespace GrouponDesktop.Commons.Database.Entidades
{
    [Table(Name = "GD2C2012.TRANSA_SQL.CuponeteUser")]
    class CuponeteUser
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, AutoSync=AutoSync.OnInsert)]
                    public int UserId { get; set; }
        [Column] public string Username { get; set; }
        [Column] public string Password { get; set; }
        [Column] public SqlByte FailedAttemps { get; set; }
        [Column] public int RoleId { get; set; }
        [Column] public SqlBoolean Enabled { get; set; }
        [Column] public SqlBoolean Deleted { get; set; }
        /*public override string ToString()
        {
            return string.Format("Nombre: {0}nAutor: {1}", Nombre, Autor);
        }*/
    }
}
