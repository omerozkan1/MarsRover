using MarsRover.Concrete.Directions;

namespace MarsRover.Interfaces.Directions
{
    public interface IDirection
    {
        DirectionType CurrentDirection { get; set; }
    }
}
