using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Clase
{
    interface Interfacepromedios
    {
        /// <summary>
        /// retorno el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columnaparcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columnaparcial);

        /// <summary>
        /// retorno el promedio de un parcial en especial y una seccion en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columnaparcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columnaparcial, string seccion);
        /// <summary>
        /// saca el promedio general de todos los alumnos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columnaparcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_generales_seccion(string[,] matriz, string seccion);
        /// <summary>
        /// retorna una matriz de 2 columnas en el nombre y la otra columna en la sumatoria del parcial del 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);
        /// <summary>
        /// buscar el mejor promedio general o por seccion 
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string[,] nombre_nota_mayor(string[,] matriz);
        int nombre_nota_mayor(string[,] matriz, string[]arreglo);
        
    }
}
