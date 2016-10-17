using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame

{
	/// <summary>
	/// Enemy circular.
	/// Inherites Enemy.
	/// Model for enemies that move on a curve pattern.
	/// </summary>
	public class EnemyCircular : Enemy, IPatternCurve
	{
		private double _angle;
		private double _centreX;
		private double _centreY;
		private double _radiusY;
		private double _radiusX;
		private double _directionX;
		private double _directionY;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MyGame.EnemyCircular"/> class.
		/// </summary>
		/// <param name="aXLocation">Enemy's X Location.</param>
		/// <param name="aYLocation">Enemy's A Y Location.</param>
		/// <param name="aSpeed">Enemy's speed.</param>
		/// <param name="aHp">Enemy's hp.</param>
		public EnemyCircular (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
		}
		/// <summary>
		/// Ship moves on a curve.
		/// Interface's methods
		/// </summary>
		/// <param name="aCentreX">Curve centre x.</param>
		/// <param name="aCentreY">Curve centre y.</param>
		/// <param name="aRadiusX">Curve radius x.</param>
		/// <param name="aRadiusY">Curve radius y.</param>
		/// <param name="directionX">Horizontal Direction.</param>
		/// <param name="directionY">Vertical Direction.</param>
		public void MovePattern(double aCentreX, double aCentreY, double aRadiusX, double aRadiusY, int directionX, int directionY)
		{
			_angle = 0;
			_radiusX = aRadiusX;
			_radiusY = aRadiusY;
			_centreX = aCentreX;
			_centreY = aCentreY;
			_directionX = directionX;
			_directionY = directionY;
		}



		/// <summary>
		/// Update enemy position.
		/// Elliptical movement.
		/// </summary>
		public override void Move ()
		{
			XLocation = _centreX + _directionX *_radiusX * Math.Sin (_angle)*Speed;
			YLocation = _centreY + _directionY * _radiusY * Math.Cos (_angle)*Speed;
			_angle += Speed/1000;
		}

		/// <summary>
		/// Draw this enemy.
		/// </summary>
		public override void Draw ()
		{
			SwinGame.DrawBitmap (Controller.GetBitMap (BitmapKind.EnemyCir), (float)XLocation, (float)YLocation);
		}

	}
}

