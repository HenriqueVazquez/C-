using Shapes.Model.Enums;

namespace Shapes.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
