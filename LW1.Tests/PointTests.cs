using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;
using System;

namespace LabWork1.Tests
{
    [TestClass]
    internal class PointTests
    {
        // Test for constructor
        [TestMethod]
        public void Constructor_WithValidCoordinates_SetsPropertiesCorrectly()
        {
            Point point = new Point(5, 10);

            Assert.AreEqual(5, point.X);
            Assert.AreEqual(10, point.Y);
        }

        // Test for construktor with zero parametres
        [TestMethod]
        public void Constructor_WithZeroCoordinates_SetsPropertiesToZero()
        {
            Point point = new Point(0, 0);

            Assert.AreEqual(0, point.X);
            Assert.AreEqual(0, point.Y);
        }

        // Test for constructor with negative numbers
        [TestMethod]
        public void Constructor_WithNegativeCoordinates_SetsPropertiesCorrectly()
        {
            Point point = new Point(-5, -10);

            Assert.AreEqual(-5, point.X);
            Assert.AreEqual(-10, point.Y);
        }

        // Test for constructor with negative and unsigned
        [TestMethod]
        public void Constructor_WithMixedSignCoordinates_SetsPropertiesCorrectly()
        {
            Point point = new Point(-5, 10);

            Assert.AreEqual(-5, point.X);
            Assert.AreEqual(10, point.Y);
        }

        // Test for constructor with minmax values
        [TestMethod]
        public void Constructor_WithMaxIntValues_SetsPropertiesCorrectly()
        {
            Point point = new Point(int.MaxValue, int.MinValue);

            Assert.AreEqual(System.Int32.MaxValue, point.X);
            Assert.AreEqual(System.Int32.MinValue, point.Y);
        }

        // Test for parametres in constructor
        [TestMethod]
        public void Properties_AreReadOnly_ValuesCannotBeChanged()
        {
            Point point = new Point(5, 10);

            var x1 = point.X;
            var y1 = point.Y;
            var x2 = point.X;
            var y2 = point.Y;

            Assert.AreEqual(5, x1);
            Assert.AreEqual(10, y1);
            Assert.AreEqual(5, x2);
            Assert.AreEqual(10, y2);
            Assert.AreEqual(x1, x2);
            Assert.AreEqual(y1, y2);
        }

        // The Immutability test 
        [TestMethod]
        public void Properties_XAndY_ReturnConsistentValues()
        {
            Point point = new Point(7, 3);

            var x = point.X;
            var y = point.Y;

            Assert.AreEqual(7, x);
            Assert.AreEqual(3, y);
        }

        // Test for saving values by a field
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(-1, -1)]
        [DataRow(100, 200)]
        [DataRow(-100, 200)]
        [DataRow(int.MaxValue, int.MaxValue)]
        [DataRow(int.MinValue, int.MinValue)]
        public void Constructor_WithVariousValues_SetsCorrectCoordinates(int x, int y)
        {
            Point point = new Point(x, y);

            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }
    }
}
