using System;

namespace Aula3_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA;
            double numB;

            Console.WriteLine("Digite o primeiro número:");
            numA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numB = double.Parse(Console.ReadLine());

            if (numA > numB)
            {
                Console.WriteLine("O maior número é: {0}", numA);
            }
            else
            {
                Console.WriteLine("O maior número é: {0}", numB);
            }
        }
    }
}
