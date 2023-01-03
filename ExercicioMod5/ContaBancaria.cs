using System.Globalization;
namespace Course {
    class ContaBancaria {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public int Numero { get; private set; }
        private string _titular;
        public double Saldo { get; private set; }
        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            _titular = titular;
            Deposito(0.0);
        }
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Deposito(depositoInicial);

        }
        public string Titular {
            get { return _titular; }
            set {
                if (value != null && value.Length > 1) {
                    _titular = value;
                }
            }
        }
        public double ValorDeSaldo {
            get { return Saldo; }
        }
        public void Deposito(double quantidade) {
            Saldo += quantidade;
        }
        public void Saque(double quantidade) {            
            Saldo -= quantidade + 5.0;
        }
        public override string ToString() {
            return
             "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", saldo: $ "
            + Saldo.ToString("F2", CI);


        }
    }
}