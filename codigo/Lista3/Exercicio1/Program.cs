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
            vetor[i] = numAleatorio.Next(1, 10000);
            Console.Write($"{vetor[i]} ");
        }
        Console.Write("\n");
    }

    static void Main(string[] args)
    {
        // Criando vetor e preenchendo
        int[] vetor = new int[10000];
        preencheVetor(vetor);

        // Atribui o vetor ordenado a uma variável na Main
        int[] vetorOrdenado = new int[vetor.Length];
        int atri = 0; int comp = 0; int soma = 0;
        vetorOrdenado = divideVetor(vetor, atri, comp, soma);

        // Printa o vetor ordenado
        printaVetor(vetorOrdenado);
    }

    static int[] divideVetor(int[] vet, int atri, int comp, int soma)
    {
        // Função de parada caso o vet,length seja = 1
        if (vet.Length == 1)
            return vet;

        // Se o vetor for par, faça esse código
        if(vet.Length % 2 == 0){
            // Criação do vetor A e B
            int[] vetorA = new int[vet.Length / 2];
            int[] vetorB = new int[vet.Length / 2];
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            // Preenchimento do vetor A e B com os valores da esquerda (A) e da direita (B)
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = vet[i];
                vetorB[i] = vet[i + vet.Length / 2];
                Console.WriteLine($"A = {++atri}");
                Console.WriteLine($"A = {++atri}");
                Console.WriteLine($"S = {++soma}");
            }

            // Divisão do vetor A e B
            int[] vetorOrdenadoA = new int[vetorA.Length];
            int[] vetorOrdenadoB = new int[vetorB.Length];
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            vetorOrdenadoA = divideVetor(vetorA, atri, comp, soma);
            vetorOrdenadoB = divideVetor(vetorB, atri, comp, soma);

            // Comparando o vetor A e B concatenados no vetor Ordenado
            int[] vetOrdenado = new int[vetorA.Length + vetorB.Length];
            Console.WriteLine($"A = {++atri}");

            // Auxiliares que contaram as posições nos vetores e se o vetor estourou
            int contAuxEsquerda = 0, contAuxDireita = 0;
            int auxiliar1 = 0, auxiliar2 = 0;
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");

            for (int i = 0; i < vetOrdenado.Length; i++)
            {  // Percorre o vetor concatenado comparando as posições de A e B
                if (vetorOrdenadoA[contAuxEsquerda] > vetorOrdenadoB[contAuxDireita] && auxiliar1 == 0)
                {
                    Console.WriteLine($"C = {++comp}");
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    Console.WriteLine($"A = {++atri}");// Passa a posição do vetor ordenado B para a posição I do vetOrdenado

                    if (contAuxDireita < vetorOrdenadoB.Length - 1)
                    {
                        Console.WriteLine($"A = {++atri}");
                        Console.WriteLine($"C = {++comp}");
                        Console.WriteLine($"S = {++soma}");
                        // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxDireita++;
                    }
                    else
                    {
                        Console.WriteLine($"S = {++soma}");
                        auxiliar1++;
                    }

                }

                else if (vetorOrdenadoA[contAuxEsquerda] <= vetorOrdenadoB[contAuxDireita] && auxiliar2 == 0)
                {
                    Console.WriteLine($"C = {++comp}");
                    // Percorre o vetor concatenado comparando as posições de A e B
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    Console.WriteLine($"A = {++atri}");

                    if (contAuxEsquerda < vetorOrdenadoA.Length - 1)
                    {
                        Console.WriteLine($"A = {++atri}");
                        Console.WriteLine($"C = {++comp}");
                        Console.WriteLine($"S = {++soma}");
                        contAuxEsquerda++;
                    }  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso

                    else
                    {
                        Console.WriteLine($"S = {++soma}");
                        auxiliar2++;
                    }
                        
                }
                // Se o vetor B já estourou, pega o valor da posição do vetor A e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else if (auxiliar1 != 0)
                {
                    Console.WriteLine($"S = {++soma}");
                    Console.WriteLine($"A = {++atri}");
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda];
                    contAuxEsquerda++;
                }
                // Se o vetor A já estourou, pega o valor da posição do vetor B e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else
                {
                    Console.WriteLine($"S = {++soma}");
                    Console.WriteLine($"A = {++atri}");
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    contAuxDireita++;
                }
            }
            return vetOrdenado; // Retorna os vetores em comparação ordenados
        }

        // Se algum vetor.length for ímpar, faça esse código com um lado par e outro ímpar.
        else {
            // Criação do vetor A e B
            int[] vetorA = new int[vet.Length / 2];
            int[] vetorB = new int[(vet.Length / 2) + 1];
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            // Preenchimento do vetor A e B com os valores da esquerda (A) e da direita (B)
            for (int i = 0; i < vetorA.Length; i++)
            {
                vetorA[i] = vet[i];
                Console.WriteLine($"A = {++atri}");
                Console.WriteLine($"S = {++soma}");
            }

            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorB[i] = vet[i + vet.Length / 2];
                Console.WriteLine($"A = {++atri}");
                Console.WriteLine($"S = {++soma}");
            }

            // Divisão do vetor A e B
            int[] vetorOrdenadoA = new int[vetorA.Length];
            int[] vetorOrdenadoB = new int[vetorB.Length];
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            vetorOrdenadoA = divideVetor(vetorA, atri, comp, soma);
            vetorOrdenadoB = divideVetor(vetorB, atri, comp, soma);

            // Comparando o vetor A e B concatenados no vetor Ordenado
            int[] vetOrdenado = new int[vetorA.Length + vetorB.Length];
            Console.WriteLine($"A = {++atri}");

            // Auxiliares que contaram as posições nos vetores e se o vetor estourou
            int contAuxEsquerda = 0, contAuxDireita = 0;
            int auxiliar1 = 0, auxiliar2 = 0;
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");
            Console.WriteLine($"A = {++atri}");

            for (int i = 0; i < vetOrdenado.Length; i++)
            {  // Percorre o vetor concatenado comparando as posições de A e B
                if (vetorOrdenadoA[contAuxEsquerda] > vetorOrdenadoB[contAuxDireita] && auxiliar1 == 0)
                {
                    Console.WriteLine($"C = {++comp}");
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    Console.WriteLine($"A = {++atri}");// Passa a posição do vetor ordenado B para a posição I do vetOrdenado

                    if (contAuxDireita < vetorOrdenadoB.Length - 1)
                    {
                        Console.WriteLine($"A = {++atri}");
                        Console.WriteLine($"C = {++comp}");
                        Console.WriteLine($"S = {++soma}");
                        // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso
                        contAuxDireita++;
                    }
                    else
                    {
                        Console.WriteLine($"S = {++soma}");
                        auxiliar1++;
                    }

                }

                else if (vetorOrdenadoA[contAuxEsquerda] <= vetorOrdenadoB[contAuxDireita] && auxiliar2 == 0)
                {
                    Console.WriteLine($"C = {++comp}");
                    // Percorre o vetor concatenado comparando as posições de A e B
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda]; // Passa a posição do vetor ordenado B para a posição I do vetOrdenado
                    Console.WriteLine($"A = {++atri}");

                    if (contAuxEsquerda < vetorOrdenadoA.Length - 1)
                    {
                        Console.WriteLine($"A = {++atri}");
                        Console.WriteLine($"C = {++comp}");
                        Console.WriteLine($"S = {++soma}");
                        contAuxEsquerda++;
                    }  // Confere se o vetor já estourou. Se estourou marca o auxiliar para mostrar que estourou e tornar o If Falso

                    else
                    {
                        Console.WriteLine($"S = {++soma}");
                        auxiliar2++;
                    }

                }
                // Se o vetor B já estourou, pega o valor da posição do vetor A e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else if (auxiliar1 != 0)
                {
                    Console.WriteLine($"S = {++soma}");
                    Console.WriteLine($"A = {++atri}");
                    vetOrdenado[i] = vetorOrdenadoA[contAuxEsquerda];
                    contAuxEsquerda++;
                }
                // Se o vetor A já estourou, pega o valor da posição do vetor B e joga no vetor ordenado até acabar as posições no vetOrdenado.
                else
                {
                    Console.WriteLine($"S = {++soma}");
                    Console.WriteLine($"A = {++atri}");
                    vetOrdenado[i] = vetorOrdenadoB[contAuxDireita];
                    contAuxDireita++;
                }
            }
            return vetOrdenado; // Retorna os vetores em comparação ordenados            
        }
    }
}