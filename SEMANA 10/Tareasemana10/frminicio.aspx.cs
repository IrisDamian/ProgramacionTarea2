using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tareasemana10.CLASES.Archivo;
using Tareasemana10.CLASES.BasedeDatos;
using Tareasemana10.CLASES.Busqueda;

namespace Tareasemana10
{
    public partial class frminicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\Datos Archivo\archivo.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexionSQL cnSQL = new ClsConexionSQL();
            ClsConexionMYSQL cnMYSQL = new ClsConexionMYSQL();
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia = "";
            int NumeroLinea = 0;

            //Iteramos sobre el Arreglo, linea por linea,para convertir en datos individuales.
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia += $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cnSQL.EjecutaSQLDirecto(sentencia);
            cnMYSQL.EjecutaMYSQLDirecto(sentencia);
        }

        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            CargarArchivoExterno();
        }

        protected void ButtonNombre_Click(object sender, EventArgs e)
        {
            ClsDatosSQL buscar = new ClsDatosSQL();
            string nombre = TextBoxNB.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBoxNB2.Text = id + "";
            }
            else
            {
                TextBoxNB2.Text = "NO EXISTE ESA INFORMACION";
            }
        }

        protected void ButtonCorrelativo_Click(object sender, EventArgs e)
        {
            ClsDatosSQL buscar = new ClsDatosSQL();
            string id = TextBoxCR.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxCR2.Text = nombre;
            }
            else
            {
                TextBoxCR2.Text = "NO EXISTE ESA INFORMACION";
            }
        }

        protected void ButtonNombreM_Click(object sender, EventArgs e)
        {
            ClsDatosMYSQL buscar = new ClsDatosMYSQL();
            string nombre = TextBoxNB3.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBoxNB4.Text = id + "";
            }
            else
            {
                TextBoxNB4.Text = "NO EXISTE ESA INFORMACION";
            }
        }

        protected void ButtonCorrelativoM_Click(object sender, EventArgs e)
        {
            ClsDatosMYSQL buscar = new ClsDatosMYSQL();
            string id = TextBoxCR3.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBoxCR4.Text = nombre;
            }
            else
            {
                TextBoxCR4.Text = "NO EXISTE ESA INFORMACION";
            }
        }
    }
}