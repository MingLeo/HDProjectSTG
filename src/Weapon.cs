using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public class Weapon:GameObject
	{
		private double _bulletSpeed;



		public Weapon (double aXLocation, double aYLocation, double aBulletSpeed)
			:base(aXLocation, aYLocation)
		{
			_bulletSpeed = aBulletSpeed;
		}


		public double BulletSpeed {
			get {
				return _bulletSpeed;
			}

			set {
				_bulletSpeed = value;
			}
		}
		public override void Draw (Color aColor)
		{
			SwinGame.DrawCircle (aColor, (float)XLocation, (float)YLocation, 10);
		}
		public override void Move ()
		{
			
		}

		public void Move (int aType)
		{
			if (aType == 1)
				YLocation -= BulletSpeed;
			if (aType == 2)
				YLocation += BulletSpeed;
		}

	}
}

