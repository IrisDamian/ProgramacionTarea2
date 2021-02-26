using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int numero1 = 0;
            int factorial = 1;
            string val = "";
            Console.WriteLine("Escriba un numero");
            val = Console.ReadLine();
            numero1 = Convert.ToInt32(val);
            for (numero = numero1; numero >= 1; numero--)
                factorial *= numero;
            Console.WriteLine("Factorial de  {0} es {1}", numero1, factorial);

        }
    }
}
