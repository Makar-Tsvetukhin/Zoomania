using Animal;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Animal
{
	public class LevelStorage
	{
		/*[SerializeField] public Panda_Level_1_Config level1;
		[SerializeField] public Panda_Level_2_Config config2;
		[SerializeField] public Panda_Level_3_Config config3;
		[SerializeField] public Panda_Level_4_Config config4;*/

		List<Level> levels = new List<Level>();
		Level thislevel;

		public LevelStorage()
		{
			//thislevel = new Level(config1.ClicksToCreate, config1.RequiredWater, config1.RequiredFood, config1.MoneyPerClick, config1.MoneyPerSecond, config1.WaterForUpgrade, config1.FoodForUpgrade);
			thislevel = new Level(1, 1, 1, 1, 1, 1, 1);
			levels.Add(thislevel);

			thislevel = new Level(2, 2, 2, 2, 2, 2, 2);
			levels.Add(thislevel);

			thislevel = new Level(3, 3, 3, 3, 3, 3, 3); 
			levels.Add(thislevel);

			thislevel = new Level(4, 4, 4, 4, 4, 4, 4); 
			levels.Add(thislevel);
		}

		public Level GetLevel(int levelnumber)
		{
			return levels[levelnumber];
		}

	}

}