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
            for(int i = 1000; i <= 9999; i++){
                string numero = i.ToString(); 
                char [] charNumero = new char [numero.Length];

                for (int y = 0; y < charNumero.Length; y++){
                    charNumero[y] = numero[y];
                }
                
                int n1 = int.Parse(charNumero[0].ToString() + int.Parse(charNumero[1].ToString()));
                int n2 = int.Parse(charNumero[2].ToString() + int.Parse(charNumero[3].ToString()));

                funcaoVerifica(int.Parse(numero), n1, n2);
            }
        }
    }
}
