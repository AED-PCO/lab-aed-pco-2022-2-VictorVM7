class program
{
    static void preencheVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1, 50);
            Console.Write(vetor[i] + " ");
        }
    }

    static void ordenaVetor(int[] vetor)
    {
        for (int y = vetor.Length; y > 0; y--)
        {
            for (int i = 1; i < y; i++)
            {
                if (vetor[i] > vetor[i + 1])
                {
                    int aux = vetor[i + 1];
                    Console.WriteLine(aux);
                    vetor[i + 1] = vetor[i];
                    Console.WriteLine(vetor[i + 1]);
                    vetor[i] = aux;
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] vetorD = new int[10];
        preencheVetor(vetorD);
        ordenaVetor(vetorD);

       for (int i = 0; i < vetorD.Length; i++)
        {
            Console.Write(vetorD[i]);
        }
    }
}

