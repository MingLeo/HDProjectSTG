using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public abstract class Enemy : GameObject

	{
		private int _hp;
		private double _speed;
		private int _timerCount;
		private int _fireRate;
		private double _enemyBulletSpeed;

		public Enemy(double aXLocation, double aYLocation, int aHp, double aSpeed):base (aXLocation,aYLocation){
			_speed = aSpeed;
			_hp = aHp;
			_timerCount = 0;
			_fireRate = 70;
			_enemyBulletSpeed = 3;
		}



		public void Fire (int aBulletType, double aBulletSpeed)
		{
			switch (aBulletType) {
			case 1:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation, YLocation, aBulletType));
				}
				for (int i = 0; i < InGameBullets.GameEnemyWeapon.Count; i++)
					

					InGameBullets.GameEnemyWeapon [i].Move (2);
				break;

			case 2:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation + 15, YLocation, aBulletType));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation - 15, YLocation, aBulletType));
				}
				for (int i = 0; i < InGameBullets.GameEnemyWeapon.Count; i++)
					InGameBullets.GameEnemyWeapon [i].Move (2);
				break;

			case 3:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation, YLocation - 10, aBulletType));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation + 15, YLocation - 5, aBulletType));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation - 15, YLocation - 5, aBulletType));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation + 25, YLocation, aBulletType));
					InGameBullets.GameEnemyWeapon.Add (new Weapon (XLocation - 25, YLocation, aBulletType));
				}
				for (int i = 0; i < InGameBullets.GameEnemyWeapon.Count; i++)
					InGameBullets.GameEnemyWeapon [i].Move (2);
				break;

			}
		}








		public int Hp {
			get {
				return _hp;
			}

			set {
				_hp = value;
			}
		}

		public double Speed {
			get {
				return _speed;
			}

			set {
				_speed = value;
			}
		}

		public double EnemyBulletSpeed {
			get {
				return _enemyBulletSpeed;
			}

			set {
				_enemyBulletSpeed = value;
			}
		}

		public int FireRate {
			get {
				return _fireRate;
			}

			set {
				_fireRate = value;
			}
		}

		public int TimerCount {
			get {
				return _timerCount;
			}

			set {
				_timerCount = value;
			}
		}

		public override void Draw (Color aColor)
		{

			SwinGame.DrawCircle (aColor, (float)XLocation, (float)YLocation, 20);
		
		}
	}
}

