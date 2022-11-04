class program
{
    // Print dos valores
    static void printaVetor(int[] vet)
    {
        Console.Write("Vetor = ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write($"{vet[i]} ");
        }
    }
    // Preenche o vetor aleatoriamente dentro do intervalo Next
    static void preencheVetor(int[] vetor)
    {
        Console.Write("Desor = ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1, 10000);
            Console.Write($"{vetor[i]} ");
        }
        Console.Write("\n");
        Array.Sort(vetor);
    }
    static string pesquisaVetor(int[] vetor, int ini, int mei, int fim, int num, int atri, int comp, int soma)
    {
        
        mei = (ini + fim)/2; 
        atri++;
        Console.WriteLine($"Atribuição = {atri}");
        Console.WriteLine($"Comparação = {comp}");

        if(num == vetor[mei])
        {
            comp++;
            Console.WriteLine($"Atribuição = {atri}");
            Console.WriteLine($"Comparação = {comp}");
            return $"Número {num} encontrado!";
        }
          
        else if(num >= vetor[ini] && num < vetor[mei])
        {
            atri++;
            comp++;
            Console.WriteLine($"Atribuição = {atri}");
            Console.WriteLine($"Comparação = {comp}");
            fim = mei;
            return pesquisaVetor(vetor, ini, mei, fim, num, atri, comp, soma);
        }

        else if(num > vetor[mei] && num <= vetor[fim])
        {
            atri++;
            comp++;
            Console.WriteLine($"Atribuição = {atri}");
            Console.WriteLine($"Comparação = {comp}");
            ini = mei + 1;
            Console.WriteLine($"Soma = {++soma}");
            return pesquisaVetor(vetor, ini, mei, fim, num, atri, comp, soma);
        }
        comp+=3;
        Console.WriteLine($"Atribuição = {atri}");
        Console.WriteLine($"Comparação = {comp}");
        return "-1";
    }

    static void Main(string[] args)
    {
        int[] vetor;
        vetor = new int[100];
        preencheVetor(vetor);
        printaVetor(vetor);
        int numero = int.Parse(Console.ReadLine());

        int inicio = 0;
        int meio = 0;
        int fim = vetor.Length - 1;

        int contAtri = 0;
        int contComp = 0;
        int contSoma = 0;
        
        Console.WriteLine(pesquisaVetor(vetor, inicio, meio, fim, numero, contAtri, contComp, contSoma));

    }
}
