using System;

namespace Aula3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNasc;
            int anoAtual = 2020;

            Console.WriteLine("Digite o ano do seu nascimento:");
            anoNasc = int.Parse(Console.ReadLine());

            

            if (anoAtual - anoNasc >= 18)
            {
                Console.WriteLine("Entrada permitida!");
            }
            else
            {
                Console.WriteLine("Menor de idade não entra!");
            }
        }
    }
}
