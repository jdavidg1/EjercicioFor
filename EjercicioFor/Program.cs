using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definición de variables

            int n = 0; // control del ciclo
            int cantidad = 0; //Cantidad de alumnos
            float calif = 0.0f, suma = 0.0f, promedio = 0.0f;


            // Comienzo del programa e inicialización de variables por el usuario

            Console.WriteLine("Cual es la cantidad de alumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            //Comienzo de la lectura de datos

            for(n=1; n<=cantidad; n++)
            {
                Console.WriteLine("Dame la calificación del alumno: ");

                calif = Convert.ToSingle(Console.ReadLine());
                //llevamos a cabo la suma de las calificaciones

                suma += calif;
                

            }

            //Calcular el promedio

            promedio = suma / cantidad;

            Console.WriteLine($"El promedio es {promedio} de los {cantidad} alumnos");
            Console.ReadKey();

        }
    }
}
