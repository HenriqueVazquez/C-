using System;
using System.Globalization;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {
            int codigo1 = 0, numeroPecas1 = 0, codigo2 = 0, numeroPecas2 = 0;
            double valorUnitario1 = 0, valorTotal1 = 0, valorUnitario2 = 0, valorTotal2 = 0, valorTotalCompra;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o código da peça, quantidade de peças e o valor unitario em uma unica linha separado por espaco: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            numeroPecas1 = int.Parse(vet1[1]);
            valorUnitario1 = double.Parse(vet1[2].Replace(',', '.'), CI);


            valorTotal1 = numeroPecas1 * valorUnitario1;

            Console.WriteLine("Digite o código da peça, quantidade de peças e o valor unitario em uma unica linha separado por espaco: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            numeroPecas2 = int.Parse(vet2[1]);
            valorUnitario2 = double.Parse(vet2[2].Replace(',', '.'), CI);


            valorTotal2 = numeroPecas2 * valorUnitario2;

            valorTotalCompra = valorTotal1 + valorTotal2;

            Console.WriteLine("Valor a pagar: R$ " + valorTotalCompra.ToString("F2", CI));
        }
    }
}