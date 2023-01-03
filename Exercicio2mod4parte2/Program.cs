using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + funcionario);
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            funcionario.AumentarSalario(porcent);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}