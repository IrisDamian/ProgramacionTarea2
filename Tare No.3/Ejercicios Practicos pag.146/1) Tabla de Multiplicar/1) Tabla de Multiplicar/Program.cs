using System;

namespace _1__Tabla_de_Multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Escriba que tabla desea ver");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + "x" + i + "=" + (i * numero));
            }
            Console.ReadKey();

        }
    }
}
