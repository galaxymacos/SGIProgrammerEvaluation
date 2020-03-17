namespace SGIProgrammerEvaluation
{
    public class Point2D
    {
        public readonly float x;
        public readonly float y;

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}