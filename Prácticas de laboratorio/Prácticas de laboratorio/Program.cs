using System;

namespace Prácticas_de_laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double promedio = 0.0;
            int coleccionDeNumeros = 0;
            double[] numeros = new double[coleccionDeNumeros];
            bool esNumero = false;

            do
            {
                Console.WriteLine("Cuántos números necesita?");
                esNumero = int.TryParse(Console.ReadLine(), out coleccionDeNumeros);
                numeros = new double[coleccionDeNumeros];


                if (esNumero)
                {
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        bool esNumeroInterno = false;

                        do {
                            Console.WriteLine($"Ingrese número {i + 1}");
                            esNumeroInterno = double.TryParse(Console.ReadLine(), out numeros[i]);

                            if(esNumeroInterno)
                            {
                                promedio += numeros[i];
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número por favor");
                            }

                        } while (!esNumeroInterno);             

                        if (numeros.Length == i + 1)
                        {
                            promedio /= numeros.Length;

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Escriba un número");
                }
            } while (!esNumero);
            Console.WriteLine($"El promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
