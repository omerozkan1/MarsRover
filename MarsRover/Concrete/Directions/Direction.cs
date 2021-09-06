using MarsRover.Concrete.Directions;
using MarsRover.Interfaces.Directions;

namespace MarsRover.Concrete.Directions
{
    public class Direction : IDirection
    {
        public DirectionType CurrentDirection { get; set; }
    }
}
