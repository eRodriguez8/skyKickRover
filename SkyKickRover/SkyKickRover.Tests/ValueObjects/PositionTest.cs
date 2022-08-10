using FluentAssertions;
using SkyKickRover.Enumeration;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Tests.ValueObjects
{
    public class PositionTest
    {
        private readonly Position _position;

        public PositionTest()
        {
            _position = new Position(0, 0);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_north_then_should_increase_y()
        {
            var y = _position.Y;

            _position.MoveFoward(CardinalsEnumeration.North);

            _position.Y
                .Should()
                .Be(y + 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_south_then_should_decrease_y()
        {
            var y = _position.Y;

            _position.MoveFoward(CardinalsEnumeration.South);

            _position.Y
                .Should()
                .Be(y - 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_east_then_should_increase_x()
        {
            var x = _position.X;

            _position.MoveFoward(CardinalsEnumeration.East);

            _position.X
                .Should()
                .Be(x + 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_west_then_should_decrease_x()
        {
            var x = _position.X;

            _position.MoveFoward(CardinalsEnumeration.West);

            _position.X
                .Should()
                .Be(x - 1);
        }
    }
}
