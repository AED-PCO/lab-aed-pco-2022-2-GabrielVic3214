using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Lista
    {
        public int valor;
        public int posAtual;
        public Lista proximo;

        public void inserir(Lista lista, int valor, int pos)
        {
            if (lista.proximo == null)
            {
                lista.proximo = new Lista();
                lista.proximo.valor = valor;
                lista.proximo.posAtual = lista.proximo.posAtual + 1;
            }
            else
            {
                lista.inserir(lista, valor, pos);
            }
        }
        public void retirar(Lista lista)
        {
            if (lista.proximo == null)
            {
                lista = null;
            }
            else
            {
                lista.retirar(lista);
            }
        }
    }
}
