namespace LabWork1
{
    public class Rectangle
    {
        private double sideA, sideB;

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        private double CalculateArea() { return sideA * sideB; }
        private double CalculatePerimeter() { return 2 * (sideA + sideB); }

        public double Area
        {
            get { return CalculateArea(); }
        }
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
}
