using MarsRover.Interfaces.Coordinates;

namespace MarsRover.Validators
{
    public abstract class CoordinateValidator
    {
        protected abstract void Validate(ICoordinate coordinate);
    }
}
