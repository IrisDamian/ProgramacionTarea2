using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaDatos.clases;

namespace TareaDatos
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        private object ofd;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 5;
            arreglo[1] = 15;
            arreglo[2] = 10;
            arreglo[3] = 20;
            arreglo[4] = 3;
            Clsarreglo ObjetoArreglo = new Clsarreglo(arreglo);
            int[] resultado = ObjetoArreglo.MetodoBurbuja();
            foreach (int r in resultado)
            {
                listBoxA.Items.Add(r);
            }
        }

        private void buttonCar_Click(object sender, EventArgs e)
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

        private void buttonN_Click(object sender, EventArgs e)
        {
            foreach (String linea in ArregloNotas)
            {
                string[] datosUni = linea.Split(';');
                listBoxNom.Items.Add($"{datosUni[0]}{datosUni[1]}");
            }
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            double parcial1, parcial2, parcial3;
            double resultado;
            foreach (string res in ArregloNotas)
            {
                string[] promedio = res.Split(';');
                parcial1 = Convert.ToDouble(promedio[2]);
                parcial2 = Convert.ToDouble(promedio[3]);
                parcial3 = Convert.ToDouble(promedio[4]);
                resultado = (parcial1 + parcial2 + parcial3) / 3;
                listBoxPro.Items.Add($"{promedio[0]} {resultado}");

            }

        }

        private void buttonPG_Click(object sender, EventArgs e)
        {
            double parcial1, parcial2, parcial3;
            double resultado1 = 0, resultado2 = 0, resultado3 = 0;
            double p1 = 0, p2 = 0, p3 = 0;
            foreach (string res in ArregloNotas)
            {
                string[] promedio = res.Split(';');
                parcial1 = Convert.ToDouble(promedio[2]);
                parcial2 = Convert.ToDouble(promedio[3]);
                parcial3 = Convert.ToDouble(promedio[4]);
                resultado1 += parcial1;
                resultado2 += parcial2;
                resultado3 += parcial3;
            }
            p1 = resultado1 / 60;
            p2 = resultado2 / 60;
            p3 = resultado3 / 60;

            listBoxGeneral.Items.Add($"Promedio primer parcial = {p1}");
            listBoxGeneral.Items.Add($"Promedio segundo parcial = {p2}");
            listBoxGeneral.Items.Add($"Promedio tercer parcial = {p3}");
        }

        private void buttonNt_Click(object sender, EventArgs e)
        {
            int parcial1, parcial2, parcial3;
            int mayor, menor;
            int resultado;
            foreach (string res in ArregloNotas)
            {
                string[] promedio = res.Split(';');
                parcial1 = Convert.ToInt32(promedio[2]);
                parcial2 = Convert.ToInt32(promedio[3]);
                parcial3 = Convert.ToInt32(promedio[4]);
                resultado = (parcial1 + parcial2 + parcial3) / 3;
                if (resultado > 21)
                {
                    mayor = resultado;
                    listBoxNota.Items.Add($"{promedio[0]}{promedio[1]}{mayor}");
                }
                if (resultado < 3)
                {
                    menor = resultado;
                    listBoxNota.Items.Add($"{promedio[0]}{promedio[1]}{menor}");
                }
            }
        }
    }
}
                   
