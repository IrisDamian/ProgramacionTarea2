using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, e, o, numero;
            Console.WriteLine("Escriba cualquier numero");
            numero = int.Parse(Console.ReadLine());
            a = 0;
            e = 1;
            for (int i = 0; i < numero; i++)
            {
                o = a;
                a = e;
                e = o + a;
                Console.Write(" {0} ", a);
            }
            Console.ReadKey();

        }
    }
}
