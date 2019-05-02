using System;

namespace tp5_for
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0.0;

            Console.WriteLine("Ingrese el valor");
            valor = double.Parse(Console.ReadLine());

            for (int i = 0; i <= valor; i= i+2)
            {
                if (i == valor)
                {
                    Console.WriteLine("es par");
                }
                
                if(i == valor - 1)
                {
                    Console.WriteLine("es impar");
                }
            }
        }
    }
}
