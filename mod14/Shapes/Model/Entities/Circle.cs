using System.Globalization;

namespace Shapes.Model.Entities {
    internal class Circle :  AbstractShape {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Radius { get; set; }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString() {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CI)
                + ", area = "
                + Area().ToString("F2", CI);
        }
    }
}
