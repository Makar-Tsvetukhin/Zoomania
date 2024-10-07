using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animal
{
    public class Animal_Panda : Animals
    {
        [SerializeField] private Panda_Level_1_Config config;

        void Start()
        {
            ClicksToCreate = config.ClicksToCreate;
            RequiredWater = config.RequiredWater;
            RequiredFood = config.RequiredFood;
            MoneyPerClick = config.MoneyPerClick;
            MoneyPerSecond = config.MoneyPerSecond;
            WaterForUpgrade = config.WaterForUpgrade;
            FoodForUpgrade = FoodForUpgrade;
        }
    }
}