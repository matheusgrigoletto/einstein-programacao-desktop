using System;

namespace Aula3_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos = 0;
            double joao = 1.45;
            double maria = 1.57;
            const double CRESCIMENTO_JOAO = 0.23;
            const double CRESCIMENTO_MARIA = 0.15;

            while (joao < maria)
            {
                joao += CRESCIMENTO_JOAO;
                maria += CRESCIMENTO_MARIA;
                anos++;
            }

            Console.WriteLine("Levará {0} anos para João ({1:F2}m) ser maior que Maria ({2:F2}m).", anos, joao, maria);
        }
    }
}
