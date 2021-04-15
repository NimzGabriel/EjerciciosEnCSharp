using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4-	Mejore el script del ejercicio 3 para satisfacer las siguientes necesidades: si la velocidad es superior a 100 km/h debe mostrar por pantalla que el vehículo se desplazará a gran velocidad, en caso contrario debe mostrar por pantalla que el vehículo se desplazara a una velocidad moderada.
             */

                int velocidad;
                int distancia;
                int tiempo = 6;


                Console.WriteLine("Ingrese la distancia: ");
                distancia = int.Parse(Console.ReadLine());

                velocidad = distancia / tiempo;

                if (velocidad > 100)
                {
                    Console.WriteLine("El vehículo se desplazará a gran velocidad.");
                }
                else
                {
                    Console.WriteLine("el vehículo se desplazara a una velocidad moderada");
                }
            
                Console.ReadKey();
        }
    }
}
