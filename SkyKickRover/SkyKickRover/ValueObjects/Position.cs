using SkyKickRover.Enumeration;

namespace SkyKickRover.ValueObjects
{
    public class Position
    {
        private int _x;
        private int _y;

        public int X => _x;
        public int Y => _y;

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Position MoveFoward(CardinalsEnumeration value)
        {
            return value.Name switch
            {
                CardinalsEnumeration.NORTH => new Position(_x, _y + 1),
                CardinalsEnumeration.SOUTH => new Position(_x, _y - 1),
                CardinalsEnumeration.EAST => new Position(_x + 1, _y),
                CardinalsEnumeration.WEST => new Position(_x - 1, _y),
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            };
        }
    }
}