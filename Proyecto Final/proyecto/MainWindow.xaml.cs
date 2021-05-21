using proyecto.Clases.Archivo;
using proyecto.Clases.BaseDatos;
using proyecto.Clases.Buscar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private DataTable DescargaDatos = new DataTable();

        private void CargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\DatosProyecto\proyecto.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexionSQL cnSQL = new ClsConexionSQL();
            ClsConexionMYSQL cnMYSQL = new ClsConexionMYSQL();
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia = "";
            int NumeroLinea = 0;

            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia += $"insert into tb_carros values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]});\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cnSQL.EjecutaSQLDirecto(sentencia);
            cnMYSQL.EjecutaMYSQLDirecto(sentencia);
        }

        private void ButtonCargar_Click(object sender, RoutedEventArgs e)
        {
            CargarArchivoExterno();
        }

        private void ButtonNumero_Click(object sender, RoutedEventArgs e)
        {
            ClsBSQL buscar = new ClsBSQL();
            string id = TextBox1.Text.Trim();
            string condicion = $"numero = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string marca = dt.Rows[0].Field<String>("marca");
                TextBox2.Text = marca;
            }
            else
            {
                TextBox2.Text = "SIN INFORMACION";
            }
        }

        private void ButtonMarca_Click(object sender, RoutedEventArgs e)
        {
            ClsBSQL buscar = new ClsBSQL();
            string marca = TextBox3.Text.Trim();
            string condicion = $"marca like ('%{marca}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string modelo = dt.Rows[0].Field<String>("modelo");
                TextBox2.Text = modelo + "";
            }
            else
            {
                TextBox2.Text = "SIN INFORMACION";
            }
        }

        private void ButtonModelo_Click(object sender, RoutedEventArgs e)
        {
            ClsBSQL buscar = new ClsBSQL();
            string modelo = TextBox5.Text.Trim();
            string condicion = $"modelo like ('%{modelo}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int anio = dt.Rows[0].Field<int>("anio");
                TextBox2.Text = anio + "";
            }
            else
            {
                TextBox2.Text = "SIN INFORMACION";
            }
        }

        private void ButtonNumero2_Click(object sender, RoutedEventArgs e)
        {
            ClsBMYSQL buscar = new ClsBMYSQL();
            string id = TextBox7.Text.Trim();
            string condicion = $"numero = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string marca = dt.Rows[0].Field<String>("marca");
                TextBox8.Text = marca;
            }
            else
            {
                TextBox8.Text = "SIN INFORMACION";
            }
        }

        private void ButtonMarca2_Click(object sender, RoutedEventArgs e)
        {
            ClsBMYSQL buscar = new ClsBMYSQL();
            string marca = TextBox9.Text.Trim();
            string condicion = $"marca like ('%{marca}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string modelo = dt.Rows[0].Field<String>("modelo");
                TextBox8.Text = modelo + "";
            }
            else
            {
                TextBox8.Text = "SIN INFORMACION";
            }
        }

        private void ButtonModelo2_Click(object sender, RoutedEventArgs e)
        {
            ClsBMYSQL buscar = new ClsBMYSQL();
            string modelo = TextBox11.Text.Trim();
            string condicion = $"modelo like ('%{modelo}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int anio = dt.Rows[0].Field<int>("anio");
                TextBox8.Text = anio + "";
            }
            else
            {
                TextBox8.Text = "SIN INFORMACION";
            }
        }

        public DataTable Buscartodo(string condicion = "1=1")
        {
            ClsConexionSQL cn = new ClsConexionSQL();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_carros where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            
            return dt;
        }

        private void Ejecutar(String instruccion)
        {           
            ClsConexionSQL cn = new  ClsConexionSQL();           
            cn.EjecutaSQLDirecto(instruccion);
            Buscartodo();
            
        }

        private bool Datoexistente(string num)
        {
            string condicion = $"numero = {num}";
            DataTable dt = Buscartodo(condicion);
            return (dt.Rows.Count > 0);
        }


        private void ButtonActualizar_Click(object sender, RoutedEventArgs e)
        {
            string num = TextBox1.Text;
            string mar = TextBox12.Text;
            string instruccion = $"update tb_carros set marca = '{mar}' where numero = {num}";
            Ejecutar(instruccion);
        }

        private void ButtonBorrar_Click(object sender, RoutedEventArgs e)
        {
            string num = TextBox1.Text;
            string mar = TextBox12.Text;
            string instruccion = $"delete tb_carros where numero = {num}";
            Ejecutar(instruccion);
        }

        private void ButtonInsertar_Click(object sender, RoutedEventArgs e)
        {
            string num = TextBox1.Text;
            string mar = TextBox12.Text;
            string instruccion = $"insert into tb_carros (numero,marca) values ({num}, '{mar}')";

            if (Datoexistente(num))
            {
                TextBox2.Text = "YA EXISTE EL DATO";
            }
            else
            {
                Ejecutar(instruccion);
            }
        }

        private void ButtonDescargar_Click(object sender, RoutedEventArgs e)
        {
            ClsDescargar dt = new ClsDescargar();
            dt.Descarga(DescargaDatos);
            TextBox12.Text = "CREADO EN CARPETA"; 
        }
    }
}
