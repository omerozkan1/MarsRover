using MarsRover.Concrete.Directions;
using MarsRover.Interfaces.Coordinates;

namespace MarsRover.Interfaces.Rovers
{
    public interface IRover
    {
        void SetLocation(ICoordinate coordinate);
        void TurnDirection(DirectionType direction);
        string GetCurrentPosition();
        void GiveCommand(string instruction);
    }
}
