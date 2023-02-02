using DesafioContribuintes.Entities;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;
        List<TaxPayer> list = new List<TaxPayer>();

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Tax payer #{i} data:");

            Console.Write("Individual or company (i/c)? ");
            char type = Char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if(type == 'i' || type == 'I') {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                list.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());

                list.Add(new Company(name, anualIncome, numberOfEmployees));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("TAXES PAID:");
        double totalTax = 0.0;
        foreach (TaxPayer taxPayer in list) {
            Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CI));
            totalTax += taxPayer.Tax();
        }
        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $" + totalTax.ToString("F2", CI));
    }
}