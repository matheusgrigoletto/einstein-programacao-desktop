using System;

namespace Aula3_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
            int totalNumeros = 0;
            int soma = 0;
            int num = 1;

            while (num != 0)
            {
                Console.WriteLine("Digite um número (0 para sair):");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                if (num < menor)
                {
                    menor = num;
                }

                if (num > maior)
                {
                    maior = num;
                }

                totalNumeros++;

                soma += num;
            }

            Console.WriteLine("Soma de todos os números: {0}", soma);
            Console.WriteLine("Quantidade de números digitados: {0}", totalNumeros);
            Console.WriteLine("Média: {0:F2}", soma / totalNumeros);
            Console.WriteLine("Maior número: {0}", maior);
            Console.WriteLine("Menor número: {0}", menor);
        }
    }
}
