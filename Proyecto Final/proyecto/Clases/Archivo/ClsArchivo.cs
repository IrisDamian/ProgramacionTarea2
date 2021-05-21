using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace proyecto.Clases.Archivo
{
    class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo, Encoding.Default);
            return Lineas;
        }
    }
}
