using SkyKickRover.Services.Interfaces;
using SkyKickRover.ValueObjects;

namespace SkyKickRover.Services
{
    public class RotationService : IRotationService
    {
        private readonly Dictionary<Cardinal, Cardinal> _cardinalLeftPoints;
        private readonly Dictionary<Cardinal, Cardinal> _cardinalRightPoints;

        public RotationService()
        {
            _cardinalLeftPoints = InitializeLeftPoints();
            _cardinalRightPoints = InitializeRightPoints();
        }

        private static Dictionary<Cardinal, Cardinal> InitializeLeftPoints()
        {
            return new Dictionary<Cardinal, Cardinal>
            {
                { Cardinal.North, Cardinal.West },
                { Cardinal.South, Cardinal.East },
                { Cardinal.East, Cardinal.North },
                { Cardinal.West, Cardinal.South }
            };
        }

        private static Dictionary<Cardinal, Cardinal> InitializeRightPoints()
        {
            return new Dictionary<Cardinal, Cardinal>
            {
                { Cardinal.North, Cardinal.East },
                { Cardinal.South, Cardinal.West },
                { Cardinal.East, Cardinal.South },
                { Cardinal.West, Cardinal.North }
            };
        }

        public Cardinal GetLeftRotationCardinal(Cardinal cardinal)
        {
            return _cardinalLeftPoints[cardinal];
        }

        public Cardinal GetRightRotationCardinal(Cardinal cardinal)
        {
            return _cardinalRightPoints[cardinal];
        }
    }
}
