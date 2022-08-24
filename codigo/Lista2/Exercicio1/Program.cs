using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string [] args)
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", numero, calculaFatorial(numero));
        }

        static int calculaFatorial(int num)
        {
            if(num == 2)
                return 2;
            else
                return num * calculaFatorial(num - 1);
        }
    }
}
        