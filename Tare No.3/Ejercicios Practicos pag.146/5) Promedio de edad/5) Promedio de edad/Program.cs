using System;

namespace _5__Promedio_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayor = 0, menor = 0, numero = 0;
            int suma = 0, promedio = 0;
            Console.WriteLine("Escriba el total de personas");
            int numero1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero1; i++)
            {
                Console.WriteLine("Escriba su respectiva edad");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                promedio = suma / numero1;
                if (i == 1)
                {
                    mayor = numero;
                    menor = numero;
                }
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
                numero = 0;
            }
            Console.WriteLine("La persona con mayor edad es {0}", mayor);
            Console.WriteLine("La persona con menor edad es {0}", menor);
            Console.WriteLine("El promedio de edad de personas  es {0}", promedio);
            Console.ReadKey();

        }
    }
}
