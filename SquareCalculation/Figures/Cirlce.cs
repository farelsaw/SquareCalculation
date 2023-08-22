namespace SquareCalculation.Figures
{
    public class Cirlce: IFigure
    {
        public Cirlce() { }

        public Cirlce(double radius)
        {
            Radius = radius;

            Square = Math.Pow(radius, 2) * Math.PI;
        }

        public const double MinimalRadius = 1e-6;

        public double Square { get; }
        public double Radius { get; }
    }
}
