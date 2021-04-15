using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             6-	Cree un programa de consola que solicite un número al cliente y muestre por pantalla todos los números impares que hay desde el 1 hasta el número ingresado.
             */

                Console.WriteLine("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                for (int n = 1; n <= numero; n++)
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine(n);
                    }
                }
            
                Console.ReadKey();

        }
    }
}
