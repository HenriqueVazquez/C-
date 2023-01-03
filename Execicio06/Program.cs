using System;
using System.Globalization;

namespace Exercicio06 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double A, B, C, triangulo = 0, circulo = 0, trapezio = 0, quadrado = 0, retangulo = 0, pi = 3.14159;

            Console.WriteLine("Digite os valores de A, B e C na mesma linha separado por espaco: ");
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0].Replace(',', '.'), CI);
            B = double.Parse(vet[1].Replace(',', '.'), CI);
            C = double.Parse(vet[2].Replace(',', '.'), CI);

            triangulo = (A * C) / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = ((A + B) / 2.0) * C;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CI));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CI));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CI));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CI));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CI));
        }
    }
}