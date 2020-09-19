using System;

namespace Aula2_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal;
            const double TOTAL_PARCELAS = 5;
            double valorPrestacao;

            Console.WriteLine("Digite o valor total da compra, em R$:");
            valorTotal = double.Parse(Console.ReadLine());

            valorPrestacao = valorTotal / TOTAL_PARCELAS;

            Console.WriteLine("A compra pode ser parcelada em {0}x de R$ {1:F2}", TOTAL_PARCELAS, valorPrestacao);
        }
    }
}
