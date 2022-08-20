using FluentAssertions;
using Moq;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Tests.ValueObjects
{
    public class CardinalTest
    {
        private readonly Cardinal _cardinal;

        public CardinalTest()
        {
            _cardinal = new Cardinal(Cardinal.NORTH);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_left_is_call_then_should_return_cardinal_west()
        {
            var newCardinal = _cardinal.RotateLeft();

            newCardinal.Value
                .Should()
                .Be(Cardinal.WEST);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_right_is_call_then_should_return_cardinal_east()
        {
            var newCardinal = _cardinal.RotateRight();

            newCardinal.Value
                .Should()
                .Be(Cardinal.EAST);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_left_is_call_twice_then_should_return_cardinal_south()
        {
            var newCardinal = _cardinal.RotateLeft().RotateLeft();

            newCardinal.Value
                .Should()
                .Be(Cardinal.SOUTH);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_right_is_call_twice_then_should_return_cardinal_south()
        {
            var newCardinal = _cardinal.RotateRight().RotateRight();

            newCardinal.Value
                .Should()
                .Be(Cardinal.SOUTH);
        }
    }
}