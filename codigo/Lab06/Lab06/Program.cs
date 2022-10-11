using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha a atividade: ");
            int op = int.Parse(Console.ReadLine());
            int[] array = new int[6] { 23, 16, 4, 42, 8, 15 };
            int[] arrayShell = new int[10] { 23, 15, 26, 42, 16, 8, 77, 4, 13, 93 };
            int[] arrayQuick = new int[8] { 23, 95, 8, 4, 15, 77, 16, 42 };
            switch (op)
            {
                case 1:
                    Console.WriteLine("Bubblesort");
                    Bubblesort(array);
                    break;
                case 2:
                    Console.WriteLine("Seleção");
                    Selecao(array);
                    break;
                case 3:
                    Console.WriteLine("Inserção");
                    Insercao(array);
                    break;
                case 4:
                    Console.WriteLine("Mergesort");
                    break;
                case 5:
                    Console.WriteLine("Shellsort");
                    Shellsort(arrayShell);
                    break;
                case 6:
                    Console.WriteLine("Quicksort");
                    Quicksort(arrayQuick);
                    break;
                case 7:
                    Console.WriteLine("Ordenação por Contagem");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
        static void LerVetor(int[] vetor)
        {
            String text = "";
            foreach (int v in vetor)
            {
                text += v + ",";
            }
            text = text.Substring(0, text.Length - 1);
            Console.WriteLine(text);
        }
        static void Bubblesort(int[] vetor)
        {
            for (int i = vetor.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < vetor.Length; j++)
                {
                    if (j + 1 <= vetor.Length - 1)
                    {
                        if (vetor[j] > vetor[j + 1])
                        {
                            int aux = vetor[j + 1];
                            vetor[j + 1] = vetor[j];
                            vetor[j] = aux;
                        }
                    }
                }
            }
            LerVetor(vetor);
        }
        static void Selecao(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                int menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                int aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
            LerVetor(vetor);
        }
        static void Insercao(int[] vetor)
        {
            for (int i = 1; i < vetor.Length; i++)
            {
                int menor = vetor[i];
                int ultimaPos = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (menor > vetor[j])
                    {
                        ultimaPos = ++j;
                        break;
                    }
                    else if (vetor[j] < menor)
                    {
                        ultimaPos = ++j;
                        break;
                    }
                    else
                    {
                        vetor[j + 1] = vetor[j];
                    }
                }
                vetor[ultimaPos] = menor;
            }
            LerVetor(vetor);
        }
        static void Shellsort(int[] vetor)
        {
            int hop = 4;
            while (hop >= 1)
            {
                for (int i = hop; i < vetor.Length; i++)
                {
                    int refIndex = i;
                    for (int j = i - hop; j >= 0; j -= hop)
                    {
                        if (vetor[refIndex] < vetor[j])
                        {
                            int aux = vetor[refIndex];
                            vetor[refIndex] = vetor[j];
                            vetor[j] = aux;
                            refIndex = j;
                        }
                    }
                }
                hop /= 2;
                LerVetor(vetor);
            }
        }
        static void Quicksort(int[] vetor)
        {
            int part = 0, divPart = -1;
            int fim = vetor.Length;
            while (fim >= 0)
            {
                for (int i = 1; i < fim; i++)
                {
                    if (vetor[i] < vetor[fim - 1])
                    {
                        part++;
                        int aux = vetor[i];
                        vetor[i] = vetor[part];
                        vetor[part] = aux;
                    }
                }
                if (divPart < 0)
                    divPart = ++part;
                fim = (part - 1);
                part = 0;
            }
            if(divPart> 0)
            {
                part = ++divPart;
                fim = vetor.Length;
                for (int i = part; i < fim; i++)
                {
                    if (vetor[i] < vetor[fim - 1])
                    {
                        part++;
                        int aux = vetor[i];
                        vetor[i] = vetor[part];
                        vetor[part] = aux;
                    }
                }
            }
            LerVetor(vetor);
        }
    }
}