using System;
using System.Globalization;

namespace Ecercicio5mod4 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;
            double x, y, divisao;


            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());


            for (i = 0; i < N; i++) {
                Console.Write("Entre com o numerador: ");
                x = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                Console.Write("Entre com o denominador: ");
                y = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                if (y == 0) {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else {
                    divisao = x / y;
                    Console.WriteLine("DIVISAO = " + divisao.ToString("F2", CI));
                }

            }
        }
    }
}