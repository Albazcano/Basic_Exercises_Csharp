using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato1 = 2;
            string dato2 = "hello";
            float dato3 = 2.3f;

            if (dato1 is ValueType)
            {
                Console.WriteLine("dato1 es ValueType");
            }
            else if (dato1 is int)
            {
                Console.WriteLine("dato1 es int");
            }
            else
            {
                Console.WriteLine("Ninguno");
            }

            if (dato2 is float)
            {
                Console.WriteLine("dato2 es float");
            }
            else if (dato2 is long)
            {
                Console.WriteLine("dato2 es long");
            }
            else
            {
                Console.WriteLine("Ninguno");
            }
        }
    }
}
