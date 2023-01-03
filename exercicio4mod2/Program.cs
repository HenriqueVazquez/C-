using System.Globalization;

namespace Lanchonete {
    class Program {
        static void Main(string[] args) {
            int codigo, quantidade;
            double valorPago = 0;
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo > 0 && codigo <= 5) {
                Console.Write("Quantidade comprada: ");
                quantidade = int.Parse(Console.ReadLine());

                switch (codigo) {
                    case 1:
                        valorPago = 4.00 * quantidade;
                        break;
                    case 2:
                        valorPago = 4.50 * quantidade;
                        break;
                    case 3:
                        valorPago = 5.00 * quantidade;
                        break;
                    case 4:
                        valorPago = 2.00 * quantidade;
                        break;
                    case 5:
                        valorPago = 1.50 * quantidade;
                        break;

                }


                Console.WriteLine("Valor a pagar: R$ " + valorPago.ToString("F2", CI));
            } else {
                Console.WriteLine("Código invalido");
            }
            
           
        }
    }
}