using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
	public class Player : FlyingObject
	{
		
	
	
		public Player (double aXLocation, double aYLocation, double aSpeed, int aHp)
			: base (aXLocation, aYLocation, aSpeed, aHp)
		{
			

		}



		//keyboard control
		public override void Move ()
		{
			
		}

		//three types of fire: single bullet, double, and penta
		//can add more (extension)
		public override void Fire ()
		{
			
		}


		//draw the player
		//size is hardcoded (radius = 20)
		public override void Draw (Color aColor)
		{
			
		}

	}
}

