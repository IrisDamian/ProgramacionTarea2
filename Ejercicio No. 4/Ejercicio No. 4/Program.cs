using System;

namespace Ejercicio_No._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Ene = 1;
            const int Febre = 2;
            const int Mar = 3;
            int daysInEne = System.DateTime.DaysInMonth(2002, Ene);
            Console.WriteLine(daysInEne);

            int daysInFebre = System.DateTime.DaysInMonth(2012, Febre);
            Console.WriteLine(daysInFebre);

            int daysInMarLeap = System.DateTime.DaysInMonth(2020, Mar);
            Console.WriteLine(daysInMarLeap);

        }
    }
}
