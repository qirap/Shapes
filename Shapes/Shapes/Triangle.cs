using Shapes.Interfaces;

namespace Shapes.Shapes
{
    public class Triangle : IShape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get => _firstSide;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _firstSide = value;
            }
        }

        public double SecondSide
        {
            get => _secondSide;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _secondSide = value;
            }
        }

        public double ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _thirdSide = value;
            }
        }

        public double Perimeter
        {
            get => _firstSide + _secondSide + _thirdSide;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double CalculateArea()
        {
            double p = Perimeter / 2;
            double area = Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide));
            return area;
        }

        public bool IsRight()
        {
            double a = _firstSide,
                   b = _secondSide,
                   c = _thirdSide;

            if (a * a + b * b == c * c ||
                a * a + c * c == b * b ||
                b * b + c * c == a * a)
            {
                return true;
            }

            return false;
        }
    }
}
