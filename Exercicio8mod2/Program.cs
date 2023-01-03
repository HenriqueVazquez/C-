using System.Globalization;

namespace Exercicio8mod2 {
    class Program {
        static void Main(string[] args) {
            double salario,  imposto = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Digite o salario: ");
            salario = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (salario >= 0 && salario <= 2000) {
                imposto = 0;
            }
            else if
            (salario > 2000 && salario <= 3000) {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario > 3000 && salario <= 4500) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else if (salario > 4500) {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000 * 0.08;  
            }

            if (imposto == 0) {
                Console.WriteLine("Isento");
            }
            else {

                Console.WriteLine("Imposto = R$ " + imposto.ToString("F2", CI));
            }


          


        }


    }
}

