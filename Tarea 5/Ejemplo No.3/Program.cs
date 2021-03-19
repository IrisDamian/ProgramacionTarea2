using System;

namespace Ejemplo_No._3
{
    class Program
    {
        public static string Result(int min, int max)
        {
            Random R = new Random();
            int N = Convert.ToInt32(R.Next(200, 255));
            string RES = "";
            if (((N > min) & (N < max)))
            {
                RES = Convert.ToString((char)N);
            }
            return RES;
        }

        static void Main(string[] args)
        {
            byte C, V;

            string com;
            Console.WriteLine("Escriba cuantas combinaciones de valores desea");
            com = Console.ReadLine();
            C = byte.Parse(com);

            string L = "";
            for (V = 1; V <= C; V++)
            {


                {
                    L = L + Result(0, 255);
                }
                Console.WriteLine($"Combinaciones de codigo= {L}");
            }

        }
    }
}
