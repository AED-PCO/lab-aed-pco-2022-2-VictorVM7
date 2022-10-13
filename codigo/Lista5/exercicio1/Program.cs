using System;

class program
{
    static void preencheVetor(int[] vetor)
    {
        Console.WriteLine("Des:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1, 10000);
            Console.Write($"\t{vetor[i]}");
        }
        Console.Write("\n");
    }

    static void ordenaVetor(int[] vetor, int s, int a, int c)
    {   
        for(int valor = vetor.Length - 1; valor >= 0; valor--)
        {
            s++;
            for (int i = 0; i < valor; i++)
            {
                s++;
                if (vetor[i] > vetor[i + 1])
                {
                    c++;
                    a += 3;
                    int aux = vetor[i + 1];
                    vetor[i + 1] = vetor[i];
                    vetor[i] = aux;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int soma = 0; int atri = 0; int comp = 0;
        int[] vetorD = new int[10];
        preencheVetor(vetorD);
        ordenaVetor(vetorD, soma, atri, comp);

        Console.WriteLine("Ord:");
        for(int i = 0; i < vetorD.Length; i++)
        {
            Console.Write($"\t{vetorD[i]}");
        }
    }
}

