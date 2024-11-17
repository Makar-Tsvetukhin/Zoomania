using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIWater : MonoBehaviour
{
	public GameObject WaterBuilding;
	public TextMeshProUGUI Text;
	public WaterBuilding waterbuildingscript;

	void Start()
	{
		WaterBuilding = GameObject.FindGameObjectWithTag("WaterBuilding");
		Text = this.gameObject.GetComponent<TextMeshProUGUI>();
		Text.text += waterbuildingscript.IncomeWater.Resource.GetValue().ToString();

		waterbuildingscript = WaterBuilding.GetComponent<WaterBuilding>();
		waterbuildingscript.OnChange += UpdateUI;
	}

	public void UpdateUI()
	{
		Text.text = $"Количество воды: {waterbuildingscript.IncomeWater.Resource.GetValue()}";
	}
}