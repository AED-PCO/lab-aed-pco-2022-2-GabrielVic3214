using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha a atividade: ");
            int op = int.Parse(Console.ReadLine());
            int[] vetor = new int[5] { 1, 2, 3, 4, 5 };
            int[] vetorDesordenado = new int[5] { 5, 3, 1, 2, 4 };
            switch (op)
            {
                case 1:
                    Console.Write("Pesquisa Binária sem pos: ");
                    int pesquisaSPos = int.Parse(Console.ReadLine());
                    pesquisaBinariaSemPos(vetor, 0, vetor.Length - 1, pesquisaSPos);
                    break;
                case 2:
                    Console.Write("Pesquisa Binária com pos: ");
                    int pesquisaCPos = int.Parse(Console.ReadLine());
                    int pos = 0;
                    int meio = (vetor.Length - 1) / 2;
                    if (vetor[meio] < pesquisaCPos)
                        pos = meio + 1;
                    pesquisaBinariaComPos(vetor, pos, pesquisaCPos);
                    break;
                case 3:
                    Console.WriteLine("Ordenação Binária sem pos");
                    ordenacaoSemPos(vetorDesordenado, 0, 0);
                    lerVetor(vetorDesordenado);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Inválida");
                    break;
            }
            Console.ReadLine();
        }
        static int pesquisaBinariaSemPos(int[] vetor, int inicio, int final, int pesquisa)
        {
            int meio = (int)(final - inicio) / 2;
            if (vetor[meio] == pesquisa)
            {
                Console.WriteLine("Exite no vetor");
                return 0;
            }
            else if (vetor[meio] > pesquisa)
                final = meio - 1;
            else if (vetor[meio] <= pesquisa)
                inicio = meio + 1;

            if (inicio == final || final - inicio == 1)
            {
                if (vetor[inicio] == pesquisa || vetor[final] == pesquisa)
                    Console.WriteLine("Exite no vetor");
                else
                    Console.WriteLine("Não exite no vetor");
                return 0;
            }
            return pesquisaBinariaSemPos(vetor, inicio, final, pesquisa);
        }
        static int pesquisaBinariaComPos(int[] vetor, int pos, int pesquisa)
        {
            if (vetor[pos] == pesquisa)
            {
                Console.WriteLine("Exite no vetor");
                return 0;
            }
            else if (pos >= vetor.Length - 1)
            {
                Console.WriteLine("Não exite no vetor");
                return 0;
            }
            pos++;
            return pesquisaBinariaComPos(vetor, pos, pesquisa);
        }
        static int ordenacaoSemPos(int[] vetor, int refPos, int menorPos)
        {
            if(refPos >= vetor.Length - 1)
            {
                return menorPos;
            }
            if(vetor[refPos] < vetor[menorPos])
            {
                menorPos = refPos;
            }
            menorPos = ordenacaoSemPos(vetor, refPos + 1, menorPos);

            int aux = vetor[refPos];
            vetor[refPos] = vetor[menorPos];
            vetor[menorPos] = aux;
            return 0;
        }
        static void ordenacaoSemPosTeste(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int menorPos = i;
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menorPos])
                    {
                        menorPos = j;
                    }
                }
                int aux = vetor[i];
                vetor[i] = vetor[menorPos];
                vetor[menorPos] = aux;
            }
            lerVetor(vetor);
        }
        static void lerVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");
            }
        }
    }
}
