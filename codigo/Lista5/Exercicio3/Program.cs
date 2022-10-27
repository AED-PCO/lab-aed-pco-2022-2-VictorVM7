using System.Runtime.InteropServices;

class programa
{
    static void preencheVetor(int[] vetor)
    {
        Console.WriteLine("Des:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Random numAleatorio = new Random();
            vetor[i] = numAleatorio.Next(1, 20);
            Console.Write($"\t{vetor[i]}");
        }
        Console.Write("\n");
    }

    static void ordenaVetor(int[] vetor)
    {
        int i = 0;
        for (int y = 1; y < vetor.Length; y++)
        {
            int cont = 0; int para = 0;
            int valor = vetor[y];
            for (i = y-1; i >= 0; i--)
            {
                if (vetor[y] < vetor[i])
                {
                    cont++;
                }
                else
                {
                    para = i;
                    break;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] vetorD = new int[8];
        preencheVetor(vetorD);
        ordenaVetor(vetorD);

        Console.WriteLine("Ord:");
        for (int i = 0; i < vetorD.Length; i++)
        {
            Console.Write($"\t{vetorD[i]}");
        }
    }
}
