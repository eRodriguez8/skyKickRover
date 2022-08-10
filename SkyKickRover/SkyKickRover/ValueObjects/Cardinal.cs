using SkyKickRover.Services.Interfaces;

namespace SkyKickRover.ValueObjects
{
    public class Cardinal
    {
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
        private readonly IRotationService _rotationService;
        private static List<Cardinal> List() => new() { North, South, East, West };

        private Cardinal(string value)
        {
            _value = value;
        }

        public Cardinal(string value, IRotationService rotationService) : this(List().FirstOrDefault(cardinal => cardinal._value == value).Value)
        {
            var state = List().FirstOrDefault(cardinal => cardinal._value == value);
            if (state is null) throw new Exception("Invalid cardinal received");
            _rotationService = rotationService;
        }

        public Cardinal RotateLeft()
        {
            return _rotationService.GetLeftRotationCardinal(new Cardinal(_value));
        }

        public Cardinal RotateRight()
        {
            return _rotationService.GetRightRotationCardinal(new Cardinal(_value));
        }
    }
}