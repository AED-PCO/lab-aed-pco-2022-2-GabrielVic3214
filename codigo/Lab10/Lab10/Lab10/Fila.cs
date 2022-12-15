using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Fila
    {
        public int valor;
        public Fila proximo;

        public void inserir(Fila fila, int valor)
        {
            if(fila.proximo == null)
            {
                fila.proximo = new Fila();
                fila.proximo.valor = valor;
            }
            else
            {
                fila.inserir(fila, valor);
            }
        }
        public void retirar(Fila fila)
        {
            if (fila.proximo == null)
            {
                fila = null;
            }
            else
            {
                fila = fila.proximo;
                fila.retirar(fila.proximo);
            }
        }
    }
}
