using SkyKickRover.Enumeration;

namespace SkyKickRover.ValueObjects
{
    public class Rover
    {
        private readonly Position _position;
        private CardinalsEnumeration _cardinal;

        public Rover(Position position)
        {
            _position = position;
            _cardinal = CardinalsEnumeration.North;
        }

        public void Move(MovementsEnumeration movements)
        {
            if(movements.Name.Equals(MovementsEnumeration.Left)) _cardinal = _cardinal.Left(_cardinal);
            else if(movements.Name.Equals(MovementsEnumeration.Right)) _cardinal = _cardinal.Right(_cardinal);
            else _position.MoveFoward(_cardinal);
        }
    }
}