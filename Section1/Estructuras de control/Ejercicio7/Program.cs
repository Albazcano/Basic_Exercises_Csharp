using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Escriba un password numérico: ");

			int password;

			do
			{
				password = Int32.Parse(Console.ReadLine());
				if (password == 1111)
				{
					Console.WriteLine("Contraseña correcta!!!");
					break;
				}
			} while (password != 1111);
		}
    }
}
