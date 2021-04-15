using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             16-	Cree un programa de consola que solicite al cliente un número de minutos, el programa debe mostrar por pantalla a cuantas horas y minutos corresponden al número ingresado.
             */

                int minutos, horas = 0;

                Console.WriteLine("Ingrese un número: ");
                minutos = int.Parse(Console.ReadLine());

                horas = minutos / 60;

                Console.WriteLine("El número ingresado corresponde a: ");
                Console.WriteLine($"En Horas: {horas}");
                Console.WriteLine($"En Minutos: {minutos}");
            
                Console.ReadKey();
        }
    }
}
