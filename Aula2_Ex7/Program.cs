using System;

namespace Aula2_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausC;
            double grausF;

            Console.WriteLine("Digite a temperatura em graus celsius:");
            grausC = double.Parse(Console.ReadLine());

            grausF = (9 * grausC + 160) / 5;

            Console.WriteLine("{0}°C é equivalente a {1}°F", grausC, grausF);
        }
    }
}
