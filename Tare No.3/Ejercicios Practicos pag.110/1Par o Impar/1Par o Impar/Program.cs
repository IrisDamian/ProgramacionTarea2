using System;

namespace _1Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Escriba el numero que desee");
            numero = int.Parse(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
        }
    }
}
