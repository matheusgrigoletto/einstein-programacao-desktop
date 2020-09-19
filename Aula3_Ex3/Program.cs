using System;

namespace Aula3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Digite o número:");
            n = int.Parse(Console.ReadLine());


            if (n <= 10)
            {
                Console.WriteLine("F1");
            }
            else if(n > 10 && n <= 100)
            {
                Console.WriteLine("F2");
            }
            else
            {
                Console.WriteLine("F3");
            }
        }
    }
}
