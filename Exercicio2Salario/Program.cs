using Exercicio2Salario;
using System.Globalization;

namespace Mais_velho {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();
            Funcionario f2 =  new Funcionario();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
           
           
                Console.WriteLine("Salário médio = " + ((f2.salario + f1.salario) / 2.00 ).ToString("F2", CI));
           
        }
    }
}