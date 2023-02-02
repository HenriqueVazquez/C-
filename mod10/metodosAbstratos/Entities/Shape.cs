
using metodosAbstratos.Entities.Enums;

namespace metodosAbstratos.Entities {
    abstract class Shape {
        public Color Color { get; set; }
               

            public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
