using System.ComponentModel;

class Program
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
            vetor[i] = numAleatorio.Next(1, 50);
            Console.Write($"{vetor[i]} ");
        }
        Console.Write("\n");
    }

    static void Main(string[] args)
    {
        // Criando vetor e preenchendo
        int[] vetor = new int[24];
        preencheVetor(vetor);

        // Atribui o vetor ordenado a uma variável na Main
        int[] vetorOrdenado = new int[vetor.Length];
        vetorOrdenado = divideVetor(vetor);

        // Printa o vetor ordenado
        printaVetor(vetorOrdenado);
    }

    static int[] divideVetor(int[] vet)
    {
        // Função de parada caso o vet,length seja = 1
        if (vet.Length == 1)
            return vet;

        // Se o vetor for par, faça esse código
        if(vet.Length % 2 == 0){
            // Criação do vetor A e B
            int[] vetorA = new int[vet.Length / 2];
            int[] vetorB = new int[vet.Length / 2];
            // Preenchimento do vetor A e B com os valores da esquerda (A) e da direita (B)
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = vet[i];
                vetorB[i] = vet[i + vet.Length / 2];
            }

            // Divisão do vetor A e B
            int[] vetorOrdenadoA = new int[vetorA.Length];
            int[] vetorOrdenadoB = new int[vetorB.Length];
            vetorOrdenadoA = divideVetor(vetorA);
            vetorOrdenadoB = divideVetor(vetorB);

            // Comparando o vetor A e B concatenados no vetor Ordenado
            int[] vetOrdenado = new int[vetorA.Length + vetorB.Length];

            // Auxiliares que contaram as posições nos vetores e se o vetor estourou
            int contAuxEsquerda = 0, contAuxDireita = 0;
            int auxiliar1 = 0, auxiliar2 = 0;

            for (int i = 0; i < vetOrdenado.Length; i++)
            {  // Percorre o vetor concatenado comparando as posições de A e B
                if (vetorOrdenadoA[contAuxEsquerda] > vetorOrdenadoB[contAuxDireita] && auxiliar1 == 0)
                {
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    if (contAuxDireita < vetorOrdenadoB.Length - 1)  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxDireita++;
                    else
                        auxiliar1++;
                }
                else if (vetorOrdenadoA[contAuxEsquerda] <= vetorOrdenadoB[contAuxDireita] && auxiliar2 == 0)
                {   // Percorre o vetor concatenado comparando as posições de A e B
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    if (contAuxEsquerda < vetorOrdenadoA.Length - 1)  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxEsquerda++;
                    else
                        auxiliar2++;
                }
                // Se o vetor B já estourou, pega o valor da posição do vetor A e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else if (auxiliar1 != 0)
                {
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda];
                    contAuxEsquerda++;
                }
                // Se o vetor A já estourou, pega o valor da posição do vetor B e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else
                {
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    contAuxDireita++;
                }
            }
            return vetOrdenado; // Retorna os vetores em comparação ordenados
        }

        // Se algum vetor.length for ímpar, faça esse código com um lado par e outro ímpar.
        else {
            int[] vetorA = new int[vet.Length / 2];
            int[] vetorB = new int[(vet.Length / 2) + 1];
            // Preenchimento do vetor A e B com os valores da esquerda (A) PAR e da direita (B) ÍMPAR
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = vet[i];
            }
            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorB[i] = vet[i + vet.Length / 2];
            }

            // Divisão do vetor A e B
            int[] vetorOrdenadoA = new int[vetorA.Length];
            int[] vetorOrdenadoB = new int[vetorB.Length];
            vetorOrdenadoA = divideVetor(vetorA);
            vetorOrdenadoB = divideVetor(vetorB);

            // Comparando o vetor A e B concatenados no vetor Ordenado
            int[] vetOrdenado = new int[vetorA.Length + vetorB.Length];

            // Auxiliares que contaram as posições nos vetores e se o vetor estourou
            int contAuxEsquerda = 0, contAuxDireita = 0;
            int auxiliar1 = 0, auxiliar2 = 0;

            for (int i = 0; i < vetOrdenado.Length; i++)
            {  // Percorre o vetor concatenado comparando as posições de A e B
                if (vetorOrdenadoA[contAuxEsquerda] > vetorOrdenadoB[contAuxDireita] && auxiliar1 == 0)
                {
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    if (contAuxDireita < vetorOrdenadoB.Length - 1)  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxDireita++;
                    else
                        auxiliar1++;
                }
                else if (vetorOrdenadoA[contAuxEsquerda] <= vetorOrdenadoB[contAuxDireita] && auxiliar2 == 0)
                {   // Percorre o vetor concatenado comparando as posições de A e B
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    if (contAuxEsquerda < vetorOrdenadoA.Length - 1)  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxEsquerda++;
                    else
                        auxiliar2++;
                }
                // Se o vetor B já estourou, pega o valor da posição do vetor A e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else if (auxiliar1 != 0)
                {
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda];
                    contAuxEsquerda++;
                }
                // Se o vetor A já estourou, pega o valor da posição do vetor B e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else
                {
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    contAuxDireita++;
                }
            }
            return vetOrdenado; // Retorna os vetores em comparação ordenados
        }
    }
}