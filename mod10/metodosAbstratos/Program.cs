using metodosAbstratos.Entities;
using metodosAbstratos.Entities.Enums;
using System.Globalization;

internal class Program {
    private static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;

        List<Shape> list = new List<Shape>();

        Console.Write("Enter the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++) {
            Console.WriteLine($"Shape #{i} data:");
            Console.Write("Rectangle or Circle (r/c)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (type == 'r' || type == 'R') {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

                list.Add(new Rectangle(color, width, height));
            }
            else {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                list.Add(new Circle(radius, color));
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
        }

        foreach (Shape shape in list) {
            Console.WriteLine(shape.Area().ToString("F2", CI));
        }
    }
}