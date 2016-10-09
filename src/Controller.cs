using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Controller
	{
		private Player _gamePlayer;
		private List<Enemy> _enemies;


		public Controller ()
		{
			_gamePlayer = new Player (SwinGame.ScreenWidth () / 2, SwinGame.ScreenHeight () - 30, 10, 3, 20, 2);
			_enemies = new List<Enemy> ();
			Enemies.Add (new EnemyTypeII (100, 100, 10, 2, 60));
			Enemies.Add (new EnemyTypeI (100, 100, 10, 3, 300,100, 60, 20, 0.02));
		}


		public void CreateObjects ()
		{
			GamePlayer.Fire (1,4);

			foreach (Enemy ene in Enemies){
				ene.Fire (2,3);
			}


		}


		public void DrawObjects ()
		{
			GamePlayer.Draw (Color.Red);

			foreach (Enemy ene in Enemies){
				ene.Draw (Color.Blue);
				ene.Move ();
			}

			foreach (Weapon pW in InGameBullets.GamePlayerWeapon){
				pW.Draw (Color.Red);
			}
			foreach (Weapon pW in InGameBullets.GameEnemyWeapon) {
				pW.Draw (Color.Blue);
			}

			InGameBullets.CleanBullet ();

		}

		public void MoveObjects ()
		{
			_gamePlayer.Move ();
		}
		public void CheckCollision ()
		{
			//hero's bullet vs enemies
			for (int i = 0; i < InGameBullets.GamePlayerWeapon.Count; i++){
				for (int j = 0; j < Enemies.Count; j++){
					if ((InGameBullets.GamePlayerWeapon[i].XLocation >= Enemies[j].XLocation - 20)
						&&(InGameBullets.GamePlayerWeapon [i].XLocation <= Enemies [j].XLocation +20)
						&&(InGameBullets.GamePlayerWeapon [i].YLocation >= Enemies [j].YLocation - 20)
					    &&(InGameBullets.GamePlayerWeapon [i].YLocation <= Enemies [j].YLocation + 20))
					{
						InGameBullets.GamePlayerWeapon.RemoveAt (i);
						Enemies.RemoveAt (j);
					}
				}
			}

			//enemy's bullet vs player

			for (int i = 0; i < InGameBullets.GameEnemyWeapon.Count; i++) {
				for (int j = 0; j < Enemies.Count; j++) {
					if ((InGameBullets.GameEnemyWeapon [i].XLocation >= GamePlayer.XLocation - 20)
						&& (InGameBullets.GameEnemyWeapon [i].XLocation <= GamePlayer.XLocation + 20)
						&& (InGameBullets.GameEnemyWeapon [i].YLocation >= GamePlayer.YLocation - 20)
						&& (InGameBullets.GameEnemyWeapon [i].YLocation <= GamePlayer.YLocation + 20)) {
						InGameBullets.GameEnemyWeapon.RemoveAt (i);
					//	GamePlayer.Destroy ();

					}
				}
			}
		}

	

		public List<Enemy> Enemies {
			get {
				return _enemies;
			}

			set {
				_enemies = value;
			}
		}

		public Player GamePlayer {
			get {
				return _gamePlayer;
			}

			set {
				_gamePlayer = value;
			}
		}



	}
}

