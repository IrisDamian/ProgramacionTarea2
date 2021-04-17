using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Clase
{
    class Promedios : Interfacepromedios
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public string[,] nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }

        public int nombre_nota_mayor(string[,] matriz, string[]arreglo)
        {
            int acumulador = 0;
            int suma1 = 0;
            int Promedio = 0;
            int mayor = 0;
            int almacenar = 0;
            int[] promediomayor = new int[arreglo.Length];
            int TotalFilas = matriz.GetLength(0);
            int filasSeccion = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int j = 1; j < TotalFilas; j++)
            {
                
                    suma1 = Convert.ToInt32(matriz[j, 2]) + Convert.ToInt32(matriz[j, 3]) + Convert.ToInt32(matriz[j, 4]);
                    Promedio = suma1/3 ;
                if (acumulador != 0)
                {
                    promediomayor[acumulador] = Promedio;
                    if (promediomayor[acumulador]>almacenar)
                    {
                        mayor = promediomayor[acumulador]; 
                        almacenar = promediomayor[acumulador];
                    }
                }

                    acumulador++;
            }
            return mayor;
        }

       

        public int promedios_generales_seccion(string[,] matriz, string seccion)
        {
            int acumulador = 0;
            int suma1 = 0;
            int suma2 = 0;
            int promedio;
            int TotalFilas = matriz.GetLength(0);
            int filasSeccion = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int j = 1; j < TotalFilas; j++)
            {
                if (matriz[j, Clsenumcolumnas.Seccion] == seccion)
                {
                    suma1 = Convert.ToInt32(matriz[j, 2]) + Convert.ToInt32(matriz[j, 3]) + Convert.ToInt32(matriz[j, 4]);
                    suma2 = suma1 + suma2;
                    acumulador++;

                }


            }
            promedio = suma2 / acumulador;
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columnaparcial)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columnaparcial]);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;

        }

        public int promedios_por_seccion(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_seccion(string[,] matriz, int columnaparcial, string seccion)
        {
            throw new NotImplementedException();
        }
    }
}


