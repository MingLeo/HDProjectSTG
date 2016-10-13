using System;
namespace MyGame
{
	public class EnemyCircular : Enemy
	{
		private double _angle;
		private double _centreX;
		private double _centreY;
		private double _radiusY;
		private double _radiusX;

		public EnemyCircular (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			
		}

		public override void MovePattern(double aCentreX, double aCentreY, double aRadiusX, double aRadiusY){
			
		}
		public override void MovePattern (int aPeriod, int aStartDirection){
			//not need to be overriden
		}
			

		//Circular moving

		public override void Move ()
		{
			
		}




		
		}

	}
}

