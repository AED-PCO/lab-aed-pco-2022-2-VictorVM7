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
            // Se a fila tiver apenas um elemento. Retire o elemento retornando um elemento (Um novo aluno e uma nova referência vazia) vazio no lugar dele
            if(primeiro == ultimo)
            {
                Console.WriteLine("Sua pilha está vazia! Insira primeiro antes de remover\n");
                return new elemento();
            }

            else
            {
                elemento retirado = ultimo;
                elemento pesquisa = primeiro;

                while (pesquisa.proximo != ultimo)
                {
                    pesquisa = pesquisa.proximo;
                }

                ref elemento refPesquisa = ref pesquisa;
                ultimo = refPesquisa;

                return retirado;
            }
        }

        public static void mostrar(ref elemento primeiro, ref elemento ultimo)
        {
            elemento pilhaAluno;
            if (primeiro == ultimo)
            {
                Console.WriteLine("A pilha está vazia!");
                pilhaAluno = primeiro;
            }
            else
            {
                pilhaAluno = primeiro.proximo;
            }
            while (pilhaAluno != ultimo)
            {
                Console.WriteLine($"Aluno: {pilhaAluno.aluno.nome}");
                Console.WriteLine($"Registro: {pilhaAluno.aluno.registro}");
                pilhaAluno = pilhaAluno.proximo;
            }
            Console.WriteLine($"Aluno: {ultimo.aluno.nome}");
            Console.WriteLine($"Registro: {pilhaAluno.aluno.registro}");
        }
    }
}
