using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_basicos_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 33;
            int dato2 = 84;

            if (dato1 > dato2)
            {
                Console.WriteLine("dato1 is mayor que dato2");
            }

            if (dato1 < dato2)
            {
                Console.WriteLine("dato1 es menor que dato2");
            }

            if ((dato1 % 2) == 0)
            {
                Console.WriteLine("dato1 es par");
            }
            else
            {
                Console.WriteLine("dato1 es impar");
            }

            if ((dato2 % 2) == 0)
            {
                Console.WriteLine("dato2 es par");
            }
            else
            {
                Console.WriteLine("dato2 es impar");
            }

            if ((dato1 % dato1) == 0 && (dato1 % 1) == 0)
            {
                Console.WriteLine("dato1 es primo");
            }
            else
            {
                Console.WriteLine("dato1 no es primo");
            }

            if ((dato2 % dato2) == 0 && (dato2 % 1) == 0)
            {
                Console.WriteLine("dato2 es primo");
            }
            else
            {
                Console.WriteLine("dato2 no es primo");
            }

            if ((dato1 % dato2) == 0)
            {
                Console.WriteLine("Dato1 es divisible entre Dato2");
            }
            else
            {
                Console.WriteLine("Dato1 no es divisible entre Dato2");
            }

            if ((dato2 % dato1) == 0)
            {
                Console.WriteLine("Dato2 es divisible entre Dato1");
            }
            else
            {
                Console.WriteLine("Dato2 no es divisible entre Dato1");
            }
        }
    }
}
