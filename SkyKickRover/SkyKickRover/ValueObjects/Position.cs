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

        public void MoveFoward(CardinalsEnumeration value)
        {
            if (value.Name.Equals(CardinalsEnumeration.North.Name)) _y += 1;
            else if (value.Name.Equals(CardinalsEnumeration.South.Name)) _y -= 1;
            else if (value.Name.Equals(CardinalsEnumeration.East.Name)) _x += 1;
            else _x -= 1;
        }
    }
}