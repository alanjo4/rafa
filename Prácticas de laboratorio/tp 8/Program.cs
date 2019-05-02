using System;

namespace tp_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeNumeros = 0;
            int contadorNegativo = 0;
            double[] vectorNumeros = new double[cantidadDeNumeros];
            double suma = 0.0;
            double promedio = 0.0;

            Console.WriteLine("Cantidad de números a ingresar");
            cantidadDeNumeros = int.Parse(Console.ReadLine());
            vectorNumeros = new double[cantidadDeNumeros];

            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                Console.WriteLine($"Ingrese número {i + 1}");
                vectorNumeros[i] = double.Parse(Console.ReadLine());

                if ((vectorNumeros[i] < 0) && (vectorNumeros[i] % 2 == 0))
                {
                    contadorNegativo++;
                    suma += vectorNumeros[i];
                    if (i + 1 == vectorNumeros.Length)
                    {
                        promedio = suma;
                        promedio /= contadorNegativo;
                    }
                }
            }

            Console.WriteLine($"El promedio de los números negativos es {promedio}");
            Console.ReadKey();
        }
    }
}
