using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Barn : MonoBehaviour, IPointerClickHandler
{
	public GameObject Animal;
	public IntStorage ClicksToSpawn { get; set; }
	public int MaxClicksToSpawn { get; set; } = 10;
	public int ClicksValueChange { get; set; } = 2;


	public void Start()
	{
		ClicksToSpawn = new IntStorage(MaxClicksToSpawn);
	}

	public void OnPointerClick(PointerEventData data)
	{
		ClicksToSpawn.SetValue(1, false);
		if (ClicksToSpawn.GetValue() == 0) SpawnAnimal();
	}

	public void SpawnAnimal()
	{
		Instantiate(Animal);
		MaxClicksToSpawn *= ClicksValueChange;
		ClicksToSpawn.SetValue(MaxClicksToSpawn, true);
	}
}
