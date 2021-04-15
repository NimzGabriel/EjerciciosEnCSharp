using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1-	Cree un programa de consola que solicite una nota y muestre por pantalla si la nota es correcta o está fuera de rango. El rango correcto es de 1 a 7.
             */

            Console.WriteLine("Ingrese una nota: ");
            int nota = int.Parse(Console.ReadLine());
            if (nota >= 1 && nota <= 7)
            {
                Console.WriteLine("Nota Correcta!");
            }
            else
            {
                Console.WriteLine("Nota Fuera de Rango.");
            }


            Console.ReadKey();
        }
    }
}
