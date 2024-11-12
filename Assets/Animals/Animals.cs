using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Animal
{
    public class Animals : MonoBehaviour
    {
        public AnimalLevel CurrentLevel { get; private set; }

		public GameObject WaterBuilding;

		public WaterBuilding waterbuildingscript;

		public GameObject FoodBuilding;

		public FoodBuilding foodbuildingscript;
        public Timer UpgradeTime { get; private set; }


		public void Start()
        {
            CurrentLevel = new AnimalLevel(1, 1, 1, 1, 1, 1);

			WaterBuilding = GameObject.Find("Поилка");
			waterbuildingscript = WaterBuilding.GetComponent<WaterBuilding>();
			waterbuildingscript.OnChange += UpdateData;

			FoodBuilding = GameObject.Find("Кормушка");
			foodbuildingscript = FoodBuilding.GetComponent<FoodBuilding>();
			foodbuildingscript.OnChange += UpdateData;

            UpgradeTime = new Timer(5);
            UpgradeTime.OnTimerEnd += Upgrade;
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

            CurrentLevel.Upgrade();
            UpgradeTime.ResetTimer(false);
            Debug.Log($"Мой уровень поднялся до {CurrentLevel.CurrentLevelNumber}");
            Debug.Log($"Требуемое количество воды стало: {CurrentLevel.WaterForUpgrade}");
        }

		public void Update()
		{
            if (CurrentLevel.CurrentLevelNumber < 4 && waterbuildingscript.GetData() >= CurrentLevel.WaterForUpgrade && foodbuildingscript.GetData() >= CurrentLevel.FoodForUpgrade) UpgradeTime.Tick(Time.deltaTime);
		}
	}
}