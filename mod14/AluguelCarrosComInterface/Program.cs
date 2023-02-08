using AluguelCarros.Entities;
using AluguelCarros.Services;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter rentaldata");
        Console.Write("Car model: ");
        string model = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);

        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);

        Console.Write("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

        Console.Write("Enter price per Day: ");
        double day = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

        CarRental carRental = new(start, finish, new Vehicle(model));

        RentalService rentalService = new(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("INVOICE: ");
        Console.WriteLine(carRental.Invoice);
    }
}