using System;

namespace Aula3_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num != 0)
            {
                Console.WriteLine("Digite um número (0 para sair):");
                num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                Console.WriteLine("O dobro de {0} é {1}\n", num, num * 2);
            }
        }
    }
}
