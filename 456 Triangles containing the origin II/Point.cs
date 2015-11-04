using System;

namespace Problem456
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            if (X == 0 && Y == 0)
            {
                IsOrigin = true;
                return;
            }
            var vectorLength = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            var normX = X/vectorLength;
            var normY = Y/vectorLength;
            var angle =
                normX != 0
                    ? Math.Atan(normY/normX)
                    : normY < 0
                        ? -Math.PI/2
                        : Math.PI/2;
            if (normX < 0)
            {
                angle = angle + Math.PI;
            }
            else if (angle < 0)
            {
                angle = angle + 2*Math.PI;
            }
            A = angle;
            InvA = (angle + Math.PI)%(2*Math.PI);
        }

        public int X { get; }
        public int Y { get; }
        public double A { get; }
        public double InvA { get; }
        public bool IsOrigin { get; }
    }
}