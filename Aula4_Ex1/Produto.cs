using System;
namespace Aula3_Ex1
{
    public class Produto
    {
        private const double TAXA_VALOR_VENDA = 20.0;

        public Produto(string nome, double valorCompra)
        {
            Nome = nome;
            Quantidade = 0;
            ValorCompra = valorCompra;
        }

        public string Nome { get; }

        public int Quantidade { get; set; }

        public double ValorCompra { get; set; }

        public void Adicionar(int total)
        {
            Quantidade += Math.Abs(total);
        }

        public void Remover(int total)
        {
            Quantidade -= Math.Abs(total);
        }

        public double ValorVenda()
        {
            return ValorCompra + (ValorCompra * (TAXA_VALOR_VENDA / 100));
        }

        public double ValorTotalVenda()
        {
            return this.ValorVenda() * Quantidade;
        }

        public override string ToString()
        {
            return "\n=============================================\n\n" +
                "Produto: " + Nome + "\n" +
                "Quantidade em estoque: " + Quantidade + ";\n" +
                "Valor de compra: R$ " + string.Format("{0:F2}", ValorCompra) + ";\n" +
                "Valor de venda: R$ " + string.Format("{0:F2}", this.ValorVenda()) + ";\n" +
                "Valor total em estoque: R$ " + string.Format("{0:F2}", this.ValorTotalVenda()) + ";\n" +
                "\n=============================================\n";
        }
    }
}
