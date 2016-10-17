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
			
		}
		public static void MenuScreen ()
		{
			
		}

		public static void EndScreen ()
		{
			
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
			

		}

		public static bool CheckGameStatus()
		{
			
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

