using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            ConversorDeMoeda conv = new ConversorDeMoeda();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            double result = ConversorDeMoeda.ValorAPagar(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CI));
        }
    }
}