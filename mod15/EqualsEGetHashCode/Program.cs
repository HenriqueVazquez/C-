using EqualsEGetHashCode.Entities;

internal class Program {
    private static void Main(string[] args) {
        Client a = new Client { Name = "Maria", Email = "maria@gmail"};

        Client b = new Client { Name = "Alex", Email = "Alex@gmail" };

        Console.WriteLine(a.Equals(b));

        Console.WriteLine(a.GetHashCode());

        Console.WriteLine(b.GetHashCode());
    }
}