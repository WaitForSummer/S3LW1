namespace LabWork1
{
    public class Figure
    {
        public string Name { get; private set; }
        private Point[] points;
        public Figure(Point p1, Point p2, Point p3)
        {
            this.Name = "Triangle";
            this.points = new Point[] { p1, p2, p3 };
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            this.Name = "Quadrilateral";
            this.points = new Point[] { p1, p2, p3, p4 };
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            this.Name = "Pentagon";
            this.points = new Point[] { p1, p2, p3, p4, p5 };
        }
        /*
        public Figure(Point[] p) { 
            this.points = p;

            if (p.Length == 3)
            {
                this.Name = "Triangle";
            }
            else if (p.Length == 4)
            {
                this.Name = "Quadrilateral";
            }
            else if (p.Length == 5) {
                this.Name = "Pentagon";
            }
        }
        */
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point thisPoint = points[i];
                Point nextPoint = points[(i + 1) % points.Length];
                perimeter += LengthSide(thisPoint, nextPoint);
            }

            return perimeter;
        }
    }
}
