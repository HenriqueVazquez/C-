internal class Program {
    private static void Main(string[] args) {
        DateTime dt = new DateTime(2023, 02, 10, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
}