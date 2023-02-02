using DesafioProdutos.Entities;
using System;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;

        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Common, used or imported (c/u/i)? ");
            char type = char.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

            if (type == 'u' || type == 'U') {
                Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                list.Add(new UsedProduct(name, price, manufactureDate));
            }
            else if (type == 'i' || type == 'I') {
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                list.Add(new ImportedProduct(name, price, customsFee));
            }
            else {
                list.Add(new Product(name, price));
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");
        foreach (Product product in list) {
            Console.WriteLine(product.PriceTag());
        }
    }
}