using System.ComponentModel;

class Program
{
    // Print dos valores
    static void printaVetor(int[] vet)
    {
        Console.Write("\nVetor = ");
        for (int i = 0; i < vet.Length; i++)
        {
            Console.Write(vet[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        // Criando vetor
        int[] vetor = { 9, 8, 7, 6, 5, 4, 3, 2 };
        int ini = 0, fim = vetor.Length - 1, meio = 0;
        int y = 0; 

        // Atribuindo valores aos vetores A e B (MetadeA e MetadeB)

        /*for (int i = 0; i < vetor.Length; i++)
        {
            if (i <= (vetor.Length - 1) / 2)
                vetorA[i] = vetor[i];
            else if (i > (vetor.Length - 1) / 2)
                vetorB[y++] = vetor[i];
        }*/

        // Printa vetorA e vetorB
        divideVetor(vetor, ini, fim);
        printaVetor(vetor);
    }

    static int[] divideVetor(int[] vet, int inicio, int fim)
    {
        if (vet.Length == 1)
            return vet;

        int meio = (inicio + fim) / 2;
        int[] vetorA = new int[vet.Length / 2];
        int[] vetorB = new int[vet.Length / 2];

        for(int i = 0; i < vetorA.Length; i++) {
            vetorA[i] = vet[i];
            vetorA[i] = vet[i + vet.Length / 2];
        }

        int[] vetorOrdenadoA = new int[vetorA.Length];
        int[] vetorOrdenadoB = new int[vetorB.Length];
        vetorOrdenadoA = divideVetor(vet, inicio, meio);
        vetorOrdenadoB = divideVetor(vet, meio + 1, fim);

        int[] vetOrdenado = new int[vetorA.Length + vetorB.Length];
    }
}