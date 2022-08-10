namespace SkyKickRover.Enumeration
{
    public class CardinalsEnumeration : Enumeration
    {
        public const string NORTH = "North";
        public const string SOUTH = "South";
        public const string EAST = "East";
        public const string WEST = "West";

        public static readonly CardinalsEnumeration North = new(1, NORTH);
        public static readonly CardinalsEnumeration South = new(2, SOUTH);
        public static readonly CardinalsEnumeration East = new(3, EAST);
        public static readonly CardinalsEnumeration West = new(4, WEST);

        public CardinalsEnumeration(int id, string name) : base(id, name)
        {
        }

        public static CardinalsEnumeration Left(CardinalsEnumeration value)
        {
            if (value.Name.Equals(North)) return West;
            else if (value.Name.Equals(West)) return South;
            else if (value.Name.Equals(South)) return East;
            else return North;
        }

        public static CardinalsEnumeration Right(CardinalsEnumeration value)
        {
            if (value.Name.Equals(North)) return East;
            else if (value.Name.Equals(East)) return South;
            else if (value.Name.Equals(South)) return West;
            else return North;
        }
    }
}