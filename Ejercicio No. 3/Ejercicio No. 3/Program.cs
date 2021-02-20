using System;

namespace Ejercicio_No._3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int hrs, hrsextra;
            double tot1, tot2, sal;
            Console.WriteLine("Ingrese las horas trabajadas");
            hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Horas Extras Trabajadas");
            hrsextra = int.Parse(Console.ReadLine());
            tot1 = (hrs - hrsextra) * (16);
            tot2 = hrsextra * 20;
            sal = tot1 + tot2;
            if (hrs <= 40)
            {
                Console.Write("Su salario es \t" + tot1);
            }
            else if (hrs > 40)
            {
                Console.Write("Su gran salario es \t" + sal);
            }
            Console.ReadKey();
        }
    }
}
