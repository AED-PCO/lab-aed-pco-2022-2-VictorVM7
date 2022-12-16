using arvore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    class funcoes
    {
        nodulo noduloPai = new nodulo();

        public static void Inserir(nodulo pai, int valor)
        {
            if (pai.noduloPai == null)
            {
                pai.valor = valor;
                pai.noduloPai = pai;
            }

            else if (pai.valor < valor)
            {
                if (pai.noduloDir == null)
                {
                    nodulo noduloFilho = new nodulo();
                    noduloFilho.valor = valor;
                    noduloFilho.noduloPai = pai;
                    pai.noduloDir = noduloFilho;
                }
                else
                {
                    Inserir(pai.noduloDir, valor);
                }
            }
            else if (pai.valor >= valor)
            {
                if (pai.noduloEsq == null)
                {
                    nodulo noduloFilho = new nodulo();
                    noduloFilho.valor = valor;
                    noduloFilho.noduloPai = pai;
                    pai.noduloEsq = noduloFilho;
                }
                else
                {
                    Inserir(pai.noduloEsq, valor);
                }
            }
        }

        public static Boolean Busca(nodulo pai, int valor)
        {
            int numeroEncontrado = 0;

            if (pai.noduloPai.valor != null)
            {
                if(pai.noduloPai.valor == valor)
                {
                    numeroEncontrado = 1;
                    return true;
                }
            }

            if (pai.noduloEsq != null)
            {
                if(pai.noduloEsq.valor == valor)
                {
                    numeroEncontrado = 1;
                    return true;
                }
                else
                    Busca(pai.noduloEsq, valor);
            }

            else if (pai.noduloDir != null)
            {
                if (pai.noduloDir.valor == valor)
                {
                    numeroEncontrado = 1;
                    return true;
                }
                else
                    Busca(pai.noduloDir, valor);
            }

            if (numeroEncontrado == 1)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}

