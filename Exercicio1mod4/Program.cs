using System.Globalization;

namespace Exercicio1mod4 {
    class Program {
        static void Main(string[] args) {
            int x, i;

            do {
                Console.Write("Digite o valor de X ou 0 para finalizar: ");
                x = int.Parse(Console.ReadLine());
                for (i = 1; i <= x; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }
            while (x != 0);
        }
    }
}