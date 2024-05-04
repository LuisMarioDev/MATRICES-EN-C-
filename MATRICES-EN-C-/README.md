# Cursillo-de-C-MATRICES
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
            //Array, tipo [] nombre;

            double[] calificaciones = new double[4] {10, 9.5, 8.4 ,7.6};

            int[] numeros;

            numeros = new int[] { 5, 3, 1 };

            calificaciones[2] = 7.4;

            Console.WriteLine(calificaciones[2]);

            double caliFinal;

            caliFinal = calificaciones[2]-1;

            Console.WriteLine(caliFinal);


            string [] nombres = new string[3];

            nombres[0] = "Sandra";
            nombres[1] = "Pedro";
            nombres[2] = "Carmen";

            byte i;

            for (i = 0; i<=2; i++)
            {
                Console.WriteLine("Ingresa el valor para el indice {0}: ", i);
                nombres[i] = Console.ReadLine();
            }
            for (i = 0; i <=2; i++)
            {
                Console.WriteLine(nombres[i]);
            }






        }
    }
}
