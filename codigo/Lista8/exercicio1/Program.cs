using System;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprime o vetor
            static void imprimeVetor(int[] vet, int pos)
            {
                Console.Write("Fila: ");
                for (int i = 0; i < pos; i++)
                {
                    Console.Write(vet[i]);
                }
                Console.Write("\n");
            }

            // Main
            static void Main(string[] args)
            {
                int[] vet = new int[4];
                int[] vetor = new int[4];
                int pos = 0;

                while (pos >= 0)
                {
                    Console.Beep();
                    Console.WriteLine("Deseja inserir, retirar ou imprimir vetor\n[I] para inseri\n[R] para retirarz\n[V] para Imprimir vetor");
                    string escolha = Console.ReadLine().ToLower();
                }
            }

            // Insere valores na pilha
            static int[] insere(int[] vetor, int pos)
            {
                Console.WriteLine($"Preencha a pilha na posição {pos + 1}: ");
                vetor[pos] = int.Parse(Console.ReadLine());
                return vetor;
            }

            // Retira valores da pilha
            static int[] retira(int[] vet, int pos)
            {
                string escolha;
                for (int i = pos; i > 0; i--)
                {
                    Console.WriteLine($"Retirar número na posição {pos}? [S] Sim e [N] Não");
                    escolha = Console.ReadLine().ToLower();
                    if (escolha.Equals('s'))
                    {
                        vet[i - 1] = vet[i];
                    }
                    else
                        break;
                }
                return vet;
            }
        }
    }
}