﻿namespace DeathStar.Core.Models.Ships
{
	public class BattleCruiser 
		: Ship
	{
		internal BattleCruiser(string name, string pictureUrl, uint shield, uint armor, uint hull, uint range, uint weaponSlot, uint engineeringSlot, uint defenceSlot)
		    : base(name, pictureUrl, shield, armor, hull, range, weaponSlot, engineeringSlot, defenceSlot)
		{

		}
	}
}
