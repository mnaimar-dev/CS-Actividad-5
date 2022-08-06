using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglo
{
    class Arreglo
    {
        int[] edades;
        public void recibe()
        {
            edades = new int[3];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.Write("Ingrese la edad: " + (i + 1) + ": ");
                edades[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Calculando el promedio… ");

            //INGRESA AQUÍ TU CÓDIGO
            Console.WriteLine();

            int suma = 0;
            int contador = 0;
            for (int i = 0; i < edades.Length; i++)
            {
                suma += edades[i];
                contador++;
            }

            int promedio = suma / contador;
            Console.WriteLine("El promedio es: " + promedio);
        }

        static void Main(string[] args)
        {
            Arreglo alumnos = new Arreglo();
            alumnos.recibe();
            Console.ReadKey();
        }
    }
}

