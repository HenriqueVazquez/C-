namespace Multiplos {
    class Program {
        static void Main(string[] args) {
            int x, y;

            Console.WriteLine("Digite dois numeros inteiros:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("Sao multiplos");
            }
            else {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}