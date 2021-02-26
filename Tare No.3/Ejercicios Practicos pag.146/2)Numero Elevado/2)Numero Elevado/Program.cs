using System;

namespace _2_Numero_Elevado
{
    class Program
    {
        static int potencia(int bas, int exponente)
        {
            int val = 1;
            int i;
            for (i = 1; i <= exponente; i++)
                val *= bas;
            return val;
        }
        static void Main()
        {
            int numero1, numero2;
            Console.WriteLine("Escrina la respectiva base");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el respectivo exponente");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} con potencia de {1} es igual a {2}", numero1, numero2, potencia(numero1, numero2));
            Console.ReadKey();

        }
    }
}
