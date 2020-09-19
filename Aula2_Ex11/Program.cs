using System;

namespace Aula2_Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoCusto;
            double precoVenda;
            double acrescimoPorcentual;

            Console.WriteLine("Preço de custo do produto, em R$:");
            precoCusto = double.Parse(Console.ReadLine());

            Console.WriteLine("Percentual para preço de venda, em %:");
            acrescimoPorcentual = double.Parse(Console.ReadLine());

            precoVenda = precoCusto + (precoCusto * (acrescimoPorcentual / 100));

            Console.WriteLine("Preço de venda: R${0:F2}", precoVenda);
        }
    }
}
