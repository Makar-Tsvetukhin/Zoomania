using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIFood : MonoBehaviour
{
	public GameObject FoodBuilding;
	public TextMeshProUGUI Text;
	public FoodBuilding foodbuildingscript;

	void Start()
	{
		FoodBuilding = GameObject.FindGameObjectWithTag("FoodBuilding");
		foodbuildingscript = FoodBuilding.GetComponent<FoodBuilding>();
		Text = this.gameObject.GetComponent<TextMeshProUGUI>();
		Text.text += foodbuildingscript.IncomeFood.Resource.GetValue().ToString();
		foodbuildingscript.OnChange += UpdateUI;
	}

	public void UpdateUI()
	{
		Text.text = $"Количество еды: {foodbuildingscript.IncomeFood.Resource.GetValue()}";
	}
}