using System;

namespace Ejercicio_No._1
{
	class Program
	{
		static void Main(string[] args)
		{
			string i;
			Console.WriteLine("Ingresar Letra");
			i = Console.ReadLine();
			if (i == "A" || i == "B" || i == "C" || i == "D" ||i == "E" ||
				i == "F" || i == "G" || i == "H" || i == "I" ||i == "J" ||
				i == "K" || i == "L" || i == "M" || i == "N" ||i == "Ñ" ||
				i == "O" || i == "P" || i == "Q" || i == "R" ||i == "S" ||
				i == "T" || i == "U" || i == "V" || i == "W" ||i == "X" ||
				i == "Y" || i == "Z")
			{
				Console.WriteLine("La letra es Mayuscula");
			}
			else
			{
				Console.WriteLine("La letra es Minuscula");
			}

		}

	}
}



	
	


