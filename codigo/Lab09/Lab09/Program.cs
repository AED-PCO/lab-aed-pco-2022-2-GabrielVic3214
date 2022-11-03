namespace Lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Pilha para Pilha\n2: Fila para Reverse\n3: Fila para Fila+Reverse");
            Console.Write("Escolha uma atividade: ");
            int opAtv = int.Parse(Console.ReadLine());
            switch (opAtv)
            {
                case 1: Pilha(); break;
                case 2: Fila(); break;
                case 3: Lista(); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
        static void Pilha()
        {      
            int[] pilhaA = new int[5];
            int[] pilhaB = new int[5];
            int refA = 3, refB = 0;
            PreencherArray(ref pilhaA, refA);

            Console.Write("Pilha A: "); LerVetor(pilhaA);
            Console.Write("\nPilha B: "); LerVetor(pilhaB);
            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("\n\n1: Transferir para A -> B\n2: Transferir para B -> A\n3: Sair");
                op = int.Parse(Console.ReadLine());
                if(op == 1)
                {
                    for(; refB < refA; refB++)
                    {
                        pilhaB[refB] = pilhaA[refB];
                    }
                    refA = 0;
                }
                else if (op == 2)
                {
                    for (; refA < refB; refA++)
                    {
                        pilhaA[refA] = pilhaB[refA];
                    }
                    refB = 0;
                }
                Console.Write("Pilha A: "); LerVetor(pilhaA);
                Console.Write("\nPilha B: "); LerVetor(pilhaB);
            }
        }
        static void Fila()
        {
            int[] filaA = new int[5];
            int[] filaB = new int[5];
            int refA = 0, refB = 4;
            PreencherArray(ref filaB, refB);

            Console.Write("Pilha A: "); LerVetor(filaA);
            Console.Write("\nPilha B: "); LerVetor(filaB);
            int op = 0;
            while (op != 3)
            {
                Console.WriteLine("\n\n1: Transferir para A -> B\n2: Transferir para B -> A\n3: Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    for (refA--; refA >= 0; refA--)
                    {
                        filaB[refB++] = filaA[refA];
                    }
                }
                else if (op == 2)
                {
                    for (refB--; refB >= 0; refB--)
                    {
                        filaA[refA++] = filaB[refB];
                    }
                }
                Console.Write("Pilha A: "); LerVetor(filaA);
                Console.Write("\nPilha B: "); LerVetor(filaB);
            }
        }
        static void Lista()
        {
            int[] listaA = new int[5];
            int[] listaB = new int[5];
            int[] listaC = new int[listaA.Length + listaB.Length];
            int refA = 3, refB = 0, refC = 0;
            PreencherArray(ref listaA, refA);
            Console.Write("\nLista A: "); LerVetor(listaA);
            for (int i = refA-1; i >= 0; i--)
            {
                listaB[refB++] = listaA[i];
            }
            Console.Write("\nLista B: "); LerVetor(listaB);
            for(int i = 0; i < refA; i++)
            {
                listaC[refC++] = listaA[i];
            }
            for(int i = 0; i < refB; i++)
            {
                listaC[refC++] = listaB[i];
            }
            Console.Write("\nLista C: "); LerVetor(listaC);
        }
        static void PreencherArray(ref int[] a, int maxLength)
        {
            Random r = new Random();
            for (int i = 0; i< maxLength; i++)
            {
                a[i] = r.Next(1, 20);
            }
        }
        static void LerVetor(int[] vetor)
        {
            Console.Write("Vetor: ");
            foreach (int v in vetor)
            {
                Console.Write(v + " ");
            }
        }
    }
}