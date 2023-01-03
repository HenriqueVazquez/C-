using System.Globalization;

namespace Quadrante {
    class Program {
        static void Main(string[] args) {
            int x, y;
            string q;

            Console.Write("Digite os valores das coordenadas x:  ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite os valores das coordenadas y:  ");
            y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0) {
                if (x > 0 && y > 0) {
                    q = "Primeiro";
                }
                else if (x < 0 && y > 0) {
                    q = "Segundo";
                }
                else if (x < 0 && y < 0) {
                    q = "Terceiro";
                }
                else if (x > 0 && y < 0) {
                    q = "Quarto";
                }
                else if (x == 0 && y == 0) {
                    q = "Origem";
                }
                else if (x == 0) {
                    q = "Eixo y";
                }
                else {
                    q = "Eixo x";
                }

                Console.WriteLine("QUADRANTE " + q);
                Console.Write("Digite os valores das coordenadas x:  ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite os valores das coordenadas y:  ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Origem");
        }

    }
}