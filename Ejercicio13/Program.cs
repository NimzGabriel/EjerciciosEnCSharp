using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             13-	Mejore el ejercicio 5 con lo aprendido en el ejercicio 12.
             */

                ArrayList listaNotas = new ArrayList();

                Console.WriteLine("Cuantas notas quiere promediar? ");
                double notas = double.Parse(Console.ReadLine());


                for (int n = 1; n <= notas; n++)
                {
                    Console.WriteLine($"Ingrese la {n} nota: ");
                    double nota = int.Parse(Console.ReadLine());

                    while (nota < 1 || nota > 7)
                    {
                        Console.Write("La nota debe estar entre 1 y el 7, por favor ");
                        Console.WriteLine("ingrese una nota válida: ");
                        nota = double.Parse(Console.ReadLine());
                    }

                    listaNotas.Add(nota);
                }
                double result = 0;
                double sum = 0;
                for (int x = 0; x < listaNotas.Count; x++)
                {
                    var n_nota = listaNotas[x].ToString();
                    sum = sum + double.Parse(n_nota);

                    result = sum / notas;
                }

                Console.WriteLine($"El promedio es {result}");
            
                Console.ReadKey();
        }
    }
}
