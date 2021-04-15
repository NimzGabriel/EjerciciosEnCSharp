using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             7-	Cree un programa de consola que solicite dos números al cliente, el programa debe verificar que número es mayor y menor luego mostrar por pantalla todos los números desde el menor hasta el mayor de los números ingresados por el cliente.
             */

                Console.WriteLine("A continuación debe ingresar 2 números.");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                if (n1 < n2)
                {
                    for (int n = n1; n <= n2; n++)
                    {
                        Console.WriteLine(n);
                    }
                }
                else
                {
                    Console.WriteLine("El primer número debe ser menor al segundo.");
                }
            
            Console.ReadKey();

        }
    }
}
