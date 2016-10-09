﻿using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{
	public abstract class GameObject
	{
		private double _xLocation;
		private double _yLocation;
		//private double _speed;

		public GameObject (double aXLocation, double aYLocation)
		{
			_xLocation = aXLocation;
			_yLocation = aYLocation;
		}

		public abstract void Draw (Color aColor);
		public abstract void Move ();

		public double XLocation {
			get {
				return _xLocation;
			}

			set {
				_xLocation = value;
			}
		}

		public double YLocation {
			get {
				return _yLocation;
			}

			set {
				_yLocation = value;
			}
		}

	}
}

