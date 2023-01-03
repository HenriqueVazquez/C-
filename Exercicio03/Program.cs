using System;
using System.Globalization;

namespace Exercicio03 {
    class Program {
        static void Main(string[] args) {
            int A = 0, B = 0, C = 0, D = 0, diferenca = 0;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}