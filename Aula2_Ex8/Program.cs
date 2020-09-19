using System;

namespace Aula2_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double cotacao;
            double dolares;
            double reais;

            Console.WriteLine("Cotação atual do dólar, em R$:");
            cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Total de doláres, em US$:");
            dolares = double.Parse(Console.ReadLine());

            reais = cotacao * dolares;

            Console.WriteLine("Em reais, você tem: R$ {0:F2}", reais);
        }
    }
}
