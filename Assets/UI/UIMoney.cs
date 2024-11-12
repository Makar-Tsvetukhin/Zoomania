using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIMoney : MonoBehaviour
{
	public GameObject Animal;
	public TextMeshProUGUI Text;
	public AnimalMoney animalmoneyscript;

	void Start()
	{
		Animal = GameObject.Find("Панда");
		Text = this.gameObject.GetComponent<TextMeshProUGUI>();
		Text.text += animalmoneyscript.IncomeMoney.Resource.GetValue().ToString();

		animalmoneyscript = Animal.GetComponent<AnimalMoney>();
		animalmoneyscript.OnChange += UpdateUI;
	}

	public void UpdateUI()
	{
		if (Animal == null)
		{
			Animal = GameObject.Find("Панда");
			animalmoneyscript = Animal.GetComponent<AnimalMoney>();
		}
		Text.text = $"Количество монет: {animalmoneyscript.IncomeMoney.Resource.GetValue()}";
	}
}