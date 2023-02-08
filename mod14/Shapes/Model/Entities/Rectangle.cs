using System.Globalization;

namespace Shapes.Model.Entities {
    internal class Rectangle : AbstractShape {
        CultureInfo CI = CultureInfo.InvariantCulture;
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return "Circle color = "
               + Color
               + ", width = "
               + Width.ToString("F2", CI)
               + ", Height = "
               + Height.ToString("F2", CI)
               + ", area = "
               + Area().ToString("F2", CI);
        }
    }
}
