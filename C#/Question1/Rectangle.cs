using System;
using System.Collections.Generic;
using System.Linq;

namespace SGIProgrammerEvaluation
{
    public class Rectangle
    {
        private readonly List<Point2D> coordinates = new List<Point2D>();


        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="rectangle">The other rectangle</param>
        public Rectangle(Rectangle rectangle)
        {
            coordinates.Clear();
            foreach (var coordinate in rectangle.coordinates)
            {
                coordinates.Add(new Point2D(coordinate.x, coordinate.y));
            }
        }

        /// <summary>
        /// Create a rectangle based on two vertices either on a verical line or one a horizontal line and its area (Deprecate)
        /// </summary>
        /// <param name="firstVertice">The first vertice of the rectangle</param>
        /// <param name="secondVertice">The second vertice of the rectangle</param>
        /// <param name="size">The area of the rectangle</param>
        /// <param name="extendInPositiveDirection">Does the rectangle expand on the positive direction (Right, Up)? </param>
        [Obsolete("This constructor is deprecated, use Rectangle(Point2D vertice, float _width, float _height) instead.")]
        public Rectangle(Point2D firstVertice, Point2D secondVertice, float size, bool extendInPositiveDirection = true)
        {
            if (OnTheSameLine(firstVertice, secondVertice))
            {
                coordinates.Add(firstVertice);
                coordinates.Add(secondVertice);

                Point2D thirdPoint = null;
                Point2D fourthPoint = null;

                if (OnTheSameHorizontalLine(firstVertice, secondVertice))
                {
                    float height = size / Math.Abs(firstVertice.x - secondVertice.x);
                    if (!extendInPositiveDirection)
                    {
                        height = -height;
                    }
                    thirdPoint = new Point2D(firstVertice.x, firstVertice.y + height);
                    fourthPoint = new Point2D(secondVertice.x, secondVertice.y + height);
                }
                else if (OnTheSameVerticalLine(firstVertice, secondVertice))
                {
                    float width = size/Math.Abs(firstVertice.y - secondVertice.y);
                    if (!extendInPositiveDirection)
                    {
                        width = -width;
                    }

                    thirdPoint = new Point2D(firstVertice.x + width, firstVertice.y);
                    fourthPoint = new Point2D(secondVertice.x + width, secondVertice.y);
                }

                coordinates.Add(thirdPoint);
                coordinates.Add(fourthPoint);
            }

            else
            {
                throw new ArgumentException("Two vertices should be on the same axis line");
            }
        }
        
        /// <summary>
        /// Draw a rectangle based on an origin and its width and height (For example, if its width is 2, and height is -2, origin is 0,
        /// then the rectangle will have 4 of its vertices at (0,0),(2,0),(2,-2) and (0,-2) 
        /// </summary>
        /// <param name="vertice">A vertice of the rectangle</param>
        /// <param name="_width">the horizontal extend of the horizontal value, if it is positive, it means that the rectangle extends in postive direction in x</param>
        /// <param name="_height">the vertical extend of the horizontal value, if it is positive, it means that the rectangle extends in postive direction in y</param>
        public Rectangle(Point2D vertice, float _width, float _height)
        {
            if (Math.Abs(_width) < 0.0001f || Math.Abs(_height) < 0.0001f)
            {
                throw new ArgumentException("The width or height of the rectangle can't be 0");
            }
            
            coordinates.Add(vertice);
            coordinates.Add(new Point2D(vertice.x, vertice.y+_height));
            coordinates.Add(new Point2D(vertice.x+_width, vertice.y));
            coordinates.Add(new Point2D(vertice.x+_width, vertice.y+_height));
        }

        public static bool Intersect(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.coordinates.Any(rectangle2.ContainPoint) || rectangle2.coordinates.Any(rectangle1.ContainPoint);
        }


        public override string ToString()
        {
            return
                $"Coordinates at {coordinates[0]}, {coordinates[1]}, {coordinates[2]}, {coordinates[3]}";
        }

        /// <summary>
        /// Since C# doesn't support assignment operator overload, here is a subtitute using clone to create a rectangle with the same data
        /// </summary>
        /// <returns></returns>
        public Rectangle Clone()
        {
            Rectangle copy = new Rectangle(this);
            return copy;
        }


        public bool ContainPoint(Point2D point)
        {
            float topBoundary = coordinates[0].y;
            float leftBoundary = coordinates[0].x;
            float bottomBoundary = coordinates[0].y;
            float rightBoundary = coordinates[0].x;

            foreach (var coordinate in coordinates)
            {
                if (coordinate.y > topBoundary)
                {
                    topBoundary = coordinate.y;
                }

                if (coordinate.x < leftBoundary)
                {
                    leftBoundary = coordinate.x;
                }

                if (coordinate.y < bottomBoundary)
                {
                    bottomBoundary = coordinate.y;
                }

                if (coordinate.x > rightBoundary)
                {
                    rightBoundary = coordinate.x;
                }
            }

            return point.x >= leftBoundary && point.x <= rightBoundary && point.y <= topBoundary &&
                   point.y >= bottomBoundary;
        }

        private static bool OnTheSameLine(Point2D firstPoint, Point2D secondPoint)
        {
            if (OnTheSameVerticalLine(firstPoint, secondPoint))
            {
                return true;
            }

            if (OnTheSameHorizontalLine(firstPoint, secondPoint))
            {
                return true;
            }

            return false;
        }

        private static bool OnTheSameHorizontalLine(Point2D firstPoint, Point2D secondPoint)
        {
            return Math.Abs(firstPoint.x - secondPoint.x) > 0.0001f && Math.Abs(firstPoint.y - secondPoint.y) < 0.0001f;
        }

        private static bool OnTheSameVerticalLine(Point2D firstPoint, Point2D secondPoint)
        {
            return Math.Abs(firstPoint.x - secondPoint.x) < 0.0001f && Math.Abs(firstPoint.y - secondPoint.y) > 0.0001f;
        }
    }
}