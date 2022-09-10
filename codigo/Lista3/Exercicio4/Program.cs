using System.Runtime.CompilerServices;

class program
{
    static string pesquisaVetor(int[] vetor, int ini, int mei, int fim, int num)
    {
        mei = (ini + fim)/2;

        if(num == vetor[mei])
            return $"Número {num} encontrado!";

        else if(num > vetor[ini] && num < vetor[mei])
        {
            fim = mei - 1;
            return pesquisaVetor(vetor, ini, mei, fim, num);
        }

        else if(num > vetor[mei] && num < vetor[fim])
        {
            ini = mei + 1;
            return pesquisaVetor(vetor, ini, mei, fim, num);
        }
        
        return "-1";
    }

    static void Main(string[] args)
    {
        int[] vetor = new int[8] {0, 1, 2, 3, 4, 5, 6, 7};
        int numero = 6;

        int inicio = 0;
        int meio = 0;
        int fim = vetor.Length - 1;
        
        Console.WriteLine(pesquisaVetor(vetor, inicio, meio, fim, numero));
    }
}
