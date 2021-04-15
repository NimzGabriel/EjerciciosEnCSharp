using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             12-	Cree un programa de consola que solicite al usuario una nota entre el 1 y el 7. Si el número ingresado no está entre 1 y 7 el programa debe volver a solicitar la nota hasta que este entre el rango correcto, cuando así suceda el programa debe mostrar por pantalla la nota es válida.
             */

                int nott;
                Console.WriteLine("Ingrese una nota entre el 1 y el 7: ");
                nott = int.Parse(Console.ReadLine());

                while (nott < 1 || nott > 7)
                {
                    Console.Write("La nota no esta en el rango correcto, por favor ");
                    Console.WriteLine("Ingrese una nota entre el 1 y el 7: ");
                    nott = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("La Nota es Válida.");
            
                Console.ReadKey();

        }
    }
}
