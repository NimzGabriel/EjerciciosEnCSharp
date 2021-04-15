using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             15-	Cree un programa de consola que solicite al cliente su nombre y edad además del nombre y la edad de otra persona, el programa debe mostrar por pantalla el nombre de la persona menor y mayor, además de la diferencia de edad entre ambos.
            */

                Console.WriteLine("Cual es su nombre?");
                string nombre1 = Console.ReadLine();
                Console.WriteLine("Cual es su edad?");
                int edad1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Cual es el nombre de su amigo/a ?");
                string nombre2 = Console.ReadLine();
                Console.WriteLine("Cual es la edad de su amigo/a ?");
                int edad2 = int.Parse(Console.ReadLine());

                int dif_edad;
                if (edad1 < edad2)
                {
                    dif_edad = edad2 - edad1;
                    Console.WriteLine(nombre1 + " menor.");
                    Console.WriteLine(nombre2 + " mayor.");
                    Console.WriteLine($"La diferencia de edad es de {dif_edad} años.");
                }
                else
                {
                    dif_edad = edad1 - edad2;
                    Console.WriteLine(nombre2 + " menor.");
                    Console.WriteLine(nombre1 + " mayor.");
                    Console.WriteLine($"La diferencia de edad es de {dif_edad} años.");
                }
            
                Console.ReadKey();
        }
    }
}
