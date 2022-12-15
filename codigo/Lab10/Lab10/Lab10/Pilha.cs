using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Pilha
    {
        public int valor;
        public Pilha proximo;

        public void inserir(Pilha pilha, int valor)
        {
            if(pilha.proximo == null)
            {
                pilha.proximo = new Pilha();
                pilha.proximo.valor = valor;
            }
            else
            {
                pilha.inserir(pilha, valor);
            }
        }
        public void retirar(Pilha pilha)
        {
            if (pilha.proximo == null)
            {
                pilha = null;
            }
            else
            {
                pilha.retirar(pilha);
            }
        }
    }
}
