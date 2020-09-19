using System;

namespace Aula2_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedorNome;
            double vendedorSalario;
            double totalVendas;
            double totalSalario;
            const double COMISSAO = 15;

            Console.WriteLine("Nome do vendedor:");
            vendedorNome = Console.ReadLine();

            Console.WriteLine("Salário fixo, em R$:");
            vendedorSalario = double.Parse(Console.ReadLine());

            Console.WriteLine("Total de vendas realizadas no mês, em R$:");
            totalVendas = double.Parse(Console.ReadLine());

            totalSalario = (totalVendas * (COMISSAO / 100)) + vendedorSalario;

            Console.WriteLine("Vendedor: {0}", vendedorNome);
            Console.WriteLine("Salário fixo: R$ {0}", vendedorSalario);
            Console.WriteLine("Salário final: R$ {0}", totalSalario);
        }
    }
}
