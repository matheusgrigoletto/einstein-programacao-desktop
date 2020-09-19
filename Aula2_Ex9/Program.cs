using System;

namespace Aula2_Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito;
            double poupanca;
            const double RENDIMENTO = 0.70;

            Console.WriteLine("Digite o valor depositado, em R$:");
            deposito = double.Parse(Console.ReadLine());

            poupanca = deposito + (deposito * (RENDIMENTO / 100));

            Console.WriteLine("Total com rendimento: R$ {0:F2}", poupanca);
        }
    }
}
