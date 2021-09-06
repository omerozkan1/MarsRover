using MarsRover.Interfaces.Coordinates;

namespace MarsRover.Interfaces.Plateaus
{
    public interface IPlateau : ICoordinate
    {
        void SetSize(ICoordinate coordinate);
    }
}
