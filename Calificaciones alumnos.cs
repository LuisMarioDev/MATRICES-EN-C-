using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion6
{
    class Program
    {
        static void Main(string[] args) 
        {
            //variables
            byte i, numAlumnos;
            double sumacalif = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el numero de alumnos
            Console.Write("Ingrese el numero de alumnos: ");
            numAlumnos=Convert.ToByte(Console.ReadLine());

            //creación de la matriz
            double[] calificaciones = new double[numAlumnos];

            for (i = 0; i < numAlumnos; i++)
            {
                //pedimos calificacion
                Console.Write("Ingresa la calificación: ");
                calificaciones[i]=Convert.ToDouble(Console.ReadLine());

                //Acumulamos calificaciones
                sumacalif += calificaciones[i];

                //calculamos el promedio

                promedio = sumacalif / numAlumnos;

                //calculamos calificacion minima
                for(i = 0;i < numAlumnos; i++)
                {
                    if (calificaciones[i] < califMin)
                    {
                        califMin= calificaciones[i];
                    }
                }

                //Calcular calificacion maxima
                for(i = 0;i<numAlumnos; i++)
                {
                    if (calificaciones[i] > califMax)
                    {
                        califMin = calificaciones[i];
                    }
                }

                //Mostramos los resultados
                Console.WriteLine("El promedio es: {0}", califMin);
                Console.WriteLine("La calificacion minima es: {0}", califMin);
                Console.WriteLine("La calificacion maxima es: {0}", califMax);



            }

        }
    }
}