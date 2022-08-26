using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string [] args)
        {
            int numeroA = int.Parse(Console.ReadLine());
            int numeroB = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{1} = {2}", numeroA, numeroB, multiplica(numeroA, numeroB));
        }

        static int multiplica(int numA, int numB)
        {
            if(numB == 0)
            {
                numA = 0;
                return numA;
            }
                
            if(numB == 1)
                return numA;
            else
                return numA + multiplica(numA, numB - 1);
        }
    }
}
     
