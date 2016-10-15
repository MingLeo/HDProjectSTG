using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public abstract class Enemy : FlyingObject

	{
		

		public Enemy(double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			

		}


		//three types of fire: single bullet, double, and penta
		//can add more (extension)
		public override void Fire ()
		{
			switch (BulletType) {
			case 1:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation, YLocation+ ENEMY_BITMAP_CENTRE_X, BulletSpeed, FirePower, BitmapKind.BulletA));
				}
				break;

			case 2:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation, YLocation + ENEMY_BITMAP_CENTRE_X + 15, BulletSpeed, FirePower, BitmapKind.BulletB));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation, YLocation + ENEMY_BITMAP_CENTRE_X - 15, BulletSpeed, FirePower, BitmapKind.BulletB));
				}
				break;

			case 3:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation-10, YLocation+ ENEMY_BITMAP_CENTRE_X, BulletSpeed, FirePower, BitmapKind.BulletC));

					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation - 5, YLocation+ ENEMY_BITMAP_CENTRE_X + 25, BulletSpeed, FirePower, BitmapKind.BulletC));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation - 5, YLocation + ENEMY_BITMAP_CENTRE_X - 25, BulletSpeed, FirePower, BitmapKind.BulletC));
				}
				break;
			}
		}

		//2 different types of moving pattern for 2 types of enemy. Each override both but leave one of them empty
		public abstract void MovePattern (int aPeriod, int aStartDirection);
		public abstract void MovePattern (double aCentreX, double aCentreY, double aRadiusX, double aRadiusY,int directionX, int directionY);

		//draw the player
		//size is hardcoded (radius = 20)

	}
}

