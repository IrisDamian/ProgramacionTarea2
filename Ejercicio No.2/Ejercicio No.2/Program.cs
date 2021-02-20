using System;

namespace Ejercicio_No._2
{
    class Program
    {
         static void Main(string[] args)
        {
            double cant;
            double grantot;
            const double des = 0.20;

            Console.WriteLine("Escriba su cantidad de Compra  \t");
            cant = Convert.ToDouble(Console.ReadLine());

            if (cant >= 300)
            {grantot = (cant * des);
                Console.Write("Gran total de su compra \t" + (cant - grantot));
            }
            else
                Console.Write("Total de su compra \t" + (cant));
            Console.ReadKey();


        }
    }
}
