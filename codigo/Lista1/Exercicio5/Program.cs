using System;

namespace Exercicio5
{
    class Program
    {
        static double calculaFatorial(double fatorial){
            double resultado = 1;
            for(int i = 2; i <= fatorial; i++){
                resultado *= i;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double fatorial = double.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de {0} é {1}", fatorial, calculaFatorial(fatorial));
        }
    }
}
