namespace DesafioContribuintes.Entities {
    internal class Individual : TaxPayer {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax() {
            double totalTax = 0.0;
            if(AnualIncome <  20000.00){
                totalTax = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else {
                totalTax = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            return totalTax;
        }
    }
}
