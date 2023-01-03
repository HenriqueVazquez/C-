using System.Globalization;

namespace Exercicio5mod4 {
    class Program {
        static void Main(string[] args) {
            int N, i;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            
            for (i = 1; i <= N ; i++) {
                if (N % i == 0) {
                    Console.WriteLine(i);
                }
            }

            
        }
    }
}