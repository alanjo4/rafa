using System;

namespace tp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeNumeros = 0;
            int contador = 0;
            double[] vectorNumeros = new double[cantidadDeNumeros];
            double suma = 0.0;
            double promedio = 0.0;

            Console.WriteLine("Cantidad de números a ingresar");
            cantidadDeNumeros = int.Parse(Console.ReadLine());
            vectorNumeros = new double[cantidadDeNumeros];

            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                Console.WriteLine($"Ingrese número {i+1}");
                vectorNumeros[i] = double.Parse(Console.ReadLine());

                if (i + 1 != vectorNumeros[i])
                {
                    contador++;
                    suma += vectorNumeros[i];
                    if (vectorNumeros.Length == i + 1)
                    {
                        promedio = suma;
                        promedio /= contador;
                    }
                }
            }

            Console.WriteLine($"La suma es {suma} y el promedio es {promedio}");
            Console.ReadKey();
        }
    }
}
