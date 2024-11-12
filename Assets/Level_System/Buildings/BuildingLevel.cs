using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
	public int CurrentLevelNumber {  get; set; }
	public int IncomePerSecondValue { get; set; }
	public int IncomePerClickValue { get; set; }
	public int NewLevelIncomeValueS { get; set; }
	public int NewLevelIncomeValueC { get; set; }

	public Level() { }

	public Level(int incomePerSecondValue, int incomePerClickValue, int newLevelIncomeValueS, int newLevelIncomeValueC)
	{
		CurrentLevelNumber = 1;
		IncomePerSecondValue = incomePerSecondValue;
		IncomePerClickValue = incomePerClickValue;
		NewLevelIncomeValueS = newLevelIncomeValueS;
		NewLevelIncomeValueC = newLevelIncomeValueC;
	}

	public void LevelUp()																//Надо сделать условие которое будет проверять количество монет
	{
		CurrentLevelNumber++;
		IncomePerSecondValue += NewLevelIncomeValueS;
		IncomePerClickValue += NewLevelIncomeValueC;
	}
}
