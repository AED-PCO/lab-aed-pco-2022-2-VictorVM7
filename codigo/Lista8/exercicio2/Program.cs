using System.Globalization;

internal class Program
{
    //Imprime o vetor
    static void imprimeVetor(int[] vet, int pos)
    {
        Console.Write("Pilha: ");
        for (int i = 0; i < pos; i++)
        {
            Console.Write(vet[i] + " ");
        }
        Console.Write("\n");
    }

    // Main
    static void Main(string[] args)
    {
        int[] vet = new int[4];
        int[] vetor = new int[4];
        int pos = 0;

        while (pos >= 0)
        {
            Console.Beep();
            Console.WriteLine("Deseja inserir, retirar ou imprimir pilha\n[I] para inseri\n[R] para retirar\n[V] para Imprimir vetor");
            string escolha = Console.ReadLine().ToLower();

            if (escolha.Equals("s"))
                break;

            else if (escolha.Equals("i") && pos < vetor.Length)
            {
                vetor = insere(vet, pos);
                pos++;
            }
            else if (escolha.Equals("r") && pos != 0)
            {
                retira(vetor, pos); 
                pos--;
            }
            else if (escolha.Equals("v"))
            {
                if (pos != 0)
                    imprimeVetor(vetor, pos);
                else
                    Console.WriteLine("Pilha vazia!");
            }
            else if (pos >= vetor.Length)
            {
                Console.WriteLine("Sua pilha está cheia! Você pode retirar ou imprimir!");
            }
            else if (pos == 0)
            {
                Console.WriteLine("Sua pilha está vazia! Você pode inserir ou imprimir!");
            }
            else
            {
                Console.WriteLine("Escolha não aplicada.");
                break;
            }
        }
    }

    // Insere valores na pilha
    static int[] insere(int[] vetor, int pos)
    {
        Console.WriteLine($"Preencha a pilha na posição {pos + 1}: ");
        vetor[pos] = int.Parse(Console.ReadLine());
        return vetor;
    }

    // Retira valores da pilha
    static int[] retira(int[] vet, int pos)
    {
        string escolha;
        for (int i = pos; i > 0; i--)
        {
            Console.WriteLine($"Retirar número na posição {pos}? [S] Sim e [N] Não");
            escolha = Console.ReadLine().ToLower();
            if (escolha.Equals('s'))
            {
                vet[i - 1] = vet[i];
            }
            else
                break;
        }
       return vet;
    }
}