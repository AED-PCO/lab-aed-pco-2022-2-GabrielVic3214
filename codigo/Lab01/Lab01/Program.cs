using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar;
            do
            {
                Console.Write("Escolha a atividade: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Atv1();
                        break;
                    case 2:
                        Atv2();
                        break;
                    case 3:
                        Atv3();
                        break;
                    case 4:
                        Atv4();
                        break;
                    case 5:
                        Atv5();
                        break;
                    case 6:
                        Atv6();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("\nDeseja continuar? S/N");
                string resp = Console.ReadLine();
                continuar = resp == "S" || resp == "s" ? true : false;
            } while (continuar);
        }
        static void Atv1()
        {
            for (int i = 1000; i <= 9999; i++)
            {
                char[] aux = i.ToString().ToCharArray();
                int a = int.Parse(aux[0] + "" + aux[1]);
                int b = int.Parse(aux[2] + "" + aux[3]);
                int result = a + b;
                result *= result;
                if (i == result)
                    Console.WriteLine(i);
            }
        }
        static void Atv2()
        {
            Console.WriteLine("Primo - 1");
            Console.WriteLine("Perfeito - 2");
            Console.Write("Opção: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.Write("Digite um número: ");
                    int num = int.Parse(Console.ReadLine());
                    bool primo = true;

                    for (int i = num - 1; i > 1; i--)
                    {
                        if (num % i == 0)
                            primo = false;
                    }
                    if (primo)
                        Console.WriteLine("É primo");
                    else
                        Console.WriteLine("Não é primo");
                    break;
                case 2:

                    int soma = 0;
                    for (int j = 1; j <= 1000; j++)
                    {
                        for (int i = 1; i < j; i++)
                        {
                            if (j % i == 0)
                                soma += i;
                        }
                        if (j == soma)
                        {
                            Console.WriteLine(j+" é perfeito");                       
                        }
                        soma = 0;
                    }
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        static void Atv3()
        {
            int[] a = new int[5] { 1, 2, 3, 4, 3 };
            int[] b = new int[5] { 10, 9, 3, 4, 6 };
            int[] c = new int[5];
            int indexC = 0;
            int[] d = new int[10];
            int indexD = 0;

            for (int i = 0; i < 5; i++)
            {
                if (a.Contains(b[i]))
                {
                    c[indexC] = b[i];
                    indexC++;
                }
                else
                {
                    d[indexD] = b[i];
                    indexD++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (!b.Contains(a[i]))
                {
                    d[indexD] = a[i];
                    indexD++;
                }
            }

            Array.Resize(ref c, indexC);
            Console.Write("Vetor C: ");
            foreach (int aux in c)
            {
                Console.Write(aux + " ");
            }
            Array.Resize(ref d, indexD);
            Console.Write("\nVetor D: ");
            foreach (int aux in d)
            {
                Console.Write(aux + " ");
            }
        }
        static void Atv4()
        {
            int[,] mat = new int[5, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {5, 6, 7},
                {6, 7, 8},
                {7, 8, 9},
            };
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += mat[i, j];
                }
            }
            Console.WriteLine("Resultado é: " + result);
        }
        static void Atv5()
        {
            Console.Write("Digite um número: ");
            int fat = int.Parse(Console.ReadLine());
            for (int i = fat - 1; i > 1; i--)
            {
                fat *= i;
            }
            Console.WriteLine("Fatorial é: " + fat);
        }
        static void Atv6()
        {
            Console.Write("Digite a base: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado: " + CalcularPotencia(x, y));
        }
        static double CalcularPotencia(int x, int y)
        {
            return Math.Pow(x, y);
        }
    }
}
