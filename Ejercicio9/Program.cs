using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             9-	Cree un programa de consola que solicite al usuario un número entre el 1 y el 12, el programa debe mostrar por pantalla el nombre del mes que corresponda al número ingresado. Si el número ingresado no está entre 1 y 12 debe mostrar por pantalla error al ingresar el número.
             */

                Console.WriteLine("Ingrese un número entre el 1 y el 12: ");
                int Num = int.Parse(Console.ReadLine());

                if (Num >= 1 && Num <= 12)
                {
                    switch (Num)
                    {
                        case 1:
                            Console.WriteLine("Enero");
                            break;
                        case 2:
                            Console.WriteLine("Febrero");
                            break;
                        case 3:
                            Console.WriteLine("Marzo");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Mayo");
                            break;
                        case 6:
                            Console.WriteLine("Junio");
                            break;
                        case 7:
                            Console.WriteLine("Julio");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Septiembre");
                            break;
                        case 10:
                            Console.WriteLine("Octubre");
                            break;
                        case 11:
                            Console.WriteLine("Noviembre");
                            break;
                        case 12:
                            Console.WriteLine("Diciembre");
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
