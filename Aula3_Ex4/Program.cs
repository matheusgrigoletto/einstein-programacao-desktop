using System;

namespace Aula3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA;
            int numB;
            int op;

            Console.WriteLine("Digite o primeiro número:");
            numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação:");
            Console.WriteLine("1 - ADIÇÃO");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", numA, numB, numA + numB);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", numA, numB, numA - numB);
                    break;
                case 3:
                    Console.WriteLine("{0} x {1} = {2}", numA, numB, numA * numB);
                    break;
                case 4:
                    if (numB != 0)
                    {
                        Console.WriteLine("{0} ÷ {1} = {2}", numA, numB, numA / numB);
                    }
                    else
                    {
                        Console.WriteLine("Divisor não pode ser zero.");
                    }
                    
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }

        }
    }
}
