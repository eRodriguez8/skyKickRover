namespace SkyKickRover.Enumeration
{
    public class MovementsEnumeration : Enumeration
    {
        public const string LEFT = "L";
        public const string RIGHT = "R";
        public const string MOVE = "M";

        public static readonly MovementsEnumeration Left = new(1, LEFT);
        public static readonly MovementsEnumeration Right = new(2, RIGHT);
        public static readonly MovementsEnumeration Move = new(3, MOVE);

        private MovementsEnumeration(int id, string name) : base(id, name)
        {
        }

        public MovementsEnumeration(string value) : this(GetAll<MovementsEnumeration>().FirstOrDefault(movement => movement.Name == value).Id, value)
        {
            var state = GetAll<MovementsEnumeration>().FirstOrDefault(movement => movement.Name == value);
            if (state is null) throw new Exception("Invalid type received");
        }
    }
}
