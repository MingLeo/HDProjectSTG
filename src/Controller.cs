using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Controller
	{
		private int _score;
		private int _time;
		private Timer _timer;
		private List<Player> _player;
		private List<EnemyCircular> _enemiesCircular;
		private List<EnemyLinear> _enemiesLinear;
		private Random _rand;
		//add player and enemies
		public Controller ()
		{
			_score = 0;
			_timer = new Timer ();
			Timer.Start ();
			_rand = new Random ();

			_player = new List<Player> ();


			_enemiesCircular = new List<EnemyCircular> ();
			_enemiesLinear = new List<EnemyLinear> ();


		}

		public void DeployedObjects(){
			Players.Add (new Player (100, 400, 10, 10));

			EnemiesLinear.Add (new EnemyLinear (Rand.Next (500, 1100), Rand.Next (50, 750),2,3));
			EnemiesLinear.Add (new EnemyLinear (Rand.Next (500, 1100), Rand.Next (50, 750), 2, 3));

			EnemiesCircular.Add (new EnemyCircular (Rand.Next (500, 1100), Rand.Next (50, 750), 5, 5));
			EnemiesCircular.Add (new EnemyCircular (Rand.Next (500, 1100), Rand.Next (50, 750), 5, 7));
		}


		// add player's and enemies' weapon & moving pattern
		public void EquipObjects(){
			Players[0].Equip (1, 40, -5,2);

			EnemiesLinear [0].Equip (2,100, 10, 2);
			EnemiesLinear [0].MovePattern (Rand.Next (1000, 2000), 1);
			EnemiesLinear [1].Equip (3, 80, 10, 2);
			EnemiesLinear [1].MovePattern (Rand.Next (1000, 2000), -1);

			EnemiesCircular [0].Equip (1, 120, 10, 1);
			EnemiesCircular [0].MovePattern (Rand.Next (500, 1000), Rand.Next (100, 500), 20, 60,1,1);
			EnemiesCircular [1].Equip (3, 70, 10, 1);
			EnemiesCircular [1].MovePattern (Rand.Next (60, 900), Rand.Next (200, 400), 10, 50,-1,-1);
		}

		//draw player, enemies ad bullets
		public void DrawObjects ()
		{

			foreach (Player pl in Players)
				pl.Draw (Color.Red);

			foreach (EnemyLinear ene in EnemiesLinear)
				ene.Draw (Color.Blue);
			foreach (EnemyCircular ene in EnemiesCircular)
				ene.Draw (Color.Green);

			foreach (Weapon pW in InGameBullets.GamePlayerWeapon)
				pW.Draw (Color.Red);
			
			foreach (Weapon eW in InGameBullets.GameEnemyWeapon) 
				eW.Draw (Color.Black);
			
		}

		//let them fire their bullets
		public void FireObjects ()
		{
			foreach (Player pl in Players)
				pl.Fire ();

			foreach (EnemyLinear eneL in EnemiesLinear) 
					eneL.Fire ();
			foreach (EnemyCircular eneC in EnemiesCircular)
					eneC.Fire ();
	
			InGameBullets.MoveBullet ();
			InGameBullets.CleanBullet ();

		}

		//give player and enemies  new X, Y location
		public void MoveObjects ()
		{
			foreach (Player pl in Players)
				pl.Move ();
			foreach (EnemyCircular eneC in EnemiesCircular ) 
				eneC.Move ();
			foreach (EnemyLinear eneL in EnemiesLinear)
				eneL.Move ();
			
			
		}
		public void LoadResources ()
		{
			
		}
		public void DrawHUD ()
		{
			
		}

		//check collision
		//maybe a bug here
		public void CheckCollision ()
		{
			//enemies vs player's bullet
			
		}

		// check whether their hps < 0
		public void CheckAlive ()
		{
			
		}
		public bool CheckEndGame(){
			
			
		}



		//basic properties



		public List<Player> Players {
			get {
				return _player;
			}

			set {
				_player = value;
			}
		}

		public int Score {
			get {
				return _score;
			}

			set {
				_score = value;
			}
		}

		public int Time {
			get {
				return _time;
			}

			set {
				_time = value;
			}
		}

		public Timer Timer {
			get {
				return _timer;
			}

			set {
				_timer = value;
			}
		}

		public List<EnemyCircular> EnemiesCircular {
			get {
				return _enemiesCircular;
			}

			set {
				_enemiesCircular = value;
			}
		}

		public List<EnemyLinear> EnemiesLinear {
			get {
				return _enemiesLinear;
			}

			set {
				_enemiesLinear = value;
			}
		}

		public Random Rand {
			get {
				return _rand;
			}

			set {
				_rand = value;
			}
		}
	}
}

