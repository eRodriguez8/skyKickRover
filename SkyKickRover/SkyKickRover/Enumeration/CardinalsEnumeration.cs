namespace SkyKickRover.Enumeration
{
    public class CardinalsEnumeration : Enumeration
    {
        public static readonly CardinalsEnumeration North = new(1, "North");
        public static readonly CardinalsEnumeration South = new(2, "South");
        public static readonly CardinalsEnumeration East = new(3, "East");
        public static readonly CardinalsEnumeration West = new(4, "West");

        public CardinalsEnumeration(int id, string name) : base(id, name)
        {
        }

        public CardinalsEnumeration Left(CardinalsEnumeration value)
        {
            if (value.Name.Equals(North)) return West;
            else if (value.Name.Equals(West)) return South;
            else if (value.Name.Equals(South)) return East;
            else return North;
        }

        public CardinalsEnumeration Right(CardinalsEnumeration value)
        {
            if (value.Name.Equals(North)) return East;
            else if (value.Name.Equals(East)) return South;
            else if (value.Name.Equals(South)) return West;
            else return North;
        }
    }
}