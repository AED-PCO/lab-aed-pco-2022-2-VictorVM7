using System;

namespace exercicio1
{
    internal class Program
    {
        //Imprime o vetor
        static void imprimeVetor(int[] vet, int pos)
        {
            Console.Write("Fila: ");
            for (int i = 0; i < pos; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.Write("\n");
        }
        // Main
        static void Main(string[] args)
        {
            int[] vet = new int[4];
            int[] vetor = new int[vet.Length];
            int pos = 0, numInv = 0;
            int [] vetorInv = new int[vetor.Length];

            while (pos >= 0)
            {
                /*Console.Beep(800, 200);*/
                Console.WriteLine("Deseja inserir, retirar ou imprimir vetor\n[I] para inseri\n[R] para retirarz\n[V] para Imprimir vetor");
                string escolha = Console.ReadLine().ToLower();

                if (escolha.Equals("s"))
                    break;

                else if (escolha.Equals("i") && pos < vetor.Length)
                {
                    vetor = insere(vet, pos);
                    pos++;
                }
                else if (escolha.Equals("r") && pos != 0)
                {
                    numInv = retira(vetor, pos, numInv);
                    insereVerso(vetorInv, pos, numInv);
                    Console.WriteLine("Número na primeira posição retirado!");
                    pos--;
                }
                else if (escolha.Equals("v"))
                {
                    if (pos != 0)
                    {
                        imprimeVetor(vetor, pos);                        
                    }
                    if (vetorInv[vetor.Length - 1] != 0)
                    {
                        imprimeVetor(vetorInv, vetor.Length);
                    }
                    else
                        Console.WriteLine("Vetor vazio!");
                }
                else if (pos >= vetor.Length)
                {
                    Console.WriteLine("Seu vetor já está cheio! Você pode retirar ou imprimir!");
                }
                else if (pos == 0)
                {
                    Console.WriteLine("Seu vetor está vazio! Você pode inserir ou imprimir!");
                }
                else
                {
                    Console.WriteLine("Escolha não aplicada.");
                    break;
                }
            }
        }

        // Insere valores na fila
        static int[] insere(int[] vetor, int pos)
        {
            Console.Write($"Preencha a fila na posição {pos + 1}: ");
            vetor[pos] = int.Parse(Console.ReadLine());
            return vetor;
        }

        // Insere ao contrário
        static int[] insereVerso(int [] vetorInv, int pos, int numInv)
        {
            vetorInv[pos -1] = numInv;
            return vetorInv;
        }

        // Retira valores da fila
        static int retira(int[] vet, int pos, int num)
        {
            num = vet[0];
            for (int i = 0; i < pos - 1; i++)
            {
                vet[i] = vet[i + 1];
            }
            return num;
        }
    }
}