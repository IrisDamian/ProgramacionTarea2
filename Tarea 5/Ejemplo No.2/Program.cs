using System;
using System.Threading;

namespace Ejemplo_No._2
{
    class Program
    {
        public static void figura(int resul)
        {
            int A = 30;
            int B = 25;
            int C = 10;
            int D =  9;
            int E, F , G;
            for (G = 1; G <= resul; G++)
            {
                for (E = D; E <= B; E++)
                {
                    Console.SetCursorPosition(E, A); Console.Write("O");
                    Console.SetCursorPosition(E, C); Console.Write("I");
                }
                for (F = C; F <= A ; F++)
                {
                    Console.SetCursorPosition(D, F); Console.Write("$");
                    Console.SetCursorPosition(B, F); Console.Write("D");
                }
                C --;
                A --;
                D --;
                B--;
            }
        }

        static void Main(string[] args)
        {
            for (int cant = 5; cant < 8; cant++)
            {
                figura(cant);
                Thread.Sleep(15);
            }
        }
    }
}
