using Shapes.Interfaces;

namespace Shapes.Shapes
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
