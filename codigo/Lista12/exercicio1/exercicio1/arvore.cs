using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore
{
    class arvore
    {
        nodulo noduloPai = new nodulo();

        public static void inserir(nodulo pai, int valor)
        {
            if(pai.valor < valor)
            {
                if(pai.noduloDir == null)
                {
                    nodulo noduloFilho = new nodulo(); 
                    noduloFilho.valor = valor;
                    noduloFilho.noduloPai = pai;
                    pai.noduloDir = noduloFilho;
                }
                else
                {
                    inserir(pai.noduloDir, valor);
                }
            }
        }
    }

    class nodulo
    {
        public nodulo noduloPai;
        public nodulo noduloEsq;
        public nodulo noduloDir;
        public int valor;
    }
}
