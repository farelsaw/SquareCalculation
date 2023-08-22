using SquareCalculation.Figures;

namespace SquareCalculation
{
    public class FigureCalculation
    {
        private const double _validationValue = 1e-7;
        public static Cirlce CirlceCalculate(double radius)
        {
            if (radius - Cirlce.MinimalRadius < _validationValue) throw new ArgumentException("Неправильный радиус круга, параметр ", nameof(radius));

            return new Cirlce(radius);
        }

        public static Triangle TriangleCalculate(double ribA, double ribB, double ribC)
        {
            var expMessage = "Неправильное значение ребра, параметр ";

            if (ribA < _validationValue)
                throw new ArgumentException(expMessage, nameof(ribA));
            if (ribB < _validationValue)
                throw new ArgumentException(expMessage, nameof(ribB));
            if (ribC < _validationValue)
                throw new ArgumentException(expMessage, nameof(ribC));

            return new Triangle(ribA, ribB, ribC);
        }

        public static IFigure FigureCalculate(double a, double b = 0, double c = 0)
        {
            if (b == 0 || c == 0)
                return CirlceCalculate(a);
            else
                return TriangleCalculate(a, b, c);
        }
    }
}
