using System;
namespace CalculadoraP1
{
    public class Calculadora
    {
        public Calculadora(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Num1 { get; set; }

        public double Num2 { get; set; }

        public double Somar()
        {
            return Num1 + Num2;
        }

        public double Subtrair()
        {
            return Num1 - Num2;
        }

        public double Multiplicar()
        {
            return Num1 * Num2;
        }

        public double Dividir()
        {
            if (Num2 != 0)
            {
                return Num1 / Num2;
            }
            return 0;
        }
    }
}
