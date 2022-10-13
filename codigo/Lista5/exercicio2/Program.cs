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
        Array.Sort(vetor);
        Array.Reverse(vetor);
        Console.Write("\n");
    }

    static void ordenaVetor(int[] vetor,int s, int a, int c)
    {
        int maior = 0; int i = 0; 
        for (int y = 0; y < vetor.Length; y++)
        {
            int pos = y;
            Console.WriteLine($"a = {++a}");
            for (i = y; i < vetor.Length; i++)
            {
                Console.WriteLine($"c = {++c}");
                if (vetor[i] < vetor[y])
                {
                    Console.WriteLine($"c = {++c}");
                    if (vetor[i] < vetor[pos])
                    {
                        Console.WriteLine($"a = {++a}");
                        pos = i;
                    }              
                }
            }
            maior = vetor[y];
            vetor[y] = vetor[pos];
            vetor[pos] = maior;
            Console.WriteLine($"a = {a += 3}");
        }
    }

    static void Main(string[] args)
    {
        int[] vetorD = new int[100];
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
