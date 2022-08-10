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

        public MovementsEnumeration(int id, string name) : base(id, name)
        {
        }
    }
}
