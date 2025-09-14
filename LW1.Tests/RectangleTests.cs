using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;

namespace LabWork1.Tests
{
    [TestClass]
    public sealed class RectangleTests
    {
        // Test for constructor
        [TestMethod]
        public void Area_Calculation_IsCorrect()
        {
            Rectangle rectangle = new Rectangle(5, 10);

            var area = rectangle.Area;
            var perimeter = rectangle.Perimeter;

            Assert.AreEqual(50, area);
            Assert.AreEqual(30, perimeter);
        }

        // Tests for .area
        [TestMethod]
        [DataRow(5, 10, 50)]
        [DataRow(3, 7, 21)]
        [DataRow(2.5, 4, 10)]
        [DataRow(1.5, 2.5, 3.75)]
        [DataRow(0, 5, 0)]
        [DataRow(1, 1, 1)]
        public void Area_WithVariousSides_ReturnsCorrectResult(double sideA, double sideB, double expectedArea) 
        {
            Rectangle rectangle = new Rectangle(sideA, sideB);

            var actArea = rectangle.Area;

            Assert.AreEqual(expectedArea, actArea, 0.001, "Calculation for .area is correct");
        }

        // Tests for .perimeter
        [TestMethod]
        [DataRow(5, 10, 30)]
        [DataRow(3, 7, 20)]
        [DataRow(2.5, 4, 13)]
        [DataRow(1.5, 2.5, 8)]
        [DataRow(0, 5, 10)]
        [DataRow(1, 1, 4)]
        public void Period_WithVriousSides_ReturnsCorrectResult(double sideA, double sideB, double expectedPerimeter)
        {
            Rectangle rectangle = new Rectangle(sideA, sideB);

            var actPerimeter = rectangle.Perimeter;

            Assert.AreEqual(expectedPerimeter, actPerimeter, 0.001, "Calculation for .perimeter is correct.");
        }

        // Unique test for .area
        [TestMethod]
        public void Area_WithZeroSides_ReturnsZero()
        {
            Rectangle rectangle = new Rectangle(0, 0);

            var actArea = rectangle.Area;

            Assert.AreEqual(0, actArea);
        }

        // Unique test for .perimeter
        [TestMethod]
        public void Perimeter_WithZeroSides_ReturnsZero()
        {
            Rectangle rectangle = new Rectangle(0, 0);

            var actPerimeter = rectangle.Perimeter;

            Assert.AreEqual(0, actPerimeter);
        }

        // Test for .area with decimal sides
        [TestMethod]
        public void Area_WithDecimalSides_ReturnsCorrectDecimalResult()
        { 
            Rectangle rectangle = new Rectangle(2.5, 3.5);

            var actArea = rectangle.Area;
            
            Assert.AreEqual(8.75, actArea);
        }

        // Mathematical consistency tests
        [TestMethod]
        public void AreaAndPerimeter_WithSameSides_AreConsistent()
        {
            Rectangle rectangle = new Rectangle(5, 5);

            var area = rectangle.Area;
            var perimeter = rectangle.Perimeter;

            Assert.AreEqual(25, area);
            Assert.AreEqual(20, perimeter);
        }

        // Tests with big numbers
        [TestMethod]
        public void Area_WithLargeNumbers_ReturnsCorrectResult()
        {
            Rectangle rectangle = new Rectangle(1000000, 1000000);

            var actArea = rectangle.Area;

            Assert.AreEqual(1000000000000, actArea);
        }

        // Immunability tests
        [TestMethod]
        public void Properties_AreReadOnly_ValuesDontChange()
        {
            Rectangle rectangle = new Rectangle(5, 10);
            var initialArea = rectangle.Area;
            var initialPerimeter = rectangle.Perimeter;

            var area1 = rectangle.Area;
            var area2 = rectangle.Area;
            var perimeter1 = rectangle.Perimeter;
            var perimeter2 = rectangle.Perimeter;

            Assert.AreEqual(initialArea, area1);
            Assert.AreEqual(initialArea, area2);
            Assert.AreEqual(initialPerimeter, perimeter1);
            Assert.AreEqual(initialPerimeter, perimeter2);
        }

        // Additional tests for full coverage
        [TestMethod]
        [DataRow(1, 100, 100)]
        [DataRow(100, 1, 100)]
        [DataRow(0.1, 10, 1)]
        [DataRow(10, 0.1, 1)]
        public void Area_WithExtremeRatios_ReturnsCorrectResult(double sideA, double sideB, double expectedArea)
        {
            Rectangle rectangle = new Rectangle(sideA, sideB);

            var actArea = rectangle.Area;

            Assert.AreEqual(expectedArea, actArea, 0.001);
        }
    }
}
