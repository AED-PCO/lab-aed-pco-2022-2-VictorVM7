class programa
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

    static void ordenaVetor(int[] vetor,int s, int a, int c)
    {
        int maior = 0; int i = 0; 
        for (int y = 0; y < vetor.Length; y++)
        {
            int pos = y;
            for (i = y; i < vetor.Length; i++)
            {
                if (vetor[i] < vetor[y])
                {
                    if (vetor[i] < vetor[pos])
                    {
                        pos = i;
                    }              
                }
            }
            maior = vetor[y];
            vetor[y] = vetor[pos];
            vetor[pos] = maior;
        }
    }

    static void Main(string[] args)
    {
        int[] vetorD = new int[10];
        preencheVetor(vetorD);
        int s = 0, a = 0, c = 0;
        ordenaVetor(vetorD, s, a, c);

        Console.WriteLine("Ord:");
        for (int i = 0; i < vetorD.Length; i++)
        {
            Console.Write($"\t{vetorD[i]}");
        }
    }
}
