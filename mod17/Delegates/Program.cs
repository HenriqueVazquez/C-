namespace Delegates {
    using Selegates.Services;

    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program {
        private static void Main(string[] args) {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = new(CalculationService.Sum);

            double result = op(a, b);
            Console.WriteLine(result);

        }
    }
}