using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvore = new Arvore();
            Nodo nodoRaiz = new Nodo();
            nodoRaiz.valorNodo = 20;

            arvore.inserir(10,nodoRaiz);
            arvore.inserir(30,nodoRaiz);
            arvore.inserir(15,nodoRaiz);
        }
    }
}
