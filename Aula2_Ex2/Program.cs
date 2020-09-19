using System;

namespace Aula2_Ex2
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

            // 1- soma
            result = numA + numB;

            Console.WriteLine("Soma: {0} + {1} = {2}", numA, numB, result);

            // 2- subtração
            result = numA - numB;

            Console.WriteLine("Subtração: {0} - {1} = {2}", numA, numB, result);

            // 3- multiplicação
            result = numA * numB;

            Console.WriteLine("Multiplicação: {0} x {1} = {2}", numA, numB, result);

            // 4- divisão
            if (numB == 0)
            {
                Console.WriteLine("Divisão: segundo número não pode ser zero.");
            }
            else
            {
                result = numA / numB;

                Console.WriteLine("Divisão: {0} ÷ {1} = {2}", numA, numB, result);
            }
        }
    }
}
