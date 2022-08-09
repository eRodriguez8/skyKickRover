namespace SkyKickRover.Shared
{
    public class NonNegativeInteger
    {
        private const int MIN_VALUE = 0;
        private readonly int _value;

        public int Value => _value;

        public NonNegativeInteger(int value)
        {
            if (value < MIN_VALUE) throw new ArgumentOutOfRangeException("Invalid Value");

            _value = value;
        }
    }
}