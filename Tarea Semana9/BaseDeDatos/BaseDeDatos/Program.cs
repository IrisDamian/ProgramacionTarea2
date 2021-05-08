﻿using BaseDeDatos.Clases.BaseDatos;
using System;
using System.Data;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsConexion cn = new ClsConexion();

            DataTable dt = cn.consultaTablaDirecta("SELECT *  FROM [tb_alumnos]");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Correlativo:{dr[0]} Nombre: {dr[1]} Parcial1: {dr[2]} Parcial2: {dr[3]} Parcial3: {dr[4]}" );
            }

            Console.WriteLine("¡Exelente!Lista finalizada");
        }
    }
}
