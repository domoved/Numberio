namespace Numberio.Domain
{
    public struct Point
    {            
        public int X { get;}
        public int Y { get;}
        public override string ToString() => $"({X}, {Y})";
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
