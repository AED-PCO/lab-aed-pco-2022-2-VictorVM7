using System;

namespace Exercicio3
{
    class Program
    {
        static void leVetor(int[] vetor)
        {
            Console.WriteLine("Preencha o vetor:");
            for(int i = 0; i < vetor.Length; i++){
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }

        static void imprimeVetor(int[] vetor)
        {
            for(int i = 0; i < vetor.Length; i++){
                Console.WriteLine(vetor[i]);
            }
            Console.Write("\n");
        }

        static void vetorComum (int [] A, int[] B, int[] C, int[] D)
        {
            for(int i = 0; i < A.Length; i++){
                for(int x = 0; x < A.Length; x++){
                    if (A[i] == B[x])
                        C[i] = A[i];
                    else{
                        D[i] = B[i];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int [] vetorA = new int [5];
            int [] vetorB = new int [5];
            int [] vetorC = new int [5];
            int [] vetorD = new int [5];
            leVetor(vetorA);
            leVetor(vetorB);
            vetorComum(vetorA, vetorB, vetorC, vetorD);
            imprimeVetor(vetorC);
            imprimeVetor(vetorD);
        }
    }
}
