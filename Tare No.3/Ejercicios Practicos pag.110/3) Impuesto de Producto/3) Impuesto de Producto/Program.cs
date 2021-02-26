using System;

namespace _3__Impuesto_de_Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0.0f;
            double respuesta = 0.0f;
            string valor = "";
            int opcion = 0;
            Console.WriteLine(" 1.Electrodomesticos");
            Console.WriteLine(" 2.Utiles");
            Console.WriteLine(" 3.Medicina");
            Console.WriteLine("Escriba cualquier opcion para que pueda conocer su impuesto");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Escriba el costo de su  producto");
            valor = Console.ReadLine();
            numero1 = Convert.ToSingle(valor);
            switch (opcion)
            {
                case 1:
                    respuesta = numero1 * 0.12;
                    break;
                case 2:
                    respuesta = numero1 * 0.12;
                    break;
                case 3:
                    respuesta = numero1 * 0;
                    break;
            }
            Console.WriteLine("Su impuesto total es de {0}", respuesta);
            Console.ReadKey();
        }
    }
}
