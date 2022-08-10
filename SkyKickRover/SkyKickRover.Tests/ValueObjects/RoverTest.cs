using FluentAssertions;
using SkyKickRover.Enumeration;
using SkyKickRover.Models;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Tests.ValueObjects
{
    public class RoverTest
    {
        private readonly Rover _rover;
        private readonly Rover _defaultCardinalRover;

        public RoverTest()
        {
            _rover = new Rover(new Position(10, 10), Cardinal.East);
            _defaultCardinalRover = new Rover(new Position(0, 0));
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_north_then_should_increase_y()
        {
            _rover.Move(MovementsEnumeration.Left);

            _rover.GetPosition()
                .Should()
                .Be($"X: {0}, Y: {0}, Cardinal: {Cardinal.East.Value}");
        }
    }
}
