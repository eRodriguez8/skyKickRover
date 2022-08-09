namespace SkyKickRover.Enumeration
{
    public class MovementsEnumeration : Enumeration
    {
        public static readonly MovementsEnumeration Left = new(1, "L");
        public static readonly MovementsEnumeration Right = new(2, "R");
        public static readonly MovementsEnumeration Move = new(3, "M");

        public MovementsEnumeration(int id, string name) : base(id, name)
        {
        }
    }
}
