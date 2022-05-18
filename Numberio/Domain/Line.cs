namespace Numberio.Domain
{
    public class Line : ILine
    {
        public Point Symbol { get; set; }
        public Line(int size)
        {
            Size = size;
        }
        public int Size { get;}
        public Direction Direction { get; set; } = Direction.Horizontal;
        public Point? Position { get; set; } = null;
        public IReadOnlyList<Point> GetPositionPoints()
        {
            if (Position.HasValue)
            {
                var point = Position.Value;
                return Enumerable
                    .Range(0, Size)
                    .Select(delta => Direction == Direction.Horizontal
                    ? new Point(point.X + delta, point.Y)
                    : new Point(point.X, point.Y + delta))
                    .ToList();
            }
            return new Point[0];
        }

    }
}
