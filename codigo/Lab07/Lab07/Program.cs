using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escolha uma questão da prova: ");
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
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();
        }
        static void Atv1()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.Write("Digite uma frase: ");
            char[] frase = Console.ReadLine().ToCharArray();
            char[] arquivo = System.IO.File.ReadAllText(@"D:\PUC\Laboratório\2 - Semestre\Lab testes\frase.txt").ToCharArray();
            int iguais = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                for (int j = 0; j < arquivo.Length; j++)
                {
                    if (frase[i].Equals(arquivo[j]))
                    {
                        iguais++;
                    }
                }
            }
            int diferente = Math.Abs(arquivo.Length - iguais);
            Console.WriteLine("Iguais: {0} \nDifrentes: {1}", iguais, diferente);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + " segundos");
        }
        static void Atv2()
        {
            var sw = new Stopwatch();
            sw.Start();
            int v = funcRec1(6, 0);
            sw.Stop();
            Console.WriteLine("Tempo: {0} segundos\nValor: {1}", sw.ElapsedMilliseconds.ToString(), v);
        }
        static int funcRec1(int a, int quant)
        {
            if (a <= 1 || quant >= 3002)
            {
                return 0;
            }
            else
            {
                return funcRec1((a - 2) + 5, ++quant);
            }
        }
        static void Atv3()
        {
            var swt = new Stopwatch();
            swt.Start();
            char[] entrada = System.IO.File.ReadAllText(@"D:\PUC\Laboratório\2 - Semestre\Lab testes\entrada.txt").ToCharArray();
            char[] reverse = new char[entrada.Length];
            int indexAux = 0;
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                reverse[indexAux++] = entrada[i];
            }
            StreamWriter sw = new StreamWriter(@"D:\PUC\Laboratório\2 - Semestre\Lab testes\saida.txt");
            sw.WriteLine(new string(reverse));
            sw.Close();
            swt.Stop();
            Console.WriteLine(swt.ElapsedMilliseconds.ToString() + " segundos");
        }
        static void Atv4() { }
        static void Atv5()
        {
            var sw = new Stopwatch();
            sw.Start();
            int[] v = new int[7] { 10, 5, 7, 15, 22, 9, 30 };
            sw.Stop();
            Console.WriteLine("Retorno: " + funcao(6, v));
            Console.WriteLine(sw.ElapsedMilliseconds.ToString() + " segundos");
        }
        static int funcao(int a, int[] v)
        {
            if (a == 1)
                return v[0];
            else
            {
                int x = funcao(a - 1, v);
                if (x > v[a - 1])
                    return x;
                else
                    return v[a - 1];
            }
        }
    }
}