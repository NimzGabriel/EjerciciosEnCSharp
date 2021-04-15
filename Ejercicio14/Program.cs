using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             14-	Cree un programa de consola que solicite al cliente un monto para solicitar un crédito y la cantidad de cuotas en las que quiere pagar dicho préstamo.

                El programa debe calcular cuánto será el total que deberá pagar el cliente y cuanto es el valor por cuota. Teniendo en cuenta que:
            -	Entre 1 y 12 cuotas el interés aplicado al monto es del 10%.
            -	Entre 13 y 30 cuotas el interés aplicado al monto es de 25%.
            -	Entre 31 y 40 cuotas el interés aplicado al monto es de 35%.
            -	Más de 40 cuotas el interés aplicado al monto es de un 50%.

             */

                // las declaro como decimal todas para no tener problemas despues.
                double monto, total, cuotas, interes, valor_cuotas;

                Console.WriteLine("Cual es el monto que desea solicitar? ");
                monto = double.Parse(Console.ReadLine());

                Console.WriteLine("En cuantas cuotas quiere pagarlo? ");
                cuotas = double.Parse(Console.ReadLine());

                if (cuotas >= 1 && cuotas <= 12)
                {
                    interes = 0.1;
                    total = monto + (monto * interes);
                    valor_cuotas = total / cuotas;
                    Console.WriteLine("Tendrá que pagar en total: " + total);
                    Console.WriteLine("Y el valor por cuotas es de: " + valor_cuotas);

                }
                else if (cuotas >= 13 && cuotas <= 30)
                {
                    interes = 0.25;
                    total = monto + (monto * interes);
                    valor_cuotas = total / cuotas;
                    Console.WriteLine("Tendrá que pagar en total: " + total);
                    Console.WriteLine("Y el valor por cuotas es de: " + valor_cuotas);
                }
                else if (cuotas >= 31 && cuotas <= 40)
                {
                    interes = 0.35;
                    total = monto + (monto * interes);
                    valor_cuotas = total / cuotas;
                    Console.WriteLine("Tendrá que pagar en total: " + total);
                    Console.WriteLine("Y el valor por cuotas es de: " + valor_cuotas);
                }
                else if (cuotas > 40)
                {
                    interes = 0.5;
                    total = monto + (monto * interes);
                    valor_cuotas = total / cuotas;
                    Console.WriteLine("Tendrá que pagar en total: " + total);
                    Console.WriteLine("Y el valor por cuotas es de: " + valor_cuotas);
                }
           
                Console.ReadKey();
        }
    }
}
