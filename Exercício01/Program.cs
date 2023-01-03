using System;
using System.Globalization;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            int numero1 = 0, numero2 = 0, soma = 0;

            Console.Write("Digite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2;

            Console.WriteLine("Soma = " + soma);
        }
    }
}