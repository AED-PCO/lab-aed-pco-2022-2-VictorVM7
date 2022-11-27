using System;
using Estrutura;

namespace metodos
{
    class fila
    {
        public static void insereAluno(ref elemento ultimo, elemento novoAluno)
        {
            ultimo.proximo = novoAluno;
        }

        public static elemento removeAluno(ref elemento ultimo, ref elemento primeiro)
        {
            elemento primeiroAluno = primeiro.proximo;

            // Se a fila tiver apenas um elemento (SENTINELA). Retorna um elemento (Um novo aluno e uma nova referência vazia)
            if (primeiroAluno == null)
            {
                Console.WriteLine("Sua fila está vazia! Insira primeiro antes de remover\n");
                Console.WriteLine("Aperte enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                return new elemento();
            }

            else
            {
                // Cria um novo elemento, sendo um para ler cada referência de aluno. Outro para servir de referência para o aluno que sairá da fila 
                elemento retirado = primeiro.proximo;
                elemento alunoReferencia = retirado.proximo;

                primeiro.proximo = alunoReferencia;

                return retirado;
            }
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo)
        {
            // Cria um novo elemento para ler a fila e mostrar ela
            elemento filaAluno;

            // Se não houver aluno, mostra que a fila está vazia e passe a referência do primeiro para o novo elemento criado.
            if (primeiro == ultimo)
            {
                Console.WriteLine("A fila está vazia!");
                filaAluno = primeiro;
            }

            // Se houver algum aluno, passe a referência do primeiro para ele para começar a ler a fila
            else
            {
                filaAluno = primeiro.proximo;
            }

            // Enquanto o aluno não for o último, vai mostrando o nome e o registro. 
            while (filaAluno != ultimo)
            {
                if (filaAluno != null)
                {
                    Console.WriteLine($"Aluno: {filaAluno.aluno.nome}");
                    Console.WriteLine($"Registro: {filaAluno.aluno.registro}");
                    filaAluno = filaAluno.proximo;  // Passe a referência do próximo aluno para o que está sendo usado de comparação.
                }
                else
                    filaAluno = ultimo;
                    break;
            }

            // Quando houver apenas um aluno
            if( filaAluno == ultimo) {
                if( filaAluno != null)
                {
                    Console.WriteLine($"Aluno: {filaAluno.aluno.nome}");
                    Console.WriteLine($"Registro: {filaAluno.aluno.registro}");
                }
            }
        }
    }
}
