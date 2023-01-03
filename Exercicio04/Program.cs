using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int numeroFuncionario = 0, horasTrabalhadas = 0;
            double valorHora, salario;

            Console.Write("Digite o numero dofuncionario: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite as hora trabalhada: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da hora trabalhada: ");
            valorHora = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            salario = (double)(horasTrabalhadas * valorHora);

            Console.WriteLine("Number = " + numeroFuncionario);
            Console.WriteLine("Salary = U$ " + salario.ToString("F2", CI));
        }
    }
}