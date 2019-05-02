using System;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayor = 0.0;
            int coleccionDeNumeros = 0;
            double[] numeros = new double[coleccionDeNumeros];
            bool esNumero = false;
            string mediador = "";

            do
            {
                Console.WriteLine("Cuántos números necesita?");
                mediador = Console.ReadLine();
                mediador = mediador.Replace(" ", "");
                esNumero = int.TryParse(mediador, out coleccionDeNumeros);
                if (esNumero && coleccionDeNumeros > 0)
                {
                    numeros = new double[coleccionDeNumeros];

                
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        bool esNumeroInterno = false;
                        string mediadorInterno = "";

                        do
                        {
                            Console.WriteLine($"Ingrese número {i + 1}");
                            mediadorInterno = Console.ReadLine();
                            mediadorInterno = mediadorInterno.Replace(" ", "");
                            esNumeroInterno = double.TryParse(mediadorInterno, out numeros[i]);

                            if (esNumeroInterno)
                            {
                                if (numeros[i] > mayor)
                                {
                                    mayor = numeros[i];
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número por favor");
                            }

                        } while (!esNumeroInterno);

                        if (numeros.Length == i + 1)
                        {
                            Console.WriteLine($"El número más grande es {mayor}");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido");
                }
            } while (!esNumero || coleccionDeNumeros <= 0);
            Console.ReadKey();
        } 
    }
}

