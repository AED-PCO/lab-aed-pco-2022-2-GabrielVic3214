using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Arvore
    {
        public void inserir(int valor, Nodo nodo)
        {
            if (valor > nodo.valorNodo)
            {
                if (nodo.fDireito == null)
                {
                    Nodo filho = new Nodo();
                    filho.pai = nodo;
                    filho.valorNodo = valor;
                    nodo.fDireito = filho;
                }
                else
                {
                    inserir(valor, nodo.fDireito);
                }
            }
            else
            {
                if (nodo.fEquerdo == null)
                {
                    Nodo filho = new Nodo();
                    filho.pai = nodo;
                    filho.valorNodo = valor;
                    nodo.fEquerdo = filho;
                }
                else
                {
                    inserir(valor, nodo.fEquerdo);
                }
            }
        }
    }
}
