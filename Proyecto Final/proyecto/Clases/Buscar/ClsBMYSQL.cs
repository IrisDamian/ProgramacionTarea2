using proyecto.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace proyecto.Clases.Buscar
{
    class ClsBMYSQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexionMYSQL cn = new ClsConexionMYSQL();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_carros where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
    }
}
