using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    internal class Program
    {
		//Apartado A
		public static void Main()
		{
			//Usando ciclo for

			for (int i = 0; i <= 9; i += 2)
			{
				Console.WriteLine(i);
			}

			//Usando el ciclo while 
			int a = 0;

			while (a <= 9)
			{
				Console.WriteLine(a);
				a += 2;
			}

			//Usando el ciclo do while 

			int b = 0;

			do
			{
				Console.WriteLine(b);
				b += 2;
			} while (b <= 9);
		}

		//Apartado B
		public static void Main()
		{
			//Usando ciclo for

			for (int i = 0; i <= 5; i += 2)
			{
				Console.WriteLine(i);
			}
		}

		//Apartado C
		public static void Main()
		{
			//Usando el ciclo while 
			int a = 1;

			while (a <= 9)
			{
				Console.WriteLine(a);
				a += 2;
			}
		}
	}
}
