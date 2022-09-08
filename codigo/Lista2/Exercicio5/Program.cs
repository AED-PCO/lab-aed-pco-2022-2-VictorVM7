class program
{
    static void leVetor(int [] vetor)
    {
        for(int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1,2000);
            vetor[i] = valorInteiro;
            Console.WriteLine(valorInteiro);
        }
    }

    static int somaPares(int[] vetor, int aux)
    {
        if(aux == vetor.Length)
            return 0;

        if (vetor[aux] % 2 == 0)
            return vetor[aux] + somaPares(vetor, aux + 1);

        else
            return 0 + somaPares(vetor, aux + 1);
            
    }

    static void Main(string[] args)
    {
        int aux = 0;
        int[] vetorInt = new int[100];
        leVetor(vetorInt);
        Console.WriteLine("A soma dos pares no vetor é {0}", somaPares(vetorInt, aux));
    }
}