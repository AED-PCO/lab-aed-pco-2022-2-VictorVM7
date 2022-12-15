using System;
using Arvore;

namespace exercicio1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Nodulo no = new ElementoArvore();
            Console.WriteLine(no.elemento.valor);
        }
    }
}
