using System;

namespace Ejercicio_No._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, P;
            Console.WriteLine("Ingresar Numero");
            P = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (P + 1); i++)
            {
                if (P % i == 0)
                {
                    c++;
                }
            }
            if (c != 2)
            {
                Console.WriteLine("No es un numero primo");
            }
            else
            {
                Console.WriteLine("Es un numero primo");
            }
            Console.ReadLine();
        }
    }
}
