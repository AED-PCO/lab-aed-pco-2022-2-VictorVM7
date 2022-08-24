using System;

namespace Exercicio6
{
    class Program
    {
        static double funcaoCalculaPotencia(double numero1, double numero2, ref double result){
            result = Math.Pow(numero1, numero2);
            return result;
        }
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double resultado = 0;
            Console.WriteLine("{0}**{1} = {2}", n1, n2, funcaoCalculaPotencia(n1, n2, ref resultado));
        }
    }
}
