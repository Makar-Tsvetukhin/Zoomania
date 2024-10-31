using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBuilding
{
	public int Value { get; set; }

	public int IncreasingValue { get; set; }


	public LevelBuilding(int value, int increasingvalue)
	{
		Value = value;
		IncreasingValue = increasingvalue;
	}


	public void LevelUp()
	{
		Value *= IncreasingValue;
		Debug.Log("Уровень здания повышен!");
		Debug.Log($"Доход увеличен до {Value}");
	}

	public int GetValue()
	{
		return Value;
	}
}