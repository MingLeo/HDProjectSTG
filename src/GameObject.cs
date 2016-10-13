using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public abstract class GameObject
	{
		private double _xLocation;
		private double _yLocation;
		private double _speed;

		public GameObject (double aXLocation, double aYLocation, double aSpeed)
		{
			
		}

		public abstract void Draw (Color aColor);
		public abstract void Move ();

		
	}
}

