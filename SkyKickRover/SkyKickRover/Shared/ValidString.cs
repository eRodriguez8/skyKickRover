namespace SkyKickRover.Shared
{
    public class ValidString
    {
        private readonly string _value;

        public string Value => _value;

        public ValidString(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Invalid Value");

            _value = value;
        }
    }
}