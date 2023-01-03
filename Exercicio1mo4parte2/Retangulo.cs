namespace Exercicio1mo4parte2 {
    internal class Retangulo {
        public double Altura, Largura;

        public double Area() {
            return Altura * Largura;           
        }

        public double Perimetro() {
            return 2 * (Largura + Altura);
        }
        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);

        }
    }
}
