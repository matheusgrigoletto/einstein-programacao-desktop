using System;

namespace Aula2_Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            double custoConsumidor;
            double custoFabrica;
            const double TAXA_DISTRIBUIDOR = 28;
            const double TAXA_IMPOSTO = 45;

            Console.WriteLine("Informe o custo de fábrica do carro, em R$:");
            custoFabrica = double.Parse(Console.ReadLine());

            custoConsumidor = custoFabrica + (custoFabrica * (TAXA_IMPOSTO / 100));
            custoConsumidor += (custoConsumidor * (TAXA_DISTRIBUIDOR / 100));

            Console.WriteLine("O custo ao consumidor é R${0:F2}", custoConsumidor);
        }
    }
}
