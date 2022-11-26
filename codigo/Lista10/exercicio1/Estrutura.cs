using System;

namespace Estrutura
{
    class aluno
    {
        public string nome;
        public int registro;
    }

    class elemento
    {
        public aluno aluno = new aluno();
        public elemento proximo;
    }
}