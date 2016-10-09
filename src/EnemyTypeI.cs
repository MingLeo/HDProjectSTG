using System;
namespace MyGame
{
	public class EnemyTypeI : Enemy
	{
		private double _angle;
		private double _angleRate;
		private double _centreX;
		private double _centreY;
		private double _radiusY;
		private double _radiusX;
		public EnemyTypeI (double aXLocation, double aYLocation, int aHp, double aSpeed, double aCentreX, double aCentreY, double aRadiusX, double aRadiusY, double aAngelRate)
			: base (aXLocation, aYLocation, aHp, aSpeed)
		{
			_angle = 0;
			_angleRate = aAngelRate;
			_radiusX = aRadiusX;
			_radiusY = aRadiusY;
			_centreX = aCentreX;
			_centreY = aCentreY;
		}

		public override void Move ()
		{
			XLocation = CentreX + RadiusX * Math.Sin (Angle)*Speed;
			YLocation = CentreY + RadiusY * Math.Cos (Angle)*Speed;
			Angle += AngleRate;
		}



		public double Angle {
			get {
				return _angle;
			}

			set {
				_angle = value;
			}
		}

		public double AngleRate {
			get {
				return _angleRate;
			}

			set {
				_angleRate = value;
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

	}
}

