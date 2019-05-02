using System;

namespace tp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int[] digitos = new int[4];
            int contadortotal = 3;
            int suma = 0;

            Console.WriteLine("Ingrese un número");
            numero = int.Parse(Console.ReadLine());

            while (numero > 0)
            {
                digitos[contadortotal--] = numero % 10;
                numero /= 10;
            }

            for (int i = 0; i <= 3; i++)
            {
                suma += digitos[i];
            }
            Console.WriteLine($"La suma es {suma}");
            Console.ReadKey();
        }
    }
}