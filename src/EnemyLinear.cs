using System;
namespace MyGame
{
	public class EnemyLinear : Enemy
	{
		private int _period;
		private int _direction;

		public EnemyLinear (double aXLocation, double aYLocation, int aHp, double aSpeed)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			
		}

		public override void MovePattern (int aPeriod, int aStartDirection)
		{
		
		}
		public override void MovePattern (double aCentreX, double aCentreY, double aRadiusX, double aRadiusY)
		{
			//not need to be overriden
		}



		public override void Move ()
		{
			
		}



		

	
	}
}

