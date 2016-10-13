using System;
using SwinGameSDK;
namespace MyGame
{
	//this class has common properties for both Player and Enemy classes
	public abstract class FlyingObject:GameObject
	{
		

		public FlyingObject (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed)
		{
			_hp = aHp;
			_timerCount = 0;
		}

		//Determine what weapon it has based on given parameters
		//bullet speed: negative (goes upward) is for player, positive is for enemies
		public void Equip (int aBulletType, int aFireRate, double aBulletSpeed, int aFirePower)
		{
			
		}

		//Both player and enemy need to fire their bullets
		public abstract void Fire ();


		//basic properties
		
	}
}

