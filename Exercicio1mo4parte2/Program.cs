using Exercicio1mo4parte2;
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.Write("Digite a largura: ");
            ret.Largura = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.Write("Digite a altura: ");
            ret.Altura = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CI));
        }
    }
}