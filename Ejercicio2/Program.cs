using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             2-	Cree un programa de consola que solicite un número y muestre por pantalla si el número es par o impar, el 0 se considera par.
             */

            Console.WriteLine("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 || num == 0)
            {
                Console.WriteLine($"El número {num} es par.");
            }
            else
            {
                Console.WriteLine($"El número {num} es impar.");
            }

            Console.ReadKey();
        }
    }
}
