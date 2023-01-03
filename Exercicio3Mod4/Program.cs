using System.Globalization;

namespace Exercicio3mod4 {
    class Program {
        static void Main(string[] args) {
            int N, i;
            double nota1, nota2, nota3, media;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (i = 1; i <= N; i++) {
                Console.WriteLine("Digite tres numeros: ");
                nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                nota3 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                media = (double)((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / (2 + 3 + 5);

                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));


            }

        }
    }
}