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

static void ordenaVetor(int[] vetor)
{
    for (int valor = vetor.Length - 1; valor >= 0; valor--)
    {
        for (int i = 0; i < valor; i++)
        {
            if (vetor[i] > vetor[i + 1])
            {
                int aux = vetor[i + 1];
                vetor[i + 1] = vetor[i];
                vetor[i] = aux;
            }
        }
    }
}

static void Main(string[] args)
{
    int[] vetorD = new int[150];
    preencheVetor(vetorD);
    ordenaVetor(vetorD);

    Console.WriteLine("Ord:");
    for (int i = 0; i < vetorD.Length; i++)
    {
        Console.Write($"\t{vetorD[i]}");
    }
}