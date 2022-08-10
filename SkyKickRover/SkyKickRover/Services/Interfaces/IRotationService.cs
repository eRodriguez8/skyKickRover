using SkyKickRover.ValueObjects;

namespace SkyKickRover.Services.Interfaces
{
    public interface IRotationService
    {
        Cardinal GetLeftRotationCardinal(Cardinal cardinal);
        Cardinal GetRightRotationCardinal(Cardinal cardinal);
    }
}