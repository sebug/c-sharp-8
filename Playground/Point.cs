﻿using System;
namespace Playground
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public void Translate(int xOffset, int yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}
