using FluentAssertions;
using Moq;
using SkyKickRover.Services.Interfaces;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Tests.ValueObjects
{
    public class CardinalTest
    {
        private readonly Mock<IRotationService> _rotationService;

        private readonly Cardinal _cardinal;

        public CardinalTest()
        {
            _rotationService = new Mock<IRotationService>();

            _cardinal = new Cardinal(Cardinal.NORTH, _rotationService.Object);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_left_is_call_then_should_return_cardinal_west()
        {
            _rotationService.Setup(s => s.GetLeftRotationCardinal(It.IsAny<Cardinal>())).Returns(Cardinal.West);

            var newCardinal = _cardinal.RotateLeft();

            newCardinal.Value
                .Should()
                .Be(Cardinal.WEST);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_right_is_call_then_should_return_cardinal_east()
        {
            _rotationService.Setup(s => s.GetRightRotationCardinal(It.IsAny<Cardinal>())).Returns(Cardinal.East);

            var newCardinal = _cardinal.RotateRight();

            newCardinal.Value
                .Should()
                .Be(Cardinal.EAST);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_left_is_call_twice_then_should_return_cardinal_south()
        {
            _rotationService.Setup(s => s.GetLeftRotationCardinal(It.IsAny<Cardinal>())).Returns(Cardinal.South);

            var newCardinal = _cardinal.RotateLeft();
            var newCardinal2 = newCardinal.RotateLeft();

            newCardinal.Value
                .Should()
                .Be(Cardinal.SOUTH);
        }

        [Fact]
        [Trait("Categories", "Cardinal")]
        public void Given_a_cardinal_when_rotate_right_is_call_twice_then_should_return_cardinal_south()
        {
            _rotationService.Setup(s => s.GetRightRotationCardinal(It.IsAny<Cardinal>())).Returns(Cardinal.South);

            var newCardinal = _cardinal.RotateRight().RotateRight();

            newCardinal.Value
                .Should()
                .Be(Cardinal.SOUTH);
        }
    }
}