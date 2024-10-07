using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Animal
{
    public class Animals : MonoBehaviour
    {
        public int ClicksToCreate { get; set; }
        public int RequiredWater { get; set; }
        public int RequiredFood { get; set; }
        public int MoneyPerClick { get; set; }
        public int MoneyPerSecond { get; set; }
        public int WaterForUpgrade { get; set; }
        public int FoodForUpgrade { get; set; }
    }
}