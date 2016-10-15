using System;
using System.Collections.Generic;
using SwinGameSDK;


namespace MyGame
{
	public class Controller
	{
		private int _score;
		private int _time;
		private int _whichIsDestroyed=-1;
		private Timer _timer;
		private int tempTime;
		private List<Player> _player;
		private List<EnemyCircular> _enemiesCircular;
		private List<EnemyLinear> _enemiesLinear;
		private List<Explosion> _explosions;
		private Random _rand;
		//add player and enemies
		public Controller ()
		{
			LoadResources ();

			_score = 0;
			_timer = new Timer ();
			Timer.Start ();
			_rand = new Random ();
			_explosions = new List<Explosion> ();
			_player = new List<Player> ();


			_enemiesCircular = new List<EnemyCircular> ();
			_enemiesLinear = new List<EnemyLinear> ();


		}

		private void LoadResources ()
		{
			SwinGame.LoadFont ("arial.ttf", 72);
			SwinGame.LoadBitmapNamed ("BulletA", "bullet1.png");
			SwinGame.LoadBitmapNamed ("BulletB", "bullet2.png");
			SwinGame.LoadBitmapNamed ("BulletC", "bullet3.png");
			SwinGame.LoadBitmapNamed ("Player", "player.png");
			SwinGame.LoadBitmapNamed ("EnemyCir", "enemycir.png");
			SwinGame.LoadBitmapNamed ("EnemyLin", "enemylin.png");
			SwinGame.LoadBitmapNamed ("Explosion", "explosion.png");
			SwinGame.LoadBitmapNamed ("Background", "background.png");
			SwinGame.LoadSoundEffectNamed ("Bang","bang.wav");
		}

		public static Bitmap GetBitMap(BitmapKind bmb){
			switch (bmb){
			case BitmapKind.BulletA:
				return SwinGame.BitmapNamed ("BulletA");
			case BitmapKind.BulletB:
				return SwinGame.BitmapNamed ("BulletB");
			case BitmapKind.BulletC:
				return SwinGame.BitmapNamed ("BulletC");
			case BitmapKind.Player:
				return SwinGame.BitmapNamed ("Player");
			case BitmapKind.EnemyCir:
				return SwinGame.BitmapNamed ("EnemyCir");
			case BitmapKind.EnemyLin:
				return SwinGame.BitmapNamed ("EnemyLin");
			case BitmapKind.Explosion:
				return SwinGame.BitmapNamed ("Explosion");
				case BitmapKind.Background:
				return SwinGame.BitmapNamed ("Background");
			default:
				return SwinGame.BitmapNamed ("BulletA");
			}

		
		}

		public void DeployedObjects(){
			
		}


		// add player's and enemies' weapon & moving pattern
		public void EquipObjects(){
			
		}

		//draw player, enemies ad bullets
		public void DrawObjects ()
		{
			
					
					
			
			
		}

		//let them fire their bullets
		public void FireObjects ()
		{
			

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

		public void DrawHUD ()
		{
			
			if (Score <= 0)
				Score = 0;

			_time = (int)Timer.Ticks / 1000;

			String scoreHUD = "Your score " + Score;
			SwinGame.DrawText (scoreHUD, Color.Red,"arial.ttf", 20, 20, 20);

			if (Time != 0)
				tempTime = Time;
			String timeHUD = "Your time " + tempTime;
			SwinGame.DrawText (timeHUD, Color.Red,"arial.ttf", 20, 500, 20);

			int tempHP = 0;
			if (Players.Count != 0) {
				//tempHP = Players [0].Hp;

			} else tempHP = 0;

			String hpHUD = "Your HP " + tempHP;
			SwinGame.DrawText (hpHUD, Color.Red,"arial.ttf", 20, 1000, 20);
		}


		// check whether their hps < 0
		public void CheckAlive ()
		{
			
		}
		public bool CheckEndGame(){
			
			
		}



		public void CheckCollision ()
		{
			

		}
		public void KeyBoardControl(){
			if (Players.Count != 0) {
				if (_whichIsDestroyed == 1) {
					ControlWASD (0);
				} else if (_whichIsDestroyed == 0) {
					ControlULDR (0);
				} else if (_whichIsDestroyed == -1) {
					ControlWASD (0);
					ControlULDR (1);
				}
			}
			
		}
		public void ControlWASD (int playerNum)
		{

			if (SwinGame.KeyDown (KeyCode.vk_a) && (Players [playerNum].XLocation > 20))
				Players [playerNum].ControlDirection = 1;
			if (SwinGame.KeyDown (KeyCode.vk_d) && (Players [playerNum].XLocation <= 1100))
				Players [playerNum].ControlDirection = 2;
			if ((SwinGame.KeyDown (KeyCode.vk_w) && (Players [playerNum].YLocation >= 20)))
				Players [playerNum].ControlDirection = 3;
			if ((SwinGame.KeyDown (KeyCode.vk_s) && (Players [playerNum].YLocation <= 700)))
				Players [playerNum].ControlDirection = 4;

			Players [playerNum].Move ();
		}

		public void ControlULDR (int playerNum){ 
			if (SwinGame.KeyDown (KeyCode.vk_LEFT) && (Players [playerNum].XLocation > 20)) 
				Players [playerNum].ControlDirection = 1;
			if (SwinGame.KeyDown (KeyCode.vk_RIGHT) && (Players [playerNum].XLocation <= 1100)) 
				Players [playerNum].ControlDirection = 2;
				Players [playerNum].Move ();
			if ((SwinGame.KeyDown (KeyCode.vk_UP) && (Players [playerNum].YLocation >= 20))) 
				Players [playerNum].ControlDirection = 3;
				Players [playerNum].Move ();
			if ((SwinGame.KeyDown (KeyCode.vk_DOWN) && (Players [playerNum].YLocation <= 700))) 
				Players [playerNum].ControlDirection = 4;
			Players [playerNum].Move ();
		}





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

		public List<Explosion> Explosions {
			get {
				return _explosions;
			}

			set {
				_explosions = value;
			}
		}
	}
}

