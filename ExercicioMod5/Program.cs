using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            char verificarSaldoInicial;
            double saldo;
            string titular = "";

            ContaBancaria c;
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CI);

            do {
                Console.Write("Nome do titular da conta : ");
                titular = Console.ReadLine();
            } while (titular?.Length <= 2);

            do {
                Console.Write("Haverá depósito inicial (s/n)? ");
                verificarSaldoInicial = char.Parse(Console.ReadLine());            }
            while ((verificarSaldoInicial != 'S' && verificarSaldoInicial != 's') && (verificarSaldoInicial != 'N' && verificarSaldoInicial != 'n'));

            if (verificarSaldoInicial == 's' || verificarSaldoInicial == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                 c = new ContaBancaria(numero, titular, saldo);
            }
            else {
                 c = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");           
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double qteDeposito = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            c.Deposito(qteDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque:  ");
            double qteSaque = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            c.Saque(qteSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}