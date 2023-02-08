using System.Globalization;

namespace ServicoPagamento.Entities {
    internal class Installment {

        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                 + " - "
                 + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
