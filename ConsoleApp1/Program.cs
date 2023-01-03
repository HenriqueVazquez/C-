using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            aluno.Nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            aluno.Nota3 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
            Console.WriteLine("NOTA FINAL = "
            + aluno.NotaFinal().ToString("F2", CI));

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }

            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CI)
                + " PONTOS");
            }
        }
    }
}