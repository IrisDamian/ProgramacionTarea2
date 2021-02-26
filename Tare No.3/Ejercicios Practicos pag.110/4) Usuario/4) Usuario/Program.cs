using System;

namespace _4__Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            int ndia;
            Console.WriteLine("Escriba un numero del 1 al 7");
            ndia = int.Parse(Console.ReadLine());
            switch (ndia)
            {
                case 1:
                    Console.WriteLine("El dia es Domingo");
                    break;
                case 2:
                    Console.WriteLine("El dia es Lunes");
                    break;
                case 3:
                    Console.WriteLine("El dia es Martes");
                    break;
                case 4:
                    Console.WriteLine("El dia esMiercoles");
                    break;
                case 5:
                    Console.WriteLine("El dia es Jueves");
                    break;
                case 6:
                    Console.WriteLine("El dia es Viernes");
                    break;
                case 7:
                    Console.WriteLine("El dia es Sabado");
                    break;

            }
            Console.ReadKey();

        }
    }
}
