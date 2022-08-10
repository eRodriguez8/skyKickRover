using FluentAssertions;
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
            var response = _position.MoveFoward(Cardinal.North);

            response.Y
                .Should()
                .Be(_position.Y + 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_south_then_should_decrease_y()
        {
            var response = _position.MoveFoward(Cardinal.South);

            response.Y
                .Should()
                .Be(_position.Y - 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_east_then_should_increase_x()
        {
            var response = _position.MoveFoward(Cardinal.East);

            response.X
                .Should()
                .Be(_position.X + 1);
        }

        [Fact]
        [Trait("Categories", "Position")]
        public void Given_a_position_when_move_foward_recive_cardinal_west_then_should_decrease_x()
        {
            var response = _position.MoveFoward(Cardinal.West);

            response.X
                .Should()
                .Be(_position.X - 1);
        }
    }
}
