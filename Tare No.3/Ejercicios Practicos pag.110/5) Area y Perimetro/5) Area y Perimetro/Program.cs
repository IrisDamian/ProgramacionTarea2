using System;

namespace _5__Area_y_Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            double d;
            double perimetro;
            double area;
            double apotema;
            string val = "";
            int opc = 0;
            Console.WriteLine("1.Encontrar Perimetro");
            Console.WriteLine("2.Encontrar Area");
            Console.WriteLine("Escriba cualquier numero para calcular su poligono");
            val = Console.ReadLine();
            opc = Convert.ToInt32(val);
            Console.WriteLine("Escriba la medida de sus lados del poligono");
            val = Console.ReadLine();
            i = Convert.ToSingle(val);
            Console.WriteLine("Escriba cuantos lados tiene el poligono");
            val = Console.ReadLine();
            d = Convert.ToSingle(val);
            Console.WriteLine("Escriba su apotema del poligono");
            val = Console.ReadLine();
            apotema = Convert.ToSingle(val);
            perimetro = i * d;
            area = (perimetro * apotema) / 2;
            switch (opc)
            {
                case 1:
                    Console.WriteLine("Su medida de perimetro es {0}", perimetro);
                    break;
                case 2:
                    Console.WriteLine("Su medida de area es {0}", area);
                    break;
            }
            Console.ReadKey();

        }
    }
}
