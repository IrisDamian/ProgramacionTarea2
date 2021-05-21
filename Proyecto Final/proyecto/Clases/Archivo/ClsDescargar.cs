using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace proyecto.Clases.Archivo
{
    class ClsDescargar
    {
        public void Descarga(DataTable dt)
        {
            int acumulador = 0;
            string tb = "numero;marca;modeo;color;anio;precio;\n";
            foreach (DataRow Datos in dt.Rows)
            {
                tb += ($"{Datos[0]};{Datos[1]};{Datos[2]};{Datos[3]};{Datos[4]};{Datos[5]};\n");
                acumulador++;
            }

            File.WriteAllText($@"C:\Users\alumno\Desktop\DatosProyecto\DescargaDatos{acumulador}.csv", tb);
        }
    }
}
