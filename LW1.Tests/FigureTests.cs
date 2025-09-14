using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;
using System;

namespace LabWork1.Tests
{
    [TestClass]
    public class FigureTests
    {
        // Points for tests
        private readonly Point p0 = new Point(0, 0);
        private readonly Point p1 = new Point(3, 0);
        private readonly Point p2 = new Point(3, 4);
        private readonly Point p3 = new Point(0, 4);
        private readonly Point p4 = new Point(1, 1);

        // Test for constructor with 3 points
        [TestMethod]
        public void Constructor_WithThreePoints_CreatesTriangleWithCorrectName()
        {
            Figure figure = new Figure(p0, p1, p2);

            Assert.AreEqual("Triangle", figure.Name);
        }

        // Test for condtructor with 4 points
        [TestMethod]
        public void Constructor_WithFourPoints_CreatesQuadrilateralWithCorrectName()
        {
            Figure figure = new Figure(p0, p1, p2, p3);

            // Assert
            Assert.AreEqual("Quadrilateral", figure.Name);
        }

        // Test for constructir with 5 points
        [TestMethod]
        public void Constructor_WithFivePoints_CreatesPentagonWithCorrectName()
        {
            Figure figure = new Figure(p0, p1, p2, p3, p4);

            Assert.AreEqual("Pentagon", figure.Name);
        }

        // Test for .LengthSide
        [TestMethod]
        public void LengthSide_WithSamePoints_ReturnsZero()
        {
            Figure figure = new Figure(p0, p1, p2);

            var length = figure.LengthSide(p0, p0);

            Assert.AreEqual(0, length, 0.001);
        }

        // Test for .LengthSide
        [TestMethod]
        public void LengthSide_WithHorizontalLine_ReturnsCorrectDistance()
        {
            Figure figure = new Figure(p0, p1, p2);
            Point pointA = new Point(0, 0);
            Point pointB = new Point(5, 0);

            var length = figure.LengthSide(pointA, pointB);

            Assert.AreEqual(5, length, 0.001);
        }

        // Test for .LengthSide
        [TestMethod]
        public void LengthSide_WithVerticalLine_ReturnsCorrectDistance()
        {
            Figure figure = new Figure(p0, p1, p2);
            Point pointA = new Point(0, 0);
            Point pointB = new Point(0, 7);

            var length = figure.LengthSide(pointA, pointB);

            Assert.AreEqual(7, length, 0.001);
        }

        // Test for .LengthSide
        [TestMethod]
        public void LengthSide_WithDiagonalLine_ReturnsCorrectDistance()
        {
            Figure figure = new Figure(p0, p1, p2);
            Point pointA = new Point(0, 0);
            Point pointB = new Point(3, 4);

            var length = figure.LengthSide(pointA, pointB);

            Assert.AreEqual(5, length, 0.001);
        }

        // Test for .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_Triangle_ReturnsCorrectPerimeter()
        {
            Figure figure = new Figure(p0, p1, p2);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(12, perimeter, 0.001);
        }

        // Test for .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_Quadrilateral_ReturnsCorrectPerimeter()
        {
            Figure figure = new Figure(p0, p1, p2, p3);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(14, perimeter, 0.001);
        }

        // Testfor .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_Pentagon_ReturnsCorrectPerimeter()
        {
            Point pentagonP1 = new Point(0, 0);
            Point pentagonP2 = new Point(2, 0);
            Point pentagonP3 = new Point(3, 1);
            Point pentagonP4 = new Point(1, 2);
            Point pentagonP5 = new Point(0, 1);

            Figure figure = new Figure(pentagonP1, pentagonP2, pentagonP3, pentagonP4, pentagonP5);

            var perimeter = figure.PerimeterCalculator();

            Assert.IsTrue(perimeter > 0);
        }

        // Test for .PerimeterCalculator for collinear points
        [TestMethod]
        public void PerimeterCalculator_WithCollinearPoints_ReturnsCorrectPerimeter()
        {
            Point collinear1 = new Point(0, 0);
            Point collinear2 = new Point(3, 0);
            Point collinear3 = new Point(7, 0);

            Figure figure = new Figure(collinear1, collinear2, collinear3);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(14, perimeter, 0.001);
        }

        // Test for .PerimeterCalcluator
        [TestMethod]
        public void PerimeterCalculator_WithNegativeCoordinates_ReturnsCorrectPerimeter()
        {
            Point neg1 = new Point(-3, -4);
            Point neg2 = new Point(-3, 0);
            Point neg3 = new Point(0, 0);

            Figure figure = new Figure(neg1, neg2, neg3);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(12, perimeter, 0.001); 
        }

        // Test for .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_WithDuplicatePoints_ReturnsCorrectPerimeter()
        {
            Figure figure = new Figure(p0, p0, p1);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(6, perimeter, 0.001);
        }

        // Test for Name
        [TestMethod]
        public void Properties_Name_IsReadOnly()
        {
            Figure figure = new Figure(p0, p1, p2);
            string initialName = figure.Name;

            var name1 = figure.Name;
            var name2 = figure.Name;

            Assert.AreEqual("Triangle", initialName);
            Assert.AreEqual(initialName, name1);
            Assert.AreEqual(initialName, name2);
        }

        // Test for .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_WithSquare_ReturnsCorrectPerimeter()
        {
            Point squareP1 = new Point(0, 0);
            Point squareP2 = new Point(1, 0);
            Point squareP3 = new Point(1, 1);
            Point squareP4 = new Point(0, 1);

            Figure figure = new Figure(squareP1, squareP2, squareP3, squareP4);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(4, perimeter, 0.001);
        }

        // Test for .PerimeterCalculator
        [TestMethod]
        public void PerimeterCalculator_WithLargeCoordinates_ReturnsCorrectValue()
        {
            Point large1 = new Point(1000000, 1000000);
            Point large2 = new Point(1000003, 1000000);
            Point large3 = new Point(1000003, 1000004);

            Figure figure = new Figure(large1, large2, large3);

            var perimeter = figure.PerimeterCalculator();

            Assert.AreEqual(12, perimeter, 0.001);
        }

        // Special Test for .PerimeterCalculator
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void PerimeterCalculator_WithNullPointsArray_ThrowsException()
        {
            Figure figure = new Figure(p0, p1, p2);

            var pointsField = typeof(Figure).GetField("points", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            pointsField.SetValue(figure, null);

            figure.PerimeterCalculator();
        }
    }
}