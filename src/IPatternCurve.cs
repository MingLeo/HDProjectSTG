using System;
namespace MyGame
{
    /// <summary>
    /// Circular move pattern
    /// </summary>
	public interface IPatternCurve
    {
        void MovePattern(double aCentreX, double aCentreY, double aRadiusX, double aRadiusY, int directionX, int directionY);
    }
}

