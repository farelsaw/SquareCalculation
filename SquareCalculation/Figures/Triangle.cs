namespace SquareCalculation.Figures
{
    public class Triangle: IFigure
    {
        public Triangle() { }

        public Triangle(double ribA, double ribB, double ribC)
        {
            var perimeter = (ribA + ribB + ribC) / 2;

            Square = Math.Sqrt(perimeter * (perimeter - 2) * (perimeter - 2) * (perimeter - 2));
            RibA = ribA;
            RibB = ribB;
            RibC = ribC;

            if ((ribA * ribA + ribB * ribB == ribC * ribC) || (ribA * ribA + ribC * ribC == ribB * ribB) || (ribC * ribC + ribB * ribB == ribA * ribA))
                IsRightTriangle = true;
            else IsRightTriangle = false;
        }

        public double Square { get; }
        public double RibA { get; }
        public double RibB { get; }
        public double RibC { get; }
        public bool IsRightTriangle { get; }
    }
}
