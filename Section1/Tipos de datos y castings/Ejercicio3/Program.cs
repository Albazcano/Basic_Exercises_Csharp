using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num1 = 120;
			int num2 = 350;
			int num3 = 50;

			int suma = num1 + num2 + num3;
			Console.WriteLine(suma);

			int resta = num1 - num2 - num3;
			Console.WriteLine(resta);

			int multiplicacion = num1 * num2 * num3;
			Console.WriteLine(multiplicacion);

			int division = num1 / num2 / num3;
			Console.WriteLine(division);
		}
    }
}
