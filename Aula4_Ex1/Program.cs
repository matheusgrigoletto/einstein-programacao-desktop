using System;

namespace Aula3_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto;
            int qtdEstoque;
            double valorCompra;
            int vendidos;

            Console.WriteLine("Digite o tipo de produto:");
            nomeProduto = Console.ReadLine();

            Console.WriteLine("Quantidade em estoque:");
            qtdEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor de compra, em R$:");
            valorCompra = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de produtos vendidos:");
            vendidos = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, valorCompra);

            produto.Adicionar(qtdEstoque);

            produto.Remover(vendidos);

            Console.WriteLine(produto);
        }
    }
}
