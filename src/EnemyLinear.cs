using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public class EnemyLinear : Enemy
	{
		private int _period;
		private int _direction;
		private Timer _timer;

		public EnemyLinear (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			_timer = new Timer ();
		}



		public override void MovePattern (int aPeriod, int aStartDirection)
		{
			_period = aPeriod;
			_direction = aStartDirection;
			_timer.Start ();
		}
		public override void MovePattern (double aCentreX, double aCentreY, double aRadiusX, double aRadiusY,int directionX, int directionY)
		{
			//not need to be overriden
		}



		public override void Move ()
		{
			
			if (_timer.Ticks > Period) {
				_timer.Reset ();
				Direction = -Direction;

			}

			YLocation += Direction * Speed;
		}

		public override void Draw ()
		{

			SwinGame.DrawBitmap (Controller.GetBitMap (BitmapKind.EnemyLin), (float)XLocation, (float)YLocation);

		}



		public int Period {
			get {
				return _period;
			}

			set {
				_period = value;
			}
		}


		public int Direction {
			get {
				return _direction;
			}

			set {
				_direction = value;
			}
		}

	
	}
}

