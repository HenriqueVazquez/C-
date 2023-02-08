
using Shapes.Model.Enums;

namespace Shapes.Model.Entities {
     abstract class Shape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
