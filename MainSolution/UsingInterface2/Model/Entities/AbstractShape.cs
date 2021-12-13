using UsingInterface2.Model.Enums;

namespace UsingInterface2.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
