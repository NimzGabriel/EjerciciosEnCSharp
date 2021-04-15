using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3-	Cree un programa de consola que solicite una distancia en kilómetros para ser recorrida en 6 horas, el script debe calcular a qué velocidad se desplazará el vehículo en recorrer la distancia ingresada por el cliente, debe mostrar el resultado por pantalla.
             */

                int distancia;
                int velocidad;
                int tiempo = 6;


                Console.WriteLine("Ingrese la distancia: ");
                distancia = int.Parse(Console.ReadLine());

                velocidad = distancia / tiempo;

                Console.WriteLine($"La velocidad a la que se desplazará es {velocidad}Km/h");
            
                Console.ReadKey();
        }
    }
}
