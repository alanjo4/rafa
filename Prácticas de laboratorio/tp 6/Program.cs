using System;

namespace tp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangoDeVector = 0;
            int igualesAOcho = 0;
            double[] numeros = new double[rangoDeVector];
            bool esNumero = false;
            bool esMenorQueCero = false;
            do
            {
                Console.WriteLine("Ingrese la cantidad de números a evaluar");
                esNumero = int.TryParse(Console.ReadLine(), out rangoDeVector);

                if (rangoDeVector >= 0){
                    numeros = new double[rangoDeVector];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingrese un número positivo");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (!esNumero || rangoDeVector < 0);
            for (int i = 0; i < numeros.Length; i++)
            {
                bool esNumeroInterno = false;
                do
                {
                    Console.WriteLine($"Ingrese el número {i + 1}");
                    esNumeroInterno = double.TryParse(Console.ReadLine(), out numeros[i]);
                    if (numeros[i] < 0)
                    {
                        esMenorQueCero = true;
                        break;
                    }
                    else
                    {
                        if (esNumeroInterno)
                        {
                            if (numeros[i] == 8)
                            {
                                igualesAOcho++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inserte un número");
                        }
                    }
                } while (!esNumeroInterno);

                if (esMenorQueCero)
                {
                    break;
                }
            }

            Console.WriteLine($"Hay {igualesAOcho} números iguales a ocho");
            Console.ReadKey();
        }
    }
}
