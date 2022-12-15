using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class ListaDinamica
    {
        public int valor;
        public ListaDinamica proximo;
        public ListaDinamica anterior;

        public void inserir(ListaDinamica aux, int valor)
        {
            if (aux.proximo == null)
            {
                aux.proximo = new ListaDinamica();
                aux.proximo.anterior = aux;
                aux.proximo.valor = valor;
            }
            else
            {
                aux.inserir(aux, valor);
            }
        }
        public void retirar(ListaDinamica aux)
        {
            if (aux.proximo == null)
            {
                aux = null;
            }
            else
            {
                aux.retirar(aux);
            }
        }
    }
}
