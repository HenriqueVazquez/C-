using System;
using System.Text.RegularExpressions;

namespace ExercicioAlugueis {
    class Program {
        static void Main(string[] args) {
            Regex rg = new(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            Estudante[] vect = new Estudante[10];
            int n = 0;
            string email;
            string nome;
            bool isBusy = false;

            do {
                Console.Write("Quantos quartos serão alugados? ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 10);

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                do {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                } while (nome == null || nome.Length < 3);

                do {
                    Console.Write("Email: ");
                    email = Console.ReadLine();
                } while (!rg.IsMatch(email));

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
              
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}