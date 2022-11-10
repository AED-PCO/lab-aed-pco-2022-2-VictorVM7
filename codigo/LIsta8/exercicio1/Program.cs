using System;

namespace exercicio1
{
    internal class Program
    {
<<<<<<< HEAD
		static void Main(string[] args){
=======
        //Imprime o vetor
        static void imprimeVetor(int[] vet, int pos) {
            Console.Write("Fila: ");
            for (int i = 0; i < pos; i++) {
                Console.Write(vet[i]);
            }
            Console.Write("\n");
        }
        // Main
        static void Main(string[] args) {
            int[] vet = new int[4];
            int[] vetor = new int[4];
            int pos = 0;
            
            while (pos >= 0) {
                Console.Beep();
                Console.WriteLine("Deseja inserir, retirar ou imprimir vetor\n[I] para inseri\n[R] para retirarz\n[V] para Imprimir vetor");
                string escolha = Console.ReadLine().ToLower();
>>>>>>> refs/remotes/origin/main

			15 -------- 25
            7 --------- x
            

		}
    }
}