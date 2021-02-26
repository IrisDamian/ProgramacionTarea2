using System;

namespace _2_Grados_a_Radiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 0.0f;
            double respuesta = 0.0f;
            string valor = "";
            int opcion = 0;
            Console.WriteLine(" 1.De Grados a Radianes");
            Console.WriteLine(" 2.De Radianes a grados");
            Console.WriteLine("Ingrese una opcion");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            Console.WriteLine("Escriba los grados");
            valor = Console.ReadLine();
            numero1 = Convert.ToSingle(valor);
            switch (opcion)
            {
                case 1:
                    respuesta  = numero1 * (Math.PI / 180);
                    break;
                case 2:
                    respuesta = numero1 * (180 / Math.PI);
                    break;
            }
            Console.WriteLine("Su respuesta es {0}", respuesta);
            Console.ReadKey();



        }
    }
}
