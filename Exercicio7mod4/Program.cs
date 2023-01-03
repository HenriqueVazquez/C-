using System.Globalization;

namespace Exercicio7mod4 {
    class Program {
        static void Main(string[] args) {
            int N, i;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());


            for (i = 1; i <= N; i++) {                
                    Console.WriteLine($"{ i } {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                
            }
        }
    }
}