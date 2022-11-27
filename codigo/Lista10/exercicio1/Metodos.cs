using System;
using Estrutura;

namespace metodos
{
    class pilha
    {
        public static void insereAluno(ref elemento ultimo, elemento novoAluno)
        {
            ultimo.proximo = novoAluno;
        }

        public static elemento removeAluno(ref elemento ultimo, ref elemento primeiro)
        {
            // Se a fila tiver apenas um elemento (SENTINELA). Retorna um elemento (Um novo aluno e uma nova referência vazia)
            if(primeiro == ultimo)
            {
                Console.WriteLine("Sua pilha está vazia! Insira primeiro antes de remover\n");
                Console.WriteLine("Aperte enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                return new elemento();
            }

            else
            {
                // Cria um novo elemento, sendo um para ler cada referência de aluno. Outro para servir de referência para o aluno que sairá da pilha
                elemento alunoReferencia = primeiro;
                elemento retirado = ultimo;

                // Um loop para ler cada referência (Do próximo aluno). Caso a próxima referência seja o último aluno, pare no aluno anterior.
                while (alunoReferencia.proximo != ultimo)
                {
                    alunoReferencia = alunoReferencia.proximo;
                }

                // Passa a referência do penúltimo aluno para o último pois um que era o último foi retirada=o.
                ultimo = alunoReferencia;

                // Retorna o aluno retirado
                return retirado;
            }
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo)
        {
            // Cria um novo elemento para ler a pilha e mostrar ela
            elemento pilhaAluno;

            // Se não houver aluno, mostra que a pilha está vazia e passe a referência do primeiro para o novo elemento criado.
            if (primeiro == ultimo)
            {
                Console.WriteLine("A pilha está vazia!");
                pilhaAluno = primeiro;
            }

            // Se houver algum aluno, passe a referência do primeiro para ele para começar a ler a pilha
            else
            {
                pilhaAluno = primeiro.proximo;
            }

            // Enquanto o aluno não for o último, vai mostrando o nome e o registro. 
            while (pilhaAluno != ultimo)
            {
                Console.WriteLine($"Aluno: {pilhaAluno.aluno.nome}");
                Console.WriteLine($"Registro: {pilhaAluno.aluno.registro}");
                pilhaAluno = pilhaAluno.proximo;  // Passe a referência do próximo aluno para o que está sendo usado de comparação.
            }

            // Quando houver apenas um aluno
            if( pilhaAluno == ultimo) {
                if( pilhaAluno.aluno.registro > 0)
                {
                    Console.WriteLine($"Aluno: {pilhaAluno.aluno.nome}");
                    Console.WriteLine($"Registro: {pilhaAluno.aluno.registro}");
                }
            }
        }
    }
}
