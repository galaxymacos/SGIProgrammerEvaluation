using System;

namespace SGIProgrammerEvaluation
{
    internal static class Tester
    {
        public static void Main(string[] args)
        {
            // Old way
            // Rectangle rectangle1 = new Rectangle(new Point2D(0, 0), new Point2D(0, -2), 2, false);
            
            // Modified Way
            Rectangle rectangle1 = new Rectangle(new Point2D(0, 0),-1,-2);
            
            Console.WriteLine($"Rectangle1 coordinates: "+rectangle1);

            Console.WriteLine("---------------Test ContainPoint method");
            Console.WriteLine($"Does rectangle1 contain the point {new Point2D(-1, -1)}? {rectangle1.ContainPoint(new Point2D(-1, -1))}");
            Console.WriteLine($"Does rectangle1 contain the point {new Point2D(3, 1)}? {rectangle1.ContainPoint(new Point2D(3, 1))}");
            Console.WriteLine();
            
            // Old way
            // Rectangle rectangle2 = new Rectangle(new Point2D(1, 1), new Point2D(1, 2), 2);
            
            // Modified
            Rectangle rectangle2 = new Rectangle(new Point2D(1, 1), -2.5f,-2.5f);
            Console.WriteLine("---------------Test Intersect method");
            Console.WriteLine($"Rectangle2 coordinates: "+rectangle2);
            Console.WriteLine($"Does rectangle1 overlaps with rectangle2? "+Rectangle.Intersect(rectangle1, rectangle2));

            Console.WriteLine("\n-------------Testing copy constructor");
            var rectangle1Copy = new Rectangle(rectangle1);
            Console.WriteLine($"Rectangle 1: {rectangle1}");
            Console.WriteLine($"Rectangle copy: {rectangle1Copy}");
            Console.WriteLine($"Is rectangle copy the same object as rectangle 1? {rectangle1Copy.Equals(rectangle1)}");

            Console.WriteLine("\n-------------Testing clone (Substitution to assignment operator overload)");
            Console.WriteLine($"Rectangle 1: {rectangle1}");
            var rectangle1Clone = rectangle1.Clone();
            Console.WriteLine($"Rectangle clone: {rectangle1Clone}");
            Console.WriteLine($"Is rectangle clone the same object as rectangle 1? {rectangle1Clone.Equals(rectangle1)}");
        }
    }
}