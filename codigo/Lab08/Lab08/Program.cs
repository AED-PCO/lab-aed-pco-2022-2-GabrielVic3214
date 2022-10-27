namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Fila\n2: Lista\n3: Pilha");
            Console.Write("Escolha uma atividade: ");
            int opAtv = int.Parse(Console.ReadLine());
            switch (opAtv)
            {
                case 1: Fila(); break;
                case 2: Lista(); break;
                case 3: Pilha(); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
        static void Fila() 
        {
            int op = 0;
            int[] fila = new int[5];
            int refV = 0;

            while (op != 3)
            {
                Console.WriteLine("1: Inserir\n2: Retirar\n3: Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    if (refV < fila.Length)
                    {
                        Random r = new Random();
                        fila[refV++] = r.Next(1, 20);
                        LerVetor(fila);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel inserir");
                    }
                }
                else if (op == 2)
                {
                    if (refV > 0)
                    {
                        for(int i = 1; i < refV; i++)
                        {
                            fila[i - 1] = fila[i];
                        }
                        refV--;
                        LerVetor(fila);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel retirar");
                    }
                }
                Console.WriteLine("Ref: " + refV);
            }
        }
        static void Lista() 
        {
            int op = 0;
            int[] lista = new int[5];
            int refV = 0;

            while (op != 3)
            {
                Console.WriteLine("1: Inserir\n2: Retirar\n3: Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                }
                else if (op == 2)
                {                    
                }
                LerVetor(lista);
                Console.WriteLine("Ref: " + refV);
            }
        }
        static void Pilha()
        {
            int op = 0;
            int[] pilha = new int[5];
            int refV = 0;

            while (op != 3)
            {
                Console.WriteLine("1: Inserir\n2: Retirar\n3: Sair");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    if (refV < pilha.Length)
                    {
                        Random r = new Random();
                        pilha[refV++] = r.Next(1, 20);
                    }
                    else
                    {
                        Console.WriteLine("Não é possivel inserir");
                    }
                }
                else if (op == 2)
                {
                    if (refV > 0)
                        refV--;
                    else
                        Console.WriteLine("Não é possivel retirar");
                }
                LerVetor(pilha);
                Console.WriteLine("Ref: " + refV);
            }
        }
        static void LerVetor(int[] vetor)
        {
            Console.Write("Vetor: ");
            foreach (int v in vetor)
            {
                Console.Write(v+" ");
            }
        }
    }
}