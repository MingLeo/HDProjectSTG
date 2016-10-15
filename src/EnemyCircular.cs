using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame

{
	public class EnemyCircular : Enemy
	{
		private double _angle;
		private double _centreX;
		private double _centreY;
		private double _radiusY;
		private double _radiusX;
		private double _directionX;
		private double _directionY;

		public EnemyCircular (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			
		}


		public override void MovePattern(double aCentreX, double aCentreY, double aRadiusX, double aRadiusY, int directionX, int directionY){
			_angle = 0;

			_radiusX = aRadiusX;
			_radiusY = aRadiusY;
			_centreX = aCentreX;
			_centreY = aCentreY;
			_directionX = directionX;
			_directionY = directionY;
		}
		public override void MovePattern (int aPeriod, int aStartDirection){
			//not need to be overriden
		}
			

		//Circular moving

		public override void Move ()
		{
			XLocation = CentreX + DirectionX*RadiusX * Math.Sin (Angle)*Speed;
			YLocation = CentreY + DirectionY* RadiusY * Math.Cos (Angle)*Speed;
			Angle += Speed/1000;
		}
		public override void Draw ()
		{

			SwinGame.DrawBitmap (Controller.GetBitMap (BitmapKind.EnemyCir), (float)XLocation, (float)YLocation);

		}



		public double Angle {
			get {
				return _angle;
			}

			set {
				_angle = value;
			}
		}

		public double CentreX {
			get {
				return _centreX;
			}

			set {
				_centreX = value;
			}
		}
		public double CentreY {
			get {
				return _centreY;
			}

			set {
				_centreY = value;
			}
		}

		public double RadiusY {
			get {
				return _radiusY;
			}

			set {
				_radiusY = value;
			}
		}
		public double RadiusX {
			get {
				return _radiusX;
			}

			set {
				_radiusX = value;
			}
		}

		public double DirectionX {
			get {
				return _directionX;
			}

			set {
				_directionX = value;
			}
		}

		public double DirectionY {
			get {
				return _directionY;
			}

			set {
				_directionY = value;
			}
		}
	}
}

