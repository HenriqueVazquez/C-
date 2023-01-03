using System.Globalization;
namespace Course {
    class Funcionario {
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString() {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CI);
        }
    }
}
