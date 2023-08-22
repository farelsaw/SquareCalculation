using SquareCalculation.Figures;
using Xunit;
using SquareCalculation;

namespace SquareСalculationTest
{
    public class SquareCalculationTests
    {
        [Fact]
        public void CirlceCalculateTest()
        {
            var radius = 2;

            var circle = FigureCalculation.CirlceCalculate(radius);

            Assert.NotNull(circle);
        }

        [Fact]
        public void CirlceCalculateWrongRadiusTest()
        {
            var radius = 0;

            Assert.Throws<ArgumentException>(() => FigureCalculation.CirlceCalculate(radius));
        }

        [Fact]
        public void TriangleCalculateTest()
        {
            var ribA = 2;
            var ribB = 2;
            var ribC = 2;

            var triangle = FigureCalculation.TriangleCalculate(ribA, ribB, ribC);

            Assert.NotNull(triangle);
        }

        [Fact]
        public void TriangleCalculateWrongRibTest()
        {
            var ribA = 2;
            var ribB = 2;
            var ribC = 0;

            Assert.Throws<ArgumentException>(() => FigureCalculation.TriangleCalculate(ribA, ribB, ribC));
        }

        [Fact]
        public void CircleFigureCalculateTest()
        {
            var radius = 1;

            var figure = FigureCalculation.FigureCalculate(radius);

            Assert.IsType<Cirlce>(figure);
        }

        [Fact]
        public void CircleWithSecondParameterCalculateTest()
        {
            var radius = 1;
            var b = 1;

            var figure = FigureCalculation.FigureCalculate(radius, b);

            Assert.IsType<Cirlce>(figure);
        }

        [Fact]
        public void TriangleFigureCalculateTest()
        {
            var ribA = 2;
            var ribB = 2;
            var ribC = 2;

            var figure = FigureCalculation.FigureCalculate(ribA, ribB, ribC);

            Assert.IsType<Triangle>(figure);
        }
    }
}
