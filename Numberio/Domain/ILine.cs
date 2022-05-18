namespace Numberio.Domain
{
    public interface ILine
    {
        Direction Direction { get; }
        Point? Position { get; }
        int Size { get; }
        IReadOnlyList<Point> GetPositionPoints();
    }
}
