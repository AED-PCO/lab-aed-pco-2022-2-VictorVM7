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
        // Inicializa o sentinela
        elemento primeiro = new elemento();
        elemento ultimo = primeiro;
        Boolean on = true;  // Deixa o programa ligado até tornar falso (escolha = 4)

        // Variáveis que recebem os valore de escolha no programa, nome e registro dos alunos
        int registro;
        int escolha;
        string nome;

        do
        {
            // Pergunta o usuário o que ele quer fazer
            Console.WriteLine("Inserir [1] | Retirar [2] | Vizualizar [3] | Quit [4]");
            escolha = int.Parse(Console.ReadLine());

            // Se.. Inserir
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

            // Se... para remover aluno
            else if (escolha == 2)
            {
                // Cria um elemento apenas para o aluno retirado passadno a referência do último e do primeiro mostrando qual foi retirado
                elemento alunoRemovido = metodos.pilha.removeAluno(ref ultimo, ref primeiro);
                if(alunoRemovido.aluno.registro > 0)
                    Console.WriteLine($"Aluno removido: {alunoRemovido.aluno.nome}");
            }

            // Se... para mostrar
            else if (escolha == 3)
            {
                Console.Clear();
                metodos.pilha.mostrar(ref primeiro, ref ultimo);
                Console.WriteLine("Aperte enter para continuar...");
                Console.ReadLine();
            }

            // Fecha o loop do programa
            else if (escolha == 4 || escolha == null)
            {
                on = false;
            }

            else { Console.WriteLine("Essa escolha não existe. Tente novamente"); Console.Clear(); }

        } while (on == true);
    }
}