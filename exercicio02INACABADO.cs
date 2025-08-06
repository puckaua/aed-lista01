using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    internal class exercicio02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos elementos terá em cada vetor:");
            int qtd = int.Parse(Console.ReadLine());
            int[] x = new int[qtd];
            int[] y = new int[qtd];


            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Digite o {i+1}º elemento do vetor x: ");
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o {i + 1}º elemento do vetor y: ");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Vetor x: [ ");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();

            Console.Write("Vetor y: [ ");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(y[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();

            Console.Write("Soma dos elementos: [ ");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(x[i] + y[i] + " ");
            }
            Console.Write("]");

            Console.WriteLine();

            Console.Write("Multiplicação dos elementos: [ ");

            for (int i = 0; i < y.Length; i++)
            {
                Console.Write(x[i] * y[i] + " ");
            }
            Console.Write("]");



        }
    }
}
