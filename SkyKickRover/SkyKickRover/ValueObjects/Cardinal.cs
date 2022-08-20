namespace SkyKickRover.ValueObjects
{
    public class Cardinal
    {
        private readonly Dictionary<string, string> _cardinalLeftPoints;
        private readonly Dictionary<string, string> _cardinalRightPoints;

        public const string NORTH = "N";
        public const string SOUTH = "S";
        public const string EAST = "E";
        public const string WEST = "W";

        public static readonly Cardinal North = new(NORTH);
        public static readonly Cardinal South = new(SOUTH);
        public static readonly Cardinal East = new(EAST);
        public static readonly Cardinal West = new(WEST);

        public string Value => _value;

        private readonly string _value;

        public Cardinal(string value)
        {
            _value = value;

            _cardinalLeftPoints = InitializeLeftPoints();
            _cardinalRightPoints = InitializeRightPoints();
        }

        public Cardinal RotateLeft()
        {
            return new Cardinal(GetLeftRotationCardinal(_value));
        }

        public Cardinal RotateRight()
        {
            return new Cardinal(GetRightRotationCardinal(_value));
        }

        public string GetLeftRotationCardinal(string cardinal)
        {
            return _cardinalLeftPoints[cardinal];
        }

        public string GetRightRotationCardinal(string cardinal)
        {
            return _cardinalRightPoints[cardinal];
        }

        private static Dictionary<string, string> InitializeLeftPoints()
        {
            return new Dictionary<string, string>
            {
                { NORTH, WEST },
                { SOUTH, EAST },
                { EAST, NORTH },
                { WEST, SOUTH }
            };
        }

        private static Dictionary<string, string> InitializeRightPoints()
        {
            return new Dictionary<string, string>
            {
                { NORTH, EAST },
                { SOUTH, WEST },
                { EAST, SOUTH },
                { WEST, NORTH }
            };
        }
    }
}