using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             11-	Mejore el ejercicio 10 agregando un número a la ecuación.
             */

                Console.WriteLine("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tercer número: ");
                int num3 = int.Parse(Console.ReadLine());

                if (num1 % 2 == 0 && num2 % 2 == 0 && num2 % 2 != 0)
                {
                    Console.WriteLine("Par, Par e Impar.");
                }
                else if (num1 % 2 == 0 && num2 % 2 == 0 && num3 % 2 == 0)
                {
                    Console.WriteLine("Par, Par y Par");
                }
                else if (num1 % 2 == 0 && num2 % 2 != 0 && num3 % 2 == 0)
                {
                    Console.WriteLine("Par, Impar y Par.");
                }
                else if (num1 % 2 != 0 && num2 % 2 == 0 && num3 % 2 == 0)
                {
                    Console.WriteLine("Impar, Par y Par.");
                }
                else if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0)
                {
                    Console.WriteLine("Impar, Impar e Impar.");
                }
                else if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 == 0)
                {
                    Console.WriteLine("Impar, Impar y Par.");
                }
            
                Console.ReadKey();

        }
    }
}
