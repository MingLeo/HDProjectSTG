using System;
using SwinGameSDK;
namespace MyGame
{
	/// <summary>
	/// Utility.
	/// Combines Controller class's functions to smaller ones. 
	/// </summary>
	public static class Utility
	{
		private static Controller gameController;

		public static void DefaultScreen()
		{
			SwinGame.OpenGraphicsWindow ("GameMain", 1200, 800);
			SwinGame.ProcessEvents ();
			SwinGame.ClearScreen (Color.White);
		}
		public static void MenuScreen ()
		{
			SwinGame.ProcessEvents ();
			SwinGame.ClearScreen (Color.White);
			gameController.DrawMenu ();
			SwinGame.RefreshScreen (60);
		}

		public static void EndScreen ()
		{
			SwinGame.ProcessEvents ();
			SwinGame.ClearScreen (Color.White);
			gameController.DrawResult ();
			SwinGame.RefreshScreen (60);
		}

		public static void ClearGame(){
			gameController.CleanObjects ();
		}

		public static void InitiliseGameController()
		{
			gameController = new Controller ();
			gameController.LoadResources ();
			gameController.LoadHighScore ();
		}

		public static void CreateObjects()
		{
			SwinGame.ProcessEvents ();
			SwinGame.ClearScreen (Color.White);
			gameController.DeployedObjects ();
			gameController.EquipObjects ();
		}

		public static void CheckCollision()
		{
			gameController.CollisionPlayerVsEnemy ();
			gameController.CollisionEnemyVsBullet ();
			gameController.CollisionPlayerVsBullet ();
			gameController.CheckItemCollsion ();
		}

		public static void DrawGame()
		{
			SwinGame.ProcessEvents ();
			SwinGame.ClearScreen (Color.White);
			gameController.MoveObjects ();
			gameController.DrawObjects ();
			gameController.DrawHUD ();
			gameController.FireObjects ();

		}

		public static bool CheckGameStatus()
		{
			gameController.UpdateScore ();
			gameController.CheckAlive ();
			bool isEnd = gameController.CheckEndGame ();
			return isEnd;
		}

		public static void GameControl()
		{
			SwinGame.ProcessEvents ();
			if (gameController.Player0.Count != 0)
				gameController.ControlWASD ();
			if (gameController.Player1.Count != 0)
				gameController.ControlUDLR ();
		}




	}
}

