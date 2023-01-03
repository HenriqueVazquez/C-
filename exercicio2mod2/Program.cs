using System.Globalization;

namespace Validacao_de_notas {
    class Program {
        static void Main(string[] args) {
            int x;

            Console.Write("Digite um numero: ");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}



