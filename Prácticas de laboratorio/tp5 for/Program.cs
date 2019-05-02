using System;

namespace tp5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.0;
            bool esNumero = false;
            do
            {
                Console.WriteLine("Ingrese el valor");
                esNumero = double.TryParse(Console.ReadLine(), out valor);
                if(esNumero){
                    for (int i = 0; i <= valor; i = i + 2)
                    {
                        if (i == valor)
                        {
                            Console.WriteLine("es par");
                        }

                        if (i == valor - 1)
                        {
                            Console.WriteLine("es impar");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Introduzca un número");
                }
            } while (!esNumero);
        }
    }
}
