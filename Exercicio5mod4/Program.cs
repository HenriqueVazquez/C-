using System.Globalization;

namespace Exercicio5mod4 {
    class Program {
        static void Main(string[] args) {
            int N, i, fat;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            fat = 1;
            for (i = 1; i <= N; i++) {
                fat = fat * i;
            }

            Console.WriteLine("FATORIAL = " + fat);
        }
    }
}