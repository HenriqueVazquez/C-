using System.Globalization;

namespace AluguelCarros.Entities {
    internal class Invoice {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment {
            get { return Tax + BasicPayment; }
        }

        public override string ToString() {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CI)
                + "\nTax: "
                + Tax.ToString("F2", CI)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CI);
        }
    }
}
