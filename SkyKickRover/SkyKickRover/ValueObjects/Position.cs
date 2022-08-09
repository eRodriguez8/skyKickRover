using SkyKickRover.Enumeration;
using SkyKickRover.Shared;

namespace SkyKickRover.ValueObjects
{
    public class Position
    {
        private NonNegativeInteger _x;
        private NonNegativeInteger _y;

        public string X => _x.Value.ToString();
        public string Y => _y.Value.ToString();

        public Position(NonNegativeInteger x, NonNegativeInteger y)
        {
            _x = x;
            _y = y;
        }

        public void MoveFoward(CardinalsEnumeration value)
        {
            if (value.Name.Equals(CardinalsEnumeration.North)) _y = new NonNegativeInteger(_y.Value + 1);
            else if (value.Name.Equals(CardinalsEnumeration.South)) _y = new NonNegativeInteger(_y.Value - 1);
            else if (value.Name.Equals(CardinalsEnumeration.East)) _x = new NonNegativeInteger(_x.Value + 1);
            else _x = new NonNegativeInteger(_x.Value - 1);
        }
    }
}