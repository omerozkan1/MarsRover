using MarsRover.Common;
using MarsRover.Concrete.Directions;
using MarsRover.Concrete.Locations;
using MarsRover.Concrete.Plateaus;
using MarsRover.Concrete.Rovers;
using MarsRover.Coordinates;
using MarsRover.Interfaces.Directions;
using MarsRover.Interfaces.Locations;
using MarsRover.Interfaces.Plateaus;
using MarsRover.Interfaces.Rovers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            StaticValue st = new StaticValue();
            var serviceProvider = CreateContainerBuilder();
            var plateau = serviceProvider.GetService<IPlateau>();
            plateau.SetSize(new Coordinate(5, 5));

            for (var i = 0; i < 7; i = i + 4)
            {
                var rover = serviceProvider.GetService<IRover>();
                rover.SetLocation(new Coordinate(Convert.ToInt32(st.input[i]), Convert.ToInt32(st.input[i + 1])));
                rover.TurnDirection((DirectionType)Convert.ToInt32(st.input[i + 2]));
                rover.GiveCommand(st.input[i + 3]);
                Console.WriteLine(rover.GetCurrentPosition());
            }
        }

        private static ServiceProvider CreateContainerBuilder()
        {
            return new ServiceCollection()
                .AddScoped<IPlateau, Plateau>()
                .AddScoped<ILocation, Location>()
                .AddScoped<IDirection, Direction>()
                .AddScoped<IRover, Rover>()
                .BuildServiceProvider();
        }
    }
}
