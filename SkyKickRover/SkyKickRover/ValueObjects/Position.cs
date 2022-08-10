namespace SkyKickRover.ValueObjects
{
    public class Position
    {
        private const int POSITIVE_LIMIT = 100;
        private const int NEGATIVE_LIMIT = -100;

        private readonly int _x;
        private readonly int _y;

        public int X => _x;
        public int Y => _y;

        public Position(int x, int y)
        {
            //var pos = CalculateLimit(x, y);
            _x = x;
            _y = y;
        }

        public Position MoveFoward(Cardinal value)
        {
            return value.Value switch
            {
                Cardinal.NORTH => new Position(_x, _y + 1),
                Cardinal.SOUTH => new Position(_x, _y - 1),
                Cardinal.EAST => new Position(_x + 1, _y),
                Cardinal.WEST => new Position(_x - 1, _y),
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            };
        }

        //private Position CalculateLimit(int x, int y)
        //{
        //    if(x > POSITIVE_LIMIT && y > POSITIVE_LIMIT)
        //}
    }
}