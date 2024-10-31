using Animal;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;


namespace Animal
{
	public class Level
	{
		public int ClicksToCreate { get; set; }
		public int RequiredWater { get; set; }
		public int RequiredFood { get; set; }
		public int MoneyPerClick { get; set; }
		public int MoneyPerSecond { get; set; }
		public int WaterForUpgrade { get; set; }
		public int FoodForUpgrade { get; set; }

		public Level(int clikstocreate, int requiredwater, int requiredfood, int moneyperclick, int moneypersecond, int waterforupgrade, int foodforupgrade)
		{
			ClicksToCreate = clikstocreate;
			RequiredWater = requiredwater;
			RequiredFood = requiredfood;
			MoneyPerClick = moneyperclick;
			MoneyPerSecond = moneypersecond;
			WaterForUpgrade = waterforupgrade;
			FoodForUpgrade = foodforupgrade;
		}

	}
}
