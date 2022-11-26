using System;
using System.Globalization;
using Estrutura;
using System.Timers;
using metodos;

internal class Program
{
    // Main
    static void Main(string[] args)
    {
        elemento primeiro = new elemento();
        elemento ultimo = primeiro;
        Boolean on = true;

        int registro;
        int escolha;
        string nome;

        do
        {
            // Pergunta o usuário o que ele quer fazer
            Console.WriteLine("Inserir [1] | Retirar [2] | Vizualizar [3] | Quit [4]");
            escolha = int.Parse(Console.ReadLine());

            // Inserir
            if (escolha == 1)
            {
                // Pergunta o nome e o registro
                Console.Write("Digite o NOME do aluno: ");
                nome = Console.ReadLine();
                Console.Write($"Digite o REGISTRO de {nome}: ");
                registro = int.Parse(Console.ReadLine());

                // While para o usuário passar o registro correto do aluno
                while (registro > 1000 || registro <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Registro informado com formato inesperado! O registro deve estar entre 1 e 1000\n");
                    Console.Write($"Digite o registro de {nome}: ");
                    registro = int.Parse(Console.ReadLine());
                }

                // Cria um novo aluno com o nome e o registro
                elemento novoAluno = new elemento();
                novoAluno.aluno.nome = nome;
                novoAluno.aluno.registro = registro;

                // Funcao Registra
                metodos.pilha.insereAluno(ref ultimo, novoAluno);
                ultimo = novoAluno;

                Console.WriteLine("Aluno inserido!");
                Console.Clear();
            }

            else if (escolha == 2)
            {
                elemento alunoRemovido = metodos.pilha.removeAluno(ref ultimo, ref primeiro);
                Console.WriteLine($"Aluno removido:\n{alunoRemovido.aluno.nome}");
            }

            else if (escolha == 3)
            {
                Console.Clear();
                metodos.pilha.mostrar(ref primeiro, ref ultimo);
                Console.ReadLine();
                Console.Clear();
            }

            else { }

        } while (on == true);
    }
}