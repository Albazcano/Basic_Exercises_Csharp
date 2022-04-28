using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num1 = 200;
			int num2 = 200;

			string result = (num1 > num2) ?
					"num1 es mayor que num2" :
					num1 == num2 ?
							"num1 es igual a num2" :
							"num1 es menor que num2";

			if (num1 == 200)
			{
				num1 = 2;
				num2 = 3;
			}
			Console.WriteLine(result);
		}
    }
}
