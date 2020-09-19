using System;

namespace Aula3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;
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
            }

            Console.WriteLine("O maior número foi: {0}", maior);
            Console.WriteLine("O menor número foi: {0}", menor);
        }
    }
}
