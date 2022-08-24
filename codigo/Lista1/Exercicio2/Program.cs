using System;

namespace Exercicio2
{
    class Program
    {
        static bool funcaoPrimo(int num){
            for(int i = 2; i < num; i++){
                if(num % i == 0){
                    return false;
                }
            }
            return true;
        }

        static void numeroPerfeito(){
            for(int i = 1; i <= 1000; i++){
                int soma = 0;
                for(int y = 1; y < i; y++){
                    if(i % y == 0){
                        soma += y;
                    }
                }
                if(soma == i){
                    Console.WriteLine("O número {0} é perfeito!", i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Type a int: ");
            int numero = int.Parse(Console.ReadLine());
            
            if(funcaoPrimo(numero))
                Console.WriteLine("Número primo");
            else
                Console.WriteLine("Número não primo");

            numeroPerfeito();
        }
    }
}
