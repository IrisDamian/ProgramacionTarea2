using SegundoParcial.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clsarchivo ar = new Clsarchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Escoja su archivo que deseea";
            ofd.InitialDirectory = @"C:\Users\Iris Damian\Desktop\Archivo";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
            }
        }

        private void buttonNA_Click(object sender, EventArgs e)
        {
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Correlativo] = datosUni[0];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Nombre] = datosUni[1];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial1] = datosUni[2];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial2] = datosUni[3];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial3] = datosUni[4];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Seccion] = datosUni[5];
                NumeroLinea++;
                listBoxNA.Items.Add($"{ datosUni[Clsenumcolumnas.Nombre]}  {datosUni[Clsenumcolumnas.Seccion]}");
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            int parcial1, parcial2, parcial3, resultado;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Correlativo] = datosUni[0];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Nombre] = datosUni[1];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial1] = datosUni[2];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial2] = datosUni[3];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial3] = datosUni[4];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Seccion] = datosUni[5];
                NumeroLinea++;
                parcial1 = Convert.ToInt32(datosUni[2]);
                parcial2 = Convert.ToInt32(datosUni[3]);
                parcial3 = Convert.ToInt32(datosUni[4]);
                resultado = (parcial1 + parcial2 + parcial3) / 3;
                listBoxPro.Items.Add($"{datosUni[Clsenumcolumnas.Correlativo]}         {resultado}");
            }
        }

        private void buttonPg_Click(object sender, EventArgs e)
        {
            Promedios promedio = new Promedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Correlativo] = datosUni[0];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Nombre] = datosUni[1];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial1] = datosUni[2];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial2] = datosUni[3];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial3] = datosUni[4];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Seccion] = datosUni[5];
                NumeroLinea++;
            }
            int Nota = promedio.promedios_por_parcial(ArregloDosDimensiones, Clsenumcolumnas.Parcial1);
            listBoxProG.Items.Add($"Parcial Uno= {Nota}");
            int Nota2 = promedio.promedios_por_parcial(ArregloDosDimensiones, Clsenumcolumnas.Parcial2);
            listBoxProG.Items.Add($"Parcial Dos= {Nota2}");
            int Nota3 = promedio.promedios_por_parcial(ArregloDosDimensiones, Clsenumcolumnas.Parcial3);
            listBoxProG.Items.Add($"Parcial Tres= {Nota3}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGs_Click(object sender, EventArgs e)
        {
            Promedios promedio = new Promedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Correlativo] = datosUni[0];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Nombre] = datosUni[1];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial1] = datosUni[2];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial2] = datosUni[3];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial3] = datosUni[4];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Seccion] = datosUni[5];
                NumeroLinea++;
            }
            int promedioa = promedio.promedios_generales_seccion(ArregloDosDimensiones, "A");
            listBoxGenS.Items.Add($"El Promedio de Seccion A= {promedioa}");
            int promediob = promedio.promedios_generales_seccion(ArregloDosDimensiones, "B");
            listBoxGenS.Items.Add($"El Promedio de Seccion B= {promediob}");
            int promedioc = promedio.promedios_generales_seccion(ArregloDosDimensiones, "C");
            listBoxGenS.Items.Add($"El Promedio de Seccion C= {promedioc}");
            int promediod = promedio.promedios_generales_seccion(ArregloDosDimensiones, "D");
            listBoxGenS.Items.Add($"El Promedio de Seccion D= {promediod}");
        }

        private void buttonMN_Click(object sender, EventArgs e)
        {
            Promedios notam = new Promedios();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Correlativo] = datosUni[0];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Nombre] = datosUni[1];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial1] = datosUni[2];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial2] = datosUni[3];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Parcial3] = datosUni[4];
                ArregloDosDimensiones[NumeroLinea, Clsenumcolumnas.Seccion] = datosUni[5];
                NumeroLinea++;
            }
            int mayor = notam.nombre_nota_mayor(ArregloDosDimensiones,ArregloNotas);
            listBoxMeN.Items.Add($"El Mejor promedio es {mayor}");
        }
    }
}




