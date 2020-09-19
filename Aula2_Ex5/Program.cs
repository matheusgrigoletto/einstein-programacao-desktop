using System;

namespace Aula2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.WriteLine("Nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Nota da primeira prova:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota da segunda prova:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota da terceira prova:");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("O aluno {0} teve média {1:F2}", nome, media);
        }
    }
}
