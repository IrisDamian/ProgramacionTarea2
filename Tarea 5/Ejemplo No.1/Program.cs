using System;
using System.Threading;

namespace Ejemplo_No._1
{
    class Program
    {
        public static string FuncionNom(string parametro, int startindex, int length)
        {
            string respuesta = parametro.Substring(startindex, length);
            return respuesta;
        }
         
        static void Main(string[] args)
        {
            string Nombre;
            string resultado;
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;
            Console.Write("Escriba su respectivo nombre");
            Nombre = Console.ReadLine();
            Console.SetCursorPosition(4, 8);
            Console.Write(Nombre);
            C = Nombre.Length;
            D = 50;
            Nombre = Nombre.ToUpper();
            for (B = Nombre.Length; B >= 1; B--)
            {
                resultado = FuncionNom(Nombre, B - 1, 1);
                for (A = C; A <= D; A++)
                {
                    Console.SetCursorPosition(A, 8);
                    Console.Write(" " + resultado);
                    Thread.Sleep(15);
                }
                D --;
                C --;
            } 
        }
    }
}
