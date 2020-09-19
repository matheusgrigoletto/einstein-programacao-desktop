using System;

namespace Aula2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA;
            double numB;
            double temp;

            Console.WriteLine("Digite o primeiro número:");
            numA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numB = double.Parse(Console.ReadLine());

            temp = numA;
            numA = numB;
            numB = temp;

            Console.WriteLine("Primeiro número: {0}\nSegundo número: {1}", numA, numB);
        }
    }
}
