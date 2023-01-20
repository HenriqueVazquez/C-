using System;
namespace Course {
    class Program {
        static void Main(string[] args) {
            int negativeNumbers = 0;
            Console.WriteLine("Quantas linhas e colunas você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine("Negative Numbers: " + negativeNumbers);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}