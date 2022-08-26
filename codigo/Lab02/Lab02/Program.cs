using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
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
            Console.Write("Digite um número: ");
            int fat = int.Parse(Console.ReadLine());
            Console.WriteLine(Fatorial(fat));
        }
        static int Fatorial(int num)
        {
            if (num == 1)
                return num;
            return num*= Fatorial(num - 1);
        }
        static void Atv2()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(MultSoma(num1,num2));
        }
        static int MultSoma(int num,int quant)
        {
            bool negativo = false;
            if(quant < 0)
            {
                negativo = true;
                quant *= -1;
            }
            if(quant == 1)
                return num;
            
            int result = num + MultSoma(num, quant - 1);
            if (negativo)
                return -result;
            else
                return result;

        }
        static void Atv3()
        {
            Console.Write("Digite a base: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Potencia(num1, num2));
        }
        static int Potencia(int num, int expo)
        {
            if (expo == 1)
                return num;
            return num * Potencia(num, expo - 1);
        }
        static void Atv4()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();
            Console.Write("Qual letra quer procurar? ");
            string pes = Console.ReadLine();
            Console.WriteLine(LetraFrase(frase, pes));
        }
        static int LetraFrase(string frase, string letra)
        {
            if (frase.Length == 0)
                return 0;

            int quant = 0;
            if (frase.Substring(frase.Length - 1) == letra)
                quant++;
            frase = frase.Remove(frase.Length-1);
            quant += LetraFrase(frase, letra);
            return quant;
        }
        static void Atv5()
        {
            int[] somaV = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(VetorPar(somaV));
        }
        static int VetorPar(int[] soma)
        {
            if (soma.Length == 0)
                return 0;

            int result = 0;
            if (soma[soma.Length - 1] % 2 == 0)
                result = soma[soma.Length - 1];

            Array.Resize(ref soma, soma.Length - 1);
            return result + VetorPar(soma);

        }
        static void Atv6()
        {
        }
        static void Fibonachi()
        {
        }
    }
}
