using System;

namespace _4_Numeros_Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            for (int o = 1; o <= 1000; o++)
            {
                for (int a = 1; a <= o; a++)
                {
                    if (o % a == 0)
                    {
                        numero = numero + 1;
                    }
                }
                if (numero <= 2)
                {
                    Console.WriteLine(o);
                }
                numero = 0;
            }
            Console.ReadKey();

        }
    }
}
