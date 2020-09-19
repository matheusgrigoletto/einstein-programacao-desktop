using System;

namespace Aula2_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia;
            double combustivel;
            double consumoMedio;

            Console.WriteLine("Digite a distância total percorrida pelo automóvel, em Km:");
            distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de combustível gasto, em L:");
            combustivel = double.Parse(Console.ReadLine());

            consumoMedio = distancia / combustivel;

            Console.WriteLine("Consumo médio do automóvel: {0} Km/L", consumoMedio);
        }
    }
}
