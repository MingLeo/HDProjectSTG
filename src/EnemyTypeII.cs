using System;
namespace MyGame
{
	public class EnemyTypeII : Enemy
	{
		private int _period;
		private int _direction;

		public EnemyTypeII (double aXLocation, double aYLocation, int aHp, double aSpeed, int aPeriod)
			: base (aXLocation, aYLocation, aHp, aSpeed)
		{
			_period = aPeriod;
			_direction = 1;
		}


		public override void Move ()
		{
			TimerCount++;
			if (TimerCount == Period) {
				Direction = -1 * Direction;
			}
			XLocation += Direction * Speed;
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

