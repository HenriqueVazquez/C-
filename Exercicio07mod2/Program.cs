using System.Globalization;

namespace Exercicio07mod2 {
    class Program {
        static void Main(string[] args) {
            double X, Y;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Valor de X: ");
            X = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Valor de Y: ");
            Y = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (X > 0 && Y > 0) {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0) {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0) {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0) {
                Console.WriteLine("Q4");
            }
            else if (X == 0 && Y == 0) {
                Console.WriteLine("Origem");
            }
            else if (X == 0) {
                Console.WriteLine("Eixo Y");
            }
            else {
                Console.WriteLine("Eixo X");
            }
        }
    }
}