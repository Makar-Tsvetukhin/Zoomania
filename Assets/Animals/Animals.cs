using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Animal
{
    public class Animals : MonoBehaviour
    {

		/*public int ClicksToCreate { get; set; }
        public int RequiredWater { get; set; }
        public int RequiredFood { get; set; }
        public int MoneyPerClick { get; set; }
        public int MoneyPerSecond { get; set; }
        public int WaterForUpgrade { get; set; }
        public int FoodForUpgrade { get; set; }


        LevelStorage storage = new LevelStorage();


		public int CurrentLevelNumber = 0;
        private Level CurrentLevel;

		public ResourceWater CurrentWater;
		public ResourceFood CurrentFood;



		void Start()
        {
			CurrentLevel = storage.GetLevel(CurrentLevelNumber-1);
            Debug.Log(CurrentLevel.WaterForUpgrade);
			Debug.Log(CurrentWater.GetResourcesCount());
			Upgrade();
        }


        public void Upgrade()
        {
            if (CurrentLevelNumber == 4) return;

            if (CurrentWater.GetResourcesCount() - CurrentLevel.WaterForUpgrade >= 0 && CurrentFood.GetResourcesCount() - CurrentLevel.FoodForUpgrade >= 0)
            {
                Debug.Log($"Панда улучшена до {CurrentLevelNumber+1} уровня");
                CurrentLevelNumber++;
                CurrentLevel = storage.GetLevel(CurrentLevelNumber - 1);
                Debug.Log(CurrentLevel.WaterForUpgrade);
            }
            else Debug.Log("Недостаточно ресурсов");
        }*/
    }
}