using System;
using SwinGameSDK;

namespace MyGame
{
	public class GameMain
	{
		public static void Main ()
		{

			SwinGame.OpenGraphicsWindow ("GameMain", 600, 800);

			Controller gameController = new Controller ();

			while (false == SwinGame.WindowCloseRequested ()) {

				SwinGame.ProcessEvents ();
				SwinGame.ClearScreen (Color.White);

				gameController.CreateObjects ();
				gameController.DrawObjects ();
				gameController.MoveObjects ();
				gameController.CheckCollision ();
				SwinGame.RefreshScreen (60);

			}
		}
	}
}