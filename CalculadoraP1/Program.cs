using System;

namespace CalculadoraP1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numA;
            double numB;
            int op = -1;
            Calculadora calculadora;

            while (op != 0)
            {
                Console.WriteLine("Digite o primeiro número:");
                numA = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                numB = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação:");
                Console.WriteLine("1 - ADIÇÃO");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - MULTIPLICAÇÃO");
                Console.WriteLine("4 - DIVISÃO");
                Console.WriteLine("---------------------");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                calculadora = new Calculadora(numA, numB);

                Console.WriteLine("************************");

                switch (op)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2:F2}", numA, numB, calculadora.Somar());
                        break;
                    case 2:
                        Console.WriteLine("{0} - {1} = {2:F2}", numA, numB, calculadora.Subtrair());
                        break;
                    case 3:
                        Console.WriteLine("{0} x {1} = {2:F2}", numA, numB, calculadora.Multiplicar());
                        break;
                    case 4:
                        if (numB != 0)
                        {
                            Console.WriteLine("{0} ÷ {1} = {2:F2}", numA, numB, calculadora.Dividir());
                        }
                        else
                        {
                            Console.WriteLine("Divisor não pode ser zero.");
                        }

                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }
                Console.WriteLine("************************");

                Console.WriteLine("============================\n\n");
            }
        }
    }
}
