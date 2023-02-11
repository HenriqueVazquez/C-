
class Program {
    static void Main(string[] args) {

        HashSet<int> courseA = new();
        HashSet<int> courseB = new();
        HashSet<int> courseC = new();

        Console.Write("How many students for course A? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseA.Add(cod);
        }

        Console.Write("How many students for course B? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseB.Add(cod);
        }

        Console.Write("How many students for course C? ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            int cod = int.Parse(Console.ReadLine());
            courseC.Add(cod);
        }

        HashSet<int> all = new(courseA);
        all.UnionWith(courseB);
        all.UnionWith(courseC);

        Console.WriteLine();
        Console.WriteLine("Total students: " + all.Count);
    }
}
