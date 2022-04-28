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
            //Intro
            Console.WriteLine("Programa convertidor de millas a metros ");
            Console.WriteLine("Escriba la cantidad de metros que le gustaria convetir: ");

            //Declare variables
            double metros;
            double millas;

            //Get info
            metros = double.Parse(Console.ReadLine());
            //Convert
            millas = metros / 1609.344;

            //Print results
            Console.WriteLine(millas + " millas");
        }
    }
}
