﻿using MarsRover.Interfaces.Coordinates;

namespace MarsRover.Coordinates
{
    public class Coordinate : ICoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
