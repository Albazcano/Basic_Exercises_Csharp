using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Escriba un día de la semana: ");
		
		string día;
		
		día = (Console.ReadLine());
			
			switch (día) {
				case "Lunes": Console.WriteLine("Hoy es Lunes"); break;
				case "Martes": Console.WriteLine("Hoy es Martes"); break;
				case "Miércoles": Console.WriteLine("Hoy es Miércoles"); break;
				case "Jueves": Console.WriteLine("Hoy es Jueves"); break;
				case "Viernes": Console.WriteLine("Hoy es Viernes"); break;
				case "Sábado":  Console.WriteLine("Es fin de semana"); break;
				case "Domingo":  Console.WriteLine("Es fin de semana"); break;
				default: Console.WriteLine("Eso no es un día de la semana");break;
						
			}	
        }
    }
}
