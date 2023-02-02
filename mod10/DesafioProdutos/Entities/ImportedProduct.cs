using System.Globalization;

namespace DesafioProdutos.Entities {
    internal class ImportedProduct : Product {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;  
        }

        public override string PriceTag() {
             return Name
                + " $ "
                + TotalPrice().ToString("F2", CI)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CI)
                + ")";

        }
    }
}
