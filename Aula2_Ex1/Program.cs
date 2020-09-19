using System;

namespace Aula2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA;
            double numB;
            double result;

            Console.WriteLine("Digite o primeiro número:");
            numA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numB = double.Parse(Console.ReadLine());

            result = numA + numB;

            Console.WriteLine("A soma de {0} e {1} é {2}", numA, numB, result);
        }
    }
}

