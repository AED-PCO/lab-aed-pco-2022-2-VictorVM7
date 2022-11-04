using System;

namespace Exercicio1
{
    class Program
    {
        static void funcaoVerifica(int valor, int numero1, int numero2){
            if(Math.Pow(numero1 + numero2, 2) == valor){
                Console.WriteLine("O número {0} tem a característica especial", valor);
            }
        }

        static void Main(string[] args)
        {
            int a = 0, s = 0, c = 0;
            for(int i = 1000; i <= 10000; i++){
                string numero = i.ToString(); 
                char [] charNumero = new char [numero.Length];
                a+=2;

                for (int y = 0; y < charNumero.Length; y++){
                    charNumero[y] = numero[y];
                    a++;
                }
                
                int n1 = int.Parse(charNumero[0].ToString() + int.Parse(charNumero[1].ToString()));
                int n2 = int.Parse(charNumero[2].ToString() + int.Parse(charNumero[3].ToString()));
                a+=2;
                s+=2;
                c++;
                funcaoVerifica(int.Parse(numero), n1, n2);
            }
            Console.WriteLine($"S = {s}, C = {c}, A = {a}");
        }
    }
}
