using System;

namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();
        }
        static void Task1()
        {
            Console.WriteLine("Starting task1\n");
            Console.WriteLine($"Values for boolean (System.Boolean):\nfalse - true ({sizeof(System.Boolean)} Bytes)\n");
            Console.WriteLine($"Values for byte (System.Byte):\nfrom {System.Byte.MinValue} to {System.Byte.MaxValue} ({sizeof(System.Byte)} Bytes)\n");
            Console.WriteLine($"Values for sbyte (System.SByte):\nfrom {System.SByte.MinValue} to {System.SByte.MaxValue} ({sizeof(System.SByte)} Bytes)\n");
            Console.WriteLine($"Values for short (System.Int16):\nfrom {System.Int16.MinValue} to {System.Int16.MaxValue} ({sizeof(System.Int16)} Bytes)\n");
            Console.WriteLine($"Values for ushort (unsigned short, System.UInt16):\nfrom {System.UInt16.MinValue} to {System.UInt16.MaxValue} ({sizeof(System.UInt16)} Bytes)\n");
            Console.WriteLine($"Values for int (System.Int32):\nfrom {System.Int32.MinValue} to {System.Int32.MaxValue} ({sizeof(System.Int32)} Bytes)\n");
            Console.WriteLine($"Values for uint (unsigned int, System.UInt32):\nfrom {System.UInt32.MinValue} to {System.UInt32.MaxValue} ({sizeof(System.UInt32)} Bytes)\n");
            Console.WriteLine($"Values for long (System.Int64):\nfrom {System.Int64.MinValue} to {System.Int64.MaxValue} ({sizeof(System.Int64)} Bytes)\n");
            Console.WriteLine($"Values for ulong (unsigned long, System.UInt64):\nfrom {System.UInt64.MinValue} to {System.UInt64.MaxValue} ({sizeof(System.UInt64)} Bytes)\n");
            Console.WriteLine($"Values for float (System.Single):\nfrom {System.Single.MinValue} to {System.Single.MaxValue} ({sizeof(System.Single)} Bytes)\n");
            Console.WriteLine($"Values for double (System.Double):\nfrom {System.Double.MinValue} to {System.Double.MaxValue} ({sizeof(System.Double)} Bytes)\n");
            Console.WriteLine($"Values for decimal (System.Decimal):\nfrom {System.Decimal.MinValue} to {System.Decimal.MaxValue} ({sizeof(System.Decimal)} Bytes)\n");
            Console.WriteLine($"Values for char (Unicode, System.Char):\nfrom 1st element of Unicode to the last element ({sizeof(System.Char)} Bytes)\n");
            Console.WriteLine($"Values for string (Unicode, System.String):\nstring)\n");
            Console.WriteLine($"Values for object (System.Object):\nany type (4 Bytes for x32 and 8 Bytes for x64)\n");

            Console.WriteLine("\nPress any key to continue to Task 2...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Task2()
        {
            Console.WriteLine("\nTask 2\n");

            Console.Write("Enter a-side of rectangle: ");
            double sideA = getDouble();

            Console.Write("Enter b-side of rectangle: ");
            double sideB = getDouble();

            Rectangle rec = new Rectangle(sideA, sideB);

            double area = rec.Area;
            double per = rec.Perimeter;

            Console.WriteLine($"Area is {area}");
            Console.WriteLine($"Perimeter is {per}");

            Console.WriteLine("\nPress any key to Task 3...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Task3()
        {
            Console.WriteLine("\nTask3");

            // Another way to solve the task3
            /*
            Console.Write("Enter number of points: ");
            int numberOfPoints = Console.Read();

            Point[] points = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; i++) {

                Console.WriteLine($"Enter X and Y coordinates for {i+1} point: ");
                Console.Write("x = "); int x = Console.Read();
                Console.Write("y = "); int y = Console.Read();

                Point point = new Point(x, y);
                points[i] = point;
            
            }

            Figure fig = new Figure(points);
            */

            Point triPoint1 = new Point(0, 0);
            Point triPoint2 = new Point(0, 4);
            Point triPoint3 = new Point(3, 2);

            Figure triangle = new Figure(triPoint1, triPoint2, triPoint3);

            Point quadPoint1 = new Point(0, 0);
            Point quadPoint2 = new Point(5, 0);
            Point quadPoint3 = new Point(5, 5);
            Point quadPoint4 = new Point(0, 5);

            Figure quadrilateral = new Figure(quadPoint1, quadPoint2, quadPoint3, quadPoint4);

            Point penPoint1 = new Point(5, 0);
            Point penPoint2 = new Point(0, 6);
            Point penPoint3 = new Point(8, 9);
            Point penPoint4 = new Point(12, 7);
            Point penPoint5 = new Point(18, 0);

            Figure pentagon = new Figure(penPoint1, penPoint2, penPoint3, penPoint4, penPoint5);

            Console.WriteLine("\n=== Triangle ===");
            Console.WriteLine($"Figure: {triangle.Name}");
            Console.WriteLine($"Perimeter: {triangle.PerimeterCalculator()}");

            Console.WriteLine("\n=== Quadrilateral ===");
            Console.WriteLine($"Figure: {quadrilateral.Name}");
            Console.WriteLine($"Perimeter: {quadrilateral.PerimeterCalculator()}");

            Console.WriteLine("\n=== Pentagon ===");
            Console.WriteLine($"Figure: {pentagon.Name}");
            Console.WriteLine($"Perimeter: {pentagon.PerimeterCalculator()}");
        }

        static double getDouble()
        {
            // I know that using a while(true) type construct is very, very bad,
            // but in this case I had to use it to solve the problem of getting a double variable.
            while (true)
            {

                string input = Console.ReadLine();

                if (double.TryParse(input, out double result) && result > 0)
                {

                    return result;

                }

                Console.Write("Error. Please enter a new number: ");

            }
        }
    }
}