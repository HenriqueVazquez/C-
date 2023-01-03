using System.Globalization;

namespace Combustivel {
    class Program {
        static void Main(string[] args) {
            int Gasolina = 0, Alcool = 0, Diesel = 0, codigo = 0;

            do {

                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());

                while (codigo < 1 || codigo > 4) {
                    Console.Write("Informe um codigo valido (1, 2, 3) ou 4 para parar: ");
                    codigo = int.Parse(Console.ReadLine());
                }

                switch (codigo) {
                    case 1:
                        Alcool = Alcool + 1;
                        break;
                    case 2:
                        Gasolina = Gasolina + 1;
                        break;
                    case 3:
                        Diesel = Diesel + 1;
                        break;
                }

            } while (codigo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("1- Alcool: " + Alcool);
            Console.WriteLine("2- Gasolina: " + Gasolina);
            Console.WriteLine("3- Diesel: " + Diesel);
        }
    }
}