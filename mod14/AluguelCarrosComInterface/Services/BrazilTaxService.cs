namespace AluguelCarros.Services {
    internal class BrazilTaxService : ITaxServices {
        public double Tax(double amount) {
            if (amount <= 100) {
                return amount * 0.2;
            }
            else {
                return amount * 0.15;
            }
        }
    }
}
