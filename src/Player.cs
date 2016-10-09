using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Player : GameObject
	{
		private int _hp;

		private int _timerCount;
		private int _fireRate;
		private double _playerBulletSpeed;
		private double _playerSpeed;
	
		public Player (double aXLocation, double aYLocation, int aHp,double aPlayerSpeed, int aFireRate, double aBulletSpeed)
			: base (aXLocation, aYLocation)
		{
			_hp = aHp;

			_timerCount = 0;
			_fireRate = aFireRate;
			_playerBulletSpeed = aBulletSpeed;
			_playerSpeed = aPlayerSpeed;
		}


		public void Fire(int aBulletType, double aBulletSpeed){
			switch (aBulletType) {
			case 1:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation, YLocation, aBulletSpeed));
				}
				for (int i = 0; i < InGameBullets.GamePlayerWeapon.Count; i++)
					InGameBullets.GamePlayerWeapon [i].Move (1);
				break;

			case 2:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation + 15, YLocation,  aBulletSpeed ));
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation - 15, YLocation,  aBulletSpeed));
				}
				for (int i = 0; i < InGameBullets.GamePlayerWeapon.Count; i++)
					InGameBullets.GamePlayerWeapon [i].Move (1);
				break;

			case 3:
				if (TimerCount++ == FireRate) {
					TimerCount = 0;
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation, YLocation - 10, aBulletSpeed));
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation + 15, YLocation - 5, aBulletSpeed));
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation - 15, YLocation - 5,  aBulletSpeed));
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation + 25, YLocation, aBulletSpeed));
					InGameBullets.GamePlayerWeapon.Add (new Weapon (XLocation - 25, YLocation, aBulletSpeed));
				}
				for (int i = 0; i < InGameBullets.GamePlayerWeapon.Count; i++)
					InGameBullets.GamePlayerWeapon [i].Move (1);
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

		public int TimerCount {
			get {
				return _timerCount;
			}

			set {
				_timerCount = value;
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

		public double PlayerBulletSpeed {
			get {
				return _playerBulletSpeed;
			}

			set {
				_playerBulletSpeed = value;
			}
		}

		public double PlayerSpeed {
			get {
				return _playerSpeed;
			}

			set {
				_playerSpeed = value;
			}
		}

		public override void Move ()
		{
			if (SwinGame.KeyDown (KeyCode.vk_a))
				XLocation -= PlayerSpeed;
			if (SwinGame.KeyDown (KeyCode.vk_d))
				XLocation += PlayerSpeed;
			if ((SwinGame.KeyDown (KeyCode.vk_w)&&(YLocation>=SwinGame.ScreenHeight ()-200))) 
				YLocation -= PlayerSpeed;
			if ((SwinGame.KeyDown (KeyCode.vk_s) && (YLocation <= SwinGame.ScreenHeight () - 25)))
				YLocation += PlayerSpeed;



		}
		public override void Draw (Color aColor)
		{
			SwinGame.DrawCircle (aColor,(float)XLocation,(float)YLocation,20 );
		}

	}
}

