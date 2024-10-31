using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
	public int CurrentLevelNumber { get; set; }

	public int ResourceNumber { get; set; }

	public Sprite Sprite { get; set; }

	public LevelBuilding Level = new LevelBuilding(1, 5);

	public Building(Sprite sprite)
	{
		CurrentLevelNumber = 1;
		ResourceNumber = 1;
		Sprite = sprite;
	}

	public void LevelUp()
	{
		Level.LevelUp();
	}

	public int GetResourceNumber()
	{
		return ResourceNumber;
	}
}