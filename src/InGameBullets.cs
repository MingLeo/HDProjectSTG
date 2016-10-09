using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public static class InGameBullets
	{
		private static List<Weapon> _gamePlayerWeapon = new List<Weapon> ();
		private static List<Weapon> _gameEnemyWeapon = new List<Weapon> ();




		public static void CleanBullet ()
		{
			for (int i = 0; i < GamePlayerWeapon.Count; i++)
			{
				if( (GamePlayerWeapon[i].XLocation < 0 )
				   ||(GamePlayerWeapon [i].XLocation >SwinGame.ScreenWidth ())
				   ||(GamePlayerWeapon [i].YLocation < 0)
				   || (GamePlayerWeapon [i].XLocation > SwinGame.ScreenHeight ()))
				{
					GamePlayerWeapon.RemoveAt (i);
				}
			}
		}










		public static List<Weapon> GamePlayerWeapon {
			get {
				return _gamePlayerWeapon;
			}

			set {
				_gamePlayerWeapon = value;
			}
		}




		public static List<Weapon> GameEnemyWeapon {
			get {
				return _gameEnemyWeapon;
			}

			set {
				_gameEnemyWeapon = value;
			}
		}
	}
}

