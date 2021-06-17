using System;

namespace Exercicio6_MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("******Calculadora de MDC*******");

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            int mdcResult = MDC(numero1, numero2);

            Console.WriteLine("O Máximo Divisor Comum entre " + numero1 +" e "+ numero2+ " é " + mdcResult);
        }

        static int MDC(int x, int y)
        {
            int Resto;
            while (y != 0)
            {
                Resto = x % y;
                x = y;
                y = Resto;
            }
            return x;
        }
    }
}
