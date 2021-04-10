using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDatos.clases
{
    class Clsarreglo
    {
        private int[] arreglotemporal;
        private int[] datos;
        private int i, j, datotemporal;
        private int tamanoarreglo = 0;

        public int GettamanoArreglo()
        {
            return datos.Length;
        }
        public Clsarreglo(int[] arregloParametro)
        {
            datos = arregloParametro;
            tamanoarreglo = datos.Length;
        }
        public int[] MetodoBurbuja()
        {
            arreglotemporal = datos;
            for (i = 0; i < tamanoarreglo-1; i++)
            {
                for (j=i+1; j < tamanoarreglo; j++)
                {
                    if (arreglotemporal[i] < arreglotemporal[j])
                    {
                        datotemporal = arreglotemporal[i];
                        arreglotemporal[i] = arreglotemporal[j];
                        arreglotemporal[j] = datotemporal;
                    }
                }
            }
            return arreglotemporal;
        }

    }
}
