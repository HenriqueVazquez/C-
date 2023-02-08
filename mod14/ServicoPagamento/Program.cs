using ServicoPagamento;
using ServicoPagamento.Entities;
using ServicoPagamento.Services;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");          
        DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CI);
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
        Console.WriteLine("Enter number of installments: ");
        int months = int.Parse(Console.ReadLine());

        Contract myContract = new(number, contractDate, contractValue);

        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(myContract, months);

        Console.WriteLine("Installments:");
        foreach (Installment installment in myContract.Installments) {
            Console.WriteLine(installment);
        }
    }
}
