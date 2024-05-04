namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int i; // Variable de control de ciclo exterior
            int j;//Variable de control de ciclo interior


            //tipo[,] nombre=new tipo [filas,columnas]
            double[,] ventas = new double[4, 3] { { 100, 120, 205 }, { 115, 196, 200 }, { 157, 172, 245 }, { 130, 180, 281 } };

            //Declaracion e instancia de matriz de 3 dimensiones
            int[,,] matriz3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            Console.WriteLine(ventas[3, 2]);

            for(i=0; i<4; i++)
            {
                Console.WriteLine("Fila {0}", i);
                for(j=0; j<3; j++)
                {
                    Console.WriteLine(ventas[i,j]);
                }
            }



        }
    }
}