using System;

namespace tp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double dividendo = 0;
            double divisor = 0;
            double cociente = 0;

            Console.WriteLine("Ingrese dividendo");
            dividendo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese divisor");
            divisor = int.Parse(Console.ReadLine());

            for (cociente = 0; dividendo > 0; cociente++)
            {
                dividendo -= divisor;
            }

            Console.WriteLine($"El cociente es: {cociente}");
            Console.WriteLine($"El resto es: {- dividendo}");
            Console.ReadKey();
        }
    }
}
