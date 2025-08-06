using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class exercicio01
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número positivo inteiro: ");
            n = int.Parse(Console.ReadLine());
            int num = 1;
            int linha = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
                linha++;
            }
        }
    }
}
