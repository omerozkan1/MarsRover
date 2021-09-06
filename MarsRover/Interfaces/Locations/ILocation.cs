using MarsRover.Concrete.Directions;
using MarsRover.Interfaces.Coordinates;

namespace MarsRover.Interfaces.Locations
{
    public interface ILocation : ICoordinate
    {
        void SetLocation(ICoordinate coordinate);
        void ChangeLocation(DirectionType currentDirection);
    }
}
