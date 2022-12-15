using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using arvore;
using funcoes;

class program
{
    public static void Main(string[] args)
    {
        nodulo nodulo = new nodulo();

        Boolean continuar = true;
        int valorDigitado = 0;
        int escolheFuncao;  // 1 - Insere | 2 - Busca | 3 - remove
        string resposta;

        while (continuar)
        {
            Console.WriteLine("--ARVORE--\nEscolha um opção digitando o número:\n[1] Inserir\n[2] Buscar\n[3] Remover");
            escolheFuncao = int.Parse(Console.ReadLine());

            switch (escolheFuncao)
            {
                case 1:
                    chamaFuncaoInserir(valorDigitado, nodulo);
                    break;

                case 2:
                    chamaFuncaoBusca(valorDigitado, nodulo);
                    break;

                case 3:
                    chamaFuncaoBusca(valorDigitado, nodulo);
                    break;

                default:
                    Console.WriteLine("Instrução inválida!");
                    Console.Clear();
                    break;
            }

            Console.WriteLine("Deseja continuar? [S] para continuar [N] para sair");
            resposta = Console.ReadLine().ToLower();

            if(resposta.Equals("n"))
                continuar = false;
            Console.Clear();
        }
    }

    static void chamaFuncaoInserir(int valor, nodulo nodulo)
    {
        try
        {
            Console.WriteLine("Digite um valor a INSERIR na árvore: ");
            valor = int.Parse(Console.ReadLine());
            funcoes.funcoes.Inserir(nodulo, valor);
        }
        catch(Exception)
        {
            Console.WriteLine("Digite um valor válido!");
        }        
    }

    static void chamaFuncaoBusca(int valor, nodulo nodulo)
    {
        Boolean numeroEncontrado;

        Console.WriteLine("Digite um valor a BUSCAR na árvore: ");
        valor = int.Parse(Console.ReadLine());

        numeroEncontrado = funcoes.funcoes.Busca(nodulo, valor);

        if (numeroEncontrado)
        {
            Console.WriteLine($"Número {valor} encontrado na árvore!");
        }
        else
        {
            Console.WriteLine($"Não foi possível encontrar o {valor} na árvore!\n");
        }
    }
}
