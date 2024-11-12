using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Animal
{
    public class Animals : MonoBehaviour
    {
        public Panda_Level_1_Config config1;
        public Panda_Level_2_Config config2;
        public Panda_Level_3_Config config3;
        public Panda_Level_4_Config config4;

        public List<AnimalLevel> levels = new List<AnimalLevel>();


        public AnimalLevel CurrentLevel { get; private set; }

		public GameObject WaterBuilding;

		public WaterBuilding waterbuildingscript;

		public GameObject FoodBuilding;

		public FoodBuilding foodbuildingscript;
        public Timer UpgradeTime { get; private set; }


		public void Start()
        {
            InitializeLevels();

            CurrentLevel = levels[0];

			WaterBuilding = GameObject.Find("Поилка");
			waterbuildingscript = WaterBuilding.GetComponent<WaterBuilding>();
			waterbuildingscript.OnChange += UpdateData;

			FoodBuilding = GameObject.Find("Кормушка");
			foodbuildingscript = FoodBuilding.GetComponent<FoodBuilding>();
			foodbuildingscript.OnChange += UpdateData;

            UpgradeTime = new Timer(5);
            UpgradeTime.OnTimerEnd += Upgrade;
		}

		public void InitializeLevels()
        {
            levels.Add(new AnimalLevel(1, config1.RequiredWater, config1.RequiredFood, config1.MoneyPerClick, config1.MoneyPerSecond, config1.WaterForUpgrade, config1.FoodForUpgrade));
			levels.Add(new AnimalLevel(2, config2.RequiredWater, config2.RequiredFood, config2.MoneyPerClick, config2.MoneyPerSecond, config2.WaterForUpgrade, config2.FoodForUpgrade));
			levels.Add(new AnimalLevel(3, config3.RequiredWater, config3.RequiredFood, config3.MoneyPerClick, config3.MoneyPerSecond, config3.WaterForUpgrade, config3.FoodForUpgrade));
			levels.Add(new AnimalLevel(4, config4.RequiredWater, config4.RequiredFood, config4.MoneyPerClick, config4.MoneyPerSecond, config4.WaterForUpgrade, config4.FoodForUpgrade));
		}

		public void UpdateData()
        {
            waterbuildingscript = WaterBuilding.GetComponent<WaterBuilding>();
            foodbuildingscript = FoodBuilding.GetComponent<FoodBuilding>();
		}

        public void Upgrade()
        {
            if (waterbuildingscript.GetData() < CurrentLevel.WaterForUpgrade || foodbuildingscript.GetData() < CurrentLevel.FoodForUpgrade) return;

            waterbuildingscript.SetData(CurrentLevel.WaterForUpgrade);
            foodbuildingscript.SetData(CurrentLevel.FoodForUpgrade);

            CurrentLevel = levels[CurrentLevel.CurrentLevelNumber];
            UpgradeTime.ResetTimer(false);
            Debug.Log($"Данные моего нового уровня: {CurrentLevel.RequiredWater}, {CurrentLevel.RequiredFood}, {CurrentLevel.MoneyPerClick}, {CurrentLevel.MoneyPerSecond}, {CurrentLevel.WaterForUpgrade}, {CurrentLevel.FoodForUpgrade}");
        }

		public void Update()
		{
            if (CurrentLevel.CurrentLevelNumber < 4 && waterbuildingscript.GetData() >= CurrentLevel.WaterForUpgrade && foodbuildingscript.GetData() >= CurrentLevel.FoodForUpgrade) UpgradeTime.Tick(Time.deltaTime);
		}
	}
}