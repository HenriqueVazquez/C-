namespace Course {
    class ConversorDeMoeda {
        public static double Iof = 0.06;

        public static double ValorAPagar(double CotacaoDollar,  double QuantidadeDollarComprado) {           
            return (CotacaoDollar * QuantidadeDollarComprado) + ((CotacaoDollar * QuantidadeDollarComprado) * Iof); 
        }       
    }
}