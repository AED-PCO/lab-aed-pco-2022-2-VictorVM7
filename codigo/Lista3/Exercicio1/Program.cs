    
        

    static void preencheVetor(int[] vetor)
    {
        for(int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1,50);
            Console.WriteLine(vetor[i]);
        }
    }

    static void Main(string[] args)
    {
        preencheVetor(vetor)
    }    
