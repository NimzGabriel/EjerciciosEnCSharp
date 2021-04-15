using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             10-	Cree un programa de consola que solicite dos números al cliente, si el número primer número ingresado es par y el segundo número es impar el programa debe mostrar por pantalla par e impar, si ambos números son pares debe mostrar por pantalla par y para, si el primer número es impar y el segundo es par debe mostrar por pantalla impar y par.

             */

                Console.WriteLine("Ingrese el primer número: ");
                int nu1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                int nu2 = int.Parse(Console.ReadLine());

                if (nu1 % 2 == 0 && nu2 % 2 != 0)
                {
                    Console.WriteLine("Par e Impar.");
                }
                else if (nu1 % 2 == 0 && nu2 % 2 == 0)
                {
                    Console.WriteLine("Par y Par.");
                }
                else if (nu1 % 2 != 0 && nu2 % 2 == 0)
                {
                    Console.WriteLine("Impar y Par.");
                }
           
                Console.ReadKey();

        }
    }
}
