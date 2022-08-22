using SkyKickRover.Enumeration;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Models
{
    public class Rover
    {
        private readonly Guid _guid;
        private Position _position;
        private Cardinal _cardinal;

        public Rover(Position position)
        {
            _guid = Guid.NewGuid();
            _position = position;
            _cardinal = Cardinal.North;
        }

        public Rover(Position position, Cardinal cardinal) : this(position)
        {
            _cardinal = cardinal;
        }

        public void Move(MovementsEnumeration movement)
        {
            switch(movement.Name)
            {
                case MovementsEnumeration.LEFT:
                    _cardinal = _cardinal.RotateLeft();
                    break;
                case MovementsEnumeration.RIGHT:
                    _cardinal = _cardinal.RotateRight();
                    break;
                case MovementsEnumeration.MOVE:
                    _position = _position.MoveFoward(_cardinal);
                    break;
            }
        }

       public string GetPosition()
        {
            return $"X: {_position.X}, Y: {_position.Y}, Cardinal: {_cardinal.Value}";
        }
    }
}