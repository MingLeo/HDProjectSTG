using System;
using System.Collections.Generic;
using SwinGameSDK;
namespace MyGame
{

	//this static class keep the bullets even when the player or enemies are destroyed
	public static class InGameBullets
	{
		private static List<Weapon> _gamePlayerWeapon = new List<Weapon> ();
		private static List<Weapon> _gameEnemyWeapon = new List<Weapon> ();

		//move the bullets on the screen
		public static void MoveBullet(){
			
		}

		//check whether they are out of bound
		public static void CleanBullet ()
		{
			
		}


		
		

