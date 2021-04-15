using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             8-	Cree un programa de consola que solicite al usuario un número entre el 1 y el 7, el programa debe mostrar por pantalla el nombre del día de la semana que corresponda al número ingresado. Si el número ingresado no está entre 1 y 7 debe mostrar por pantalla error al ingresar el número.
             */

                Console.WriteLine("Ingrese un número entre el 1 y el 7: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 7)
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Lunes");
                            break;
                        case 2:
                            Console.WriteLine("Martes");
                            break;
                        case 3:
                            Console.WriteLine("Miércoles");
                            break;
                        case 4:
                            Console.WriteLine("Jueves");
                            break;
                        case 5:
                            Console.WriteLine("Viernes");
                            break;
                        case 6:
                            Console.WriteLine("Sábado");
                            break;
                        case 7:
                            Console.WriteLine("Domingo");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar el número");
                }

            Console.ReadKey();
        }
    }
}
