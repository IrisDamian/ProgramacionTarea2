using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Tareasemana10.CLASES.BasedeDatos;

namespace Tareasemana10.CLASES.Busqueda
{
    public class ClsDatosSQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexionSQL cn = new ClsConexionSQL();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
    }
}