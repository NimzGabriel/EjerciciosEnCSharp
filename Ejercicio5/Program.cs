using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             5-	Cree un programa de consola que solicite al cliente la cantidad de notas que quiere promediar. 
            
                Luego el programa debe solicitar dicha cantidad de notas para promediarlas. 

                Finalmente debe mostrar por pantalla el resultado del promedio e indicar si el alumno aprobó o reprobó la asignatura.
            */

                ArrayList listaNotas = new ArrayList();

                Console.WriteLine("Cuantas notas quiere promediar? ");
                double notas = int.Parse(Console.ReadLine());


                for (int n = 1; n <= notas; n++)
                {
                    Console.WriteLine($"Ingrese la {n} nota: ");
                    double nota = double.Parse(Console.ReadLine());
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
