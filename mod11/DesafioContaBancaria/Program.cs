using DesafioContaBancaria.Entities;
using DesafioContaBancaria.Entities.Exceptions;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        try {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Console.WriteLine("Enter Account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            Account account = new Account(number,holder, balance, withdrawLimit);
            Console.WriteLine();

            Console.Write("Enter amout for withdraw: ");
            double amount = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            account.Withdraw(amount);
            Console.WriteLine(account);
        }

        catch (DomainException error) {
            Console.WriteLine("Withdraw error: " + error.Message);
        }
        catch (FormatException error) {
            Console.WriteLine("Format error: " + error.Message);
        }
        catch (Exception error) {
            Console.WriteLine("Unexpected error: " + error.Message);
        }
    }

}