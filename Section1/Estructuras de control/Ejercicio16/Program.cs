using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número:");

            int num;

            num = Int32.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 1; i < num; i++)
            {
                //resultado += i;
                Console.WriteLine("resultado parcial: " + resultado);
                resultado = resultado + i;
            }
            Console.WriteLine("resultado final: " + resultado);

            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
            }


            Console.WriteLine(Math.Pow(num, 2));
            Console.WriteLine(Math.Pow(num, 3));
        }
    }
}
